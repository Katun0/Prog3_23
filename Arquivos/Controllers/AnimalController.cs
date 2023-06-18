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
    }
}
