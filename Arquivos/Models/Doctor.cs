using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Doctor
    {
        public Doctor(int id,
        string? name,
        string? speciality
            )
        {
            Id = id;
            Name = name;
            Speciality = speciality;

        }

        public Doctor()
        {
            
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Speciality { get; set; }

    }
}