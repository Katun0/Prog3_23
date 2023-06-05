using Arquivos.Models;
using Arquivos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Controllers
{
    public class ClientController
    {
        public int GetNextID()
        {
            int tam = DataSet.Clients.Count;
            if(tam > 0)
                return DataSet.Clients[tam-1].Id+1;
            else
                return 1; 
        }
    }
}