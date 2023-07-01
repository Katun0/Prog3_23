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
        string? color)
        {
            Id = id;
            AnimalName = animalName;
            Specie = specie;
            Race = race;
            Color = color;
        }

        public Animal()
        {
            
        }

        public int Id { get; set; }
        public string? AnimalName { get; set; }
        public string? Specie { get; set; }
        public string? Race { get; set; }
        public string? Color { get; set; }
    }
}