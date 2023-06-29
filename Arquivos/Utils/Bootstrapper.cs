using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Utils
{
    public static class Bootstrapper
    {
        public static void ChargeClients()
        {
            var c1 = new Client{
                Id = 1,
                FirstName = "Mauricio Roberto",
                LastName = "Gonzatto",
                CPF = "000.000.000-00",
                Email = "mauricio.gonzatto@unoesc.edu.br"
            };
            DataSet.Clients.Add(c1);

            DataSet.Clients.Add(
                new Client{
                    Id = 2,
                    FirstName = "Eduardo",
                    LastName = "Blank",
                    CPF = "000.000.000-01",
                    Email = "eduardo.blank@unoesc.edu.br"                    
                }
            );

             DataSet.Clients.Add(
                new Client{
                    Id = 3,
                    FirstName = "Aguinaldo",
                    LastName = "Timóteo",
                    CPF = "000.000.000-02",
                    Email = "aguinaldo@unoesc.edu.br"                    
                }
            );            

        }
    }
}