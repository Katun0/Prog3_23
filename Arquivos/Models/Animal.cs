using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Animal
    {
        public Animal(int id,
        string? animalName,
        string? specie,
        string? race,
        string? age)
        {
            Id = id;
            AnimalName = animalName;
            Specie = specie;
            Race = race;
            Age = age;
        }

        public Animal()
        {
            
        }

        public int Id { get; set; }
        public string? AnimalName { get; set; }
        public string? Specie { get; set; }
        public string? Race { get; set; }
        public string? Age { get; set; }
    }
}