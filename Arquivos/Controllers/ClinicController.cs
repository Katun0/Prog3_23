using Arquivos.Models;
using Arquivos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Controllers
{
    public class ClinicController
    {

        private string directoryName = "ReportFiles";
        private string fileName = "Clinicas.txt";

        public int GetNextID()
        {
            int tam = DataSet.Clinics.Count;
            if(tam > 0)
                return DataSet.Clinics[tam-1].Id+1;
            else
                return 1; 
        }
        public bool Insert(Clinic clinic)
        {
            if( clinic == null )
                return false;

            if( clinic.Id <= 0 )
                return false;

            if( string.IsNullOrWhiteSpace(clinic.ClinicName) )
                return false;

            DataSet.Clinics.Add(clinic);

            return true;
        }
        public List<Clinic> List()
        {
            return DataSet.Clinics;
        }

        public bool ExportToTextFile()
      {
        if(!Directory.Exists(directoryName))
          Directory.CreateDirectory(directoryName);

        string fileContent = string.Empty;
        foreach(Clinic c in DataSet.Clinics)
        {
          fileContent += $"{c.Id};{c.ClinicName};{c.CNPJ};{c.Phone};{c.Owner}";
          fileContent += "\n";
        }

        try
        {
          StreamWriter sw = File.CreateText( 
            $"{directoryName}\\{fileName}" 
          );

          sw.Write(fileContent);
          sw.Close();        
        }
        catch(IOException ioEx)
        {
          Console.WriteLine("Erro ao manipular o arquivo.");
          Console.WriteLine(ioEx.Message);
          return false;
        }
        
        return true;
        }

              public bool ImportFromTxtFile()
      {
        try
        {
          StreamReader sr = new StreamReader(
            $"{directoryName}\\{fileName}"
          );

          string line = string.Empty;
          line = sr.ReadLine();
          while(line != null)
          {
            Clinic clinic = new Clinic();
            string[] clinicData = line.Split(';');
            clinic.Id = Convert.ToInt32( clinicData[0] );
            clinic.ClinicName = clinicData[1];
            clinic.CNPJ = clinicData[2];
            clinic.Phone = clinicData[3];
            clinic.Owner = clinicData[4];

            DataSet.Clinics.Add(clinic);

            line = sr.ReadLine();
          }

          return true;
        }
        catch(Exception ex)
        {
          Console.WriteLine("Ooops. Ocorreu um erro ao tentar importar os dados.");
          Console.WriteLine(ex.Message);
          return false;
        }

      }

        public List<Clinic> SearchByName(string name)
      {
        if ( string.IsNullOrEmpty(name) ||
             string.IsNullOrWhiteSpace(name) 
           )
           return null;

        List<Clinic> clinics = new List<Clinic>();
        for(int i = 0; i < DataSet.Clinics.Count; i++)  
        {
          var c = DataSet.Clinics[i];
          if( c.ClinicName.ToLower().Contains(name.ToLower()) )
          {
            clinics.Add(c);
          }
        }
        return clinics;

      }

    }
}
