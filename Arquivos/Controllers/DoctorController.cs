using Arquivos.Models;
using Arquivos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Controllers
{
    public class DoctorController
    {

        private string directoryName = "ReportFiles";
        private string fileName = "Doctors.txt";

        public int GetNextID()
        {
            int tam = DataSet.Doctors.Count;
            if(tam > 0)
                return DataSet.Doctors[tam-1].Id+1;
            else
                return 1; 
        }
        public bool Insert(Doctor doctor)
        {
            if( doctor == null )
                return false;

            if( doctor.Id <= 0 )
                return false;

            if( string.IsNullOrWhiteSpace(doctor.Name) )
                return false;

            DataSet.Doctors.Add(doctor);

            return true;
        }
        public List<Doctor> List()
        {
            return DataSet.Doctors;
        }

        public bool ExportToTextFile()
      {
        if(!Directory.Exists(directoryName))
          Directory.CreateDirectory(directoryName);

        string fileContent = string.Empty;
        foreach(Doctor c in DataSet.Doctors)
        {
          fileContent += $"{c.Id};{c.Name};{c.Speciality};";
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
            Doctor doctor = new Doctor();
            string[] doctorData = line.Split(';');
            doctor.Id = Convert.ToInt32( doctorData[0] );
            doctor.Name = doctorData[1];
            doctor.Speciality = doctorData[2];

            DataSet.Doctors.Add(doctor);

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

        public List<Doctor> SearchByName(string name)
      {
        if ( string.IsNullOrEmpty(name) ||
             string.IsNullOrWhiteSpace(name) 
           )
           return null;

        List<Doctor> doctors = new List<Doctor>();
        for(int i = 0; i < DataSet.Doctors.Count; i++)  
        {
          var c = DataSet.Doctors[i];
          if( c.Name.ToLower().Contains(name.ToLower()) )
          {
            doctors.Add(c);
          }
        }
        return doctors;

      }

    }
}
