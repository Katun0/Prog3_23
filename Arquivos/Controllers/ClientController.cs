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
        public List<Client> List()
        {
            return DataSet.Clients;
        }


        public bool Insert(Client client)
        {
            if( client == null )
                return false;

            if( client.Id <= 0 )
                return false;

            if( string.IsNullOrWhiteSpace(client.FirstName) )
                return false;

            DataSet.Clients.Add(client);

            return true;
        }
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