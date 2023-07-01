using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Clinic
    {
        public Clinic(int id,
        string? clinicName,
        string? cNPJ,
        string? phone,
        string? owner)
        {
            Id = id;
            ClinicName = clinicName;
            CNPJ = cNPJ;
            Phone = phone;
            Owner = owner;
        }

        public Clinic()
        {
            
        }

        public int Id { get; set; }
        public string? ClinicName { get; set; }
        public string? CNPJ { get; set; }
        public string? Phone { get; set; }
        public string? Owner { get; set; }
    }
}