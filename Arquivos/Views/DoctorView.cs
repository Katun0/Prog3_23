using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Controllers;
using Arquivos.Models;

namespace Arquivos.Views
{
    public class DoctorView
    {
        private DoctorController doctorController;
        public DoctorView()
        {
            doctorController = new DoctorController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Cadastro de Doutores");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Doutor");
            Console.WriteLine("2 - Listar Doutores");
            Console.WriteLine("3 - Exportar Arquivo de texto");
            Console.WriteLine("4 - Importar Arquivo de texto");
            Console.WriteLine("5 - Buscar doutor por nome");
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
            List<Doctor> listagem = doctorController.List();

            for(int i = 0; i < listagem.Count; i++)
            {
                Console.WriteLine( Print( listagem[i] ) );
            }
            
        }

        private string Print(Doctor doctor)
        {
            string retorno = "";
            retorno += "------------------------------------------- \n";
            retorno += $"Id: {doctor.Id} \n";
            retorno += $"Nome: {doctor.Name} \n";
            retorno += $"Especialidade: {doctor.Speciality} \n";
            retorno += "-------------------------------------------";
            Thread.Sleep(1000);
            return retorno;
        }
        private void Insert()
        {
            Doctor doctor = new Doctor();
            doctor.Id = doctorController.GetNextID();

            Console.WriteLine("Informe o nome do doutor: ");
            doctor.Name = Console.ReadLine();
            
            Console.WriteLine("Informe a Especialidade: ");
            doctor.Speciality = Console.ReadLine();
        

            bool retorno = doctorController.Insert(doctor);

            if( retorno )
                Console.WriteLine("Doutor registrado com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados");
        }

        private void Export()
        {
            if( doctorController.ExportToTextFile() )            
                Console.WriteLine("Arquivo gerado com sucesso!");            
            else                            
                Console.WriteLine("Oooops.");
        }

                private void Import()
        {
            if(doctorController.ImportFromTxtFile())
                Console.WriteLine("Dados importados com sucesso!");
            else
                Console.WriteLine("Ooooops.");
        }

                private void SearchByName()
        {
            Console.WriteLine("Pesquisar doutor pelo nome.");
            Console.WriteLine("Digite o nome:");
            string? name = Console.ReadLine();

            foreach( Doctor c in 
                doctorController.SearchByName(name) )
            {
                Console.WriteLine( c.ToString() );
            }
        }
   
    }
}