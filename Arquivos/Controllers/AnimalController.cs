using Arquivos.Models;
using Arquivos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Controllers
{
    public class AnimalController
    {

        private string directoryName = "ReportFiles";
        private string fileName = "Animals.txt";

        public int GetNextID()
        {
            int tam = DataSet.Animals.Count;
            if(tam > 0)
                return DataSet.Animals[tam-1].Id+1;
            else
                return 1; 
        }
        public bool Insert(Animal animal)
        {
            if( animal == null )
                return false;

            if( animal.Id <= 0 )
                return false;

            if( string.IsNullOrWhiteSpace(animal.AnimalName) )
                return false;

            DataSet.Animals.Add(animal);

            return true;
        }
        public List<Animal> List()
        {
            return DataSet.Animals;
        }

        public bool ExportToTextFile()
      {
        if(!Directory.Exists(directoryName))
          Directory.CreateDirectory(directoryName);

        string fileContent = string.Empty;
        foreach(Animal c in DataSet.Animals)
        {
          fileContent += $"{c.Id};{c.AnimalName};{c.Specie};{c.Race};{c.Color}";
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
            Animal animal = new Animal();
            string[] animalData = line.Split(';');
            animal.Id = Convert.ToInt32( animalData[0] );
            animal.AnimalName = animalData[1];
            animal.Specie = animalData[2];
            animal.Race = animalData[3];
            animal.Color = animalData[4];

            DataSet.Animals.Add(animal);

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

        public List<Animal> SearchByName(string name)
      {
        if ( string.IsNullOrEmpty(name) ||
             string.IsNullOrWhiteSpace(name) 
           )
           return null;

        List<Animal> animals = new List<Animal>();
        for(int i = 0; i < DataSet.Animals.Count; i++)  
        {
          var c = DataSet.Animals[i];
          if( c.AnimalName.ToLower().Contains(name.ToLower()) )
          {
            animals.Add(c);
          }
        }
        return animals;

      }

    }
}
