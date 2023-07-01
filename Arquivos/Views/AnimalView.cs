using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Views
{
    public class AnimalView
    {
        private AnimalController animalController;
        public AnimalView()
        {
            animalController = new AnimalController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Cadastro de Animais");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Animais");
            Console.WriteLine("2 - Listar Animais");
            Console.WriteLine("3 - Exportar arquivo de texto");
            Console.WriteLine("4 - Importar arquivo de texto");
            Console.WriteLine("5 - Buscar animal por nome");
            Console.WriteLine("0 - Retornar para o menu principal");
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
            List<Animal> listagem = animalController.List();

            for(int i = 0; i < listagem.Count; i++)
            {
                Console.WriteLine( Print( listagem[i] ) );
            }
            
        }

        private string Print(Animal animal)
        {
            string retorno = "";
            retorno += "------------------------------------------- \n";
            retorno += $"Id: {animal.Id} \n";
            retorno += $"Nome: {animal.AnimalName} \n";
            retorno += $"Espécie: {animal.Specie} \n";
            retorno += $"Raça: {animal.Race} \n";
            retorno += $"Idade: {animal.Color} \n";
            retorno += "-------------------------------------------";
            Thread.Sleep(1000);
            return retorno;
        }
        private void Insert()
        {
            Animal animal = new Animal();
            animal.Id = animalController.GetNextID();

            Console.WriteLine("Informe o nome do animal: ");
            animal.AnimalName = Console.ReadLine();
            
            Console.WriteLine("Informe a espécie: ");
            animal.Specie = Console.ReadLine();
            
            Console.WriteLine("Informe a raça: ");
            animal.Race = Console.ReadLine();
            
            Console.WriteLine("Informe a cor: ");
            animal.Color = Console.ReadLine();

            bool retorno = animalController.Insert(animal);

            if( retorno )
                Console.WriteLine("Animal registrado com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados");
        }

        private void Export()
        {
            if( animalController.ExportToTextFile() )            
                Console.WriteLine("Arquivo gerado com sucesso!");            
            else                            
                Console.WriteLine("Oooops.");
        }

                private void Import()
        {
            if(animalController.ImportFromTxtFile())
                Console.WriteLine("Dados importados com sucesso!");
            else
                Console.WriteLine("Ooooops.");
        }

                private void SearchByName()
        {
            Console.WriteLine("Pesquisar animal pelo nome.");
            Console.WriteLine("Digite o nome:");
            string? name = Console.ReadLine();

            foreach( Animal c in 
                animalController.SearchByName(name) )
            {
                Console.WriteLine( c.ToString() );
            }
        }

    }
}