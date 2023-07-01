using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Views
{
    public class ClinicView
    {
        private ClinicController clinicController;
        public ClinicView()
        {
            clinicController = new ClinicController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Cadastro de Clinica");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Clinica");
            Console.WriteLine("2 - Listar Clínicas");
            Console.WriteLine("3 - Exportar Arquivo de texto");
            Console.WriteLine("4 - Importar Arquivo de texto");
            Console.WriteLine("5 - Buscar clinica por nome");
            Console.WriteLine("0 - Retornar ao menu principal");
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
                case 3:
                    Export();
                    break;
                case 4:
                    Import();
                    break;
                case 5:
                    SearchByName();
                break;

            }
        }

        private void List()
        {
            List<Clinic> listagem = clinicController.List();

            for(int i = 0; i < listagem.Count; i++)
            {
                Console.WriteLine( Print( listagem[i] ) );
            }
            
        }

        private string Print(Clinic clinic)
        {
            string retorno = "";
            retorno += "------------------------------------------- \n";
            retorno += $"Id: {clinic.Id} \n";
            retorno += $"Nome: {clinic.ClinicName} \n";
            retorno += $"Espécie: {clinic.CNPJ} \n";
            retorno += $"Raça: {clinic.Phone} \n";
            retorno += $"Idade: {clinic.Owner} \n";
            retorno += "-------------------------------------------";
            Thread.Sleep(1000);
            return retorno;
        }
        private void Insert()
        {
            Clinic clinic = new Clinic();
            clinic.Id = clinicController.GetNextID();

            Console.WriteLine("Informe o nome da Clinica: ");
            clinic.ClinicName = Console.ReadLine();
            
            Console.WriteLine("Informe o CNPJ: ");
            clinic.CNPJ = Console.ReadLine();
            
            Console.WriteLine("Informe um número para contato: ");
            clinic.Phone = Console.ReadLine();
            
            Console.WriteLine("Informe o nome do proprietário: ");
            clinic.Owner = Console.ReadLine();

            bool retorno = clinicController.Insert(clinic);

            if( retorno )
                Console.WriteLine("Clinica registrada com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados");
        }

        private void Export()
        {
            if( clinicController.ExportToTextFile() )            
                Console.WriteLine("Arquivo gerado com sucesso!");            
            else                            
                Console.WriteLine("Oooops.");
        }

                private void Import()
        {
            if(clinicController.ImportFromTxtFile())
                Console.WriteLine("Dados importados com sucesso!");
            else
                Console.WriteLine("Ooooops.");
        }

                private void SearchByName()
        {
            Console.WriteLine("Pesquisar clinica pelo nome.");
            Console.WriteLine("Digite o nome:");
            string? name = Console.ReadLine();

            foreach( Clinic c in 
                clinicController.SearchByName(name) )
            {
                Console.WriteLine( c.ToString() );
            }
        }

    }
}