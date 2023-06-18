using Arquivos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Data
{
    public static class DataSet
    {
        public static List<Client> Clients 
            = new List<Client>();

        public static List<Animal> Animals
            = new List<Animal>();
    }
}