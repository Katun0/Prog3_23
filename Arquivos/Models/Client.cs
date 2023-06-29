using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{ // Início do ESCOPO do Namespace

    public class Client
    { // Início do ESCOPO da classe

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }

        // Os métodos contrutores são responsáveis
        // por instanciar uma variável do tipo especificado
        // pela classe. 
        // A regra é de que o Contrutor tenha o mesmo nome da classe.
        public Client()
        {

        }

        // Método SEMPRE utiliza ()
        public Client(
            int id
            , string? firstName
            , string? lastName
            , string? cPF
            , string? email
        )
        { // Início do escopo deste método
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CPF = cPF;
            Email = email;
        } // Fim do escopo deste método

        public string FullName => 
            $"{this.FirstName} {this.LastName}";


        public override string ToString()
        {   
            return $"Id: {this.Id}; Name: {this.FullName} ";
        }

    } // Fim do ESCOPO da Classe

} // Fim do ESCOPO do Namespace