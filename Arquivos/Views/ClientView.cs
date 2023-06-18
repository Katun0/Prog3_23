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
            option = Convert.ToInt32(Console.ReadLine());
            switch(option) 
            {
                case 1:
                    Insert();
                break;

                case 2:
                    List();
                break;
                default:
                
                break;
            }
        }

        private void List()
        {
            List<Client> listagem = clientController.List();

            for(int i = 0; i < listagem.Count; i++)
            {
                Console.WriteLine( Print( listagem[i] ) );
            }

        }

        private string Print(Client client)
        {
            string retorno = "";
            retorno += $"Id: {client.Id} \n";
            retorno += $"Nome: {client.FirstName} {client.LastName} \n";
            retorno += "-------------------------------------------";

            return retorno;
        }
        private void Insert()
        {
            Client client = new Client();
            client.Id = clientController.GetNextID();

            Console.WriteLine("Informe o primeiro nome: ");
            client.FirstName = Console.ReadLine();
            
            Console.WriteLine("Informe o sobrenome: ");
            client.LastName = Console.ReadLine();
            
            Console.WriteLine("Informe o CPF: ");
            client.CPF = Console.ReadLine();
            
            Console.WriteLine("Informe o Email: ");
            client.Email = Console.ReadLine();

            bool retorno = clientController.Insert(client);

            if( retorno )
                Console.WriteLine("Cliente inserido com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados");
        }
    }
}