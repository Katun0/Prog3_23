using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Views
{
    public class ClientView
    {
        private ClientController clientController;
        public ClientView()
        {
            clientController = new ClientController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Você está em CLIENTES");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Clientes");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("3 - Exportar Clientes");
            Console.WriteLine("4 - Importar Clientes");
            int option = 0;
            switch(option) 
            {
                case 1:
                    Insert();
                break;
                default:
                
                break;
            }
        }

        private void Insert()
        {
            Client client = new Client();
            client.Id = clientController.GetNextID();

            Console.WriteLine("Informe o primeiro nome: ");
            client.FirstName = Console.ReadLine();
            
            Console.WriteLine("Informe o sobrenome: ");
            client.FirstName = Console.ReadLine();
            
            Console.WriteLine("Informe o CPF: ");
            client.CPF = Console.ReadLine();
            
            Console.WriteLine("Informe o Email: ");
            client.Email = Console.ReadLine();


        }
    }
}