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
            Console.WriteLine("3 - Exportar Animais");
            Console.WriteLine("4 - Importar Animais");
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
            List<Animal> listagem = animalController.List();

            for(int i = 0; i < listagem.Count; i++)
            {
                Console.WriteLine( Print( listagem[i] ) );
            }

        }

        private string Print(Animal animal)
        {
            string retorno = "";
            retorno += $"Id: {animal.Id} \n";
            retorno += $"Nome: {animal.AnimalName} \n";
            retorno += $"Espécie: {animal.Specie} \n";
            retorno += $"Raça: {animal.Race} \n";
            retorno += $"Idade: {animal.Age} \n";
            retorno += "-------------------------------------------";

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
            
            Console.WriteLine("Informe A idade: ");
            animal.Age = Console.ReadLine();

            bool retorno = animalController.Insert(animal);

            if( retorno )
                Console.WriteLine("Animal registrado com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados");
        }
    }
}