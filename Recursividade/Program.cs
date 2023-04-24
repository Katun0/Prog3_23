using System;
class Recursividade {
    static void Main(string[] args) {
    //Número multiplicado
        Console.WriteLine("Digite um número:");
        int num = Convert.ToInt32(Console.ReadLine());
    // Começa com o primeiro multiplicador    
        int i = 1; 
    //Teto de multiplicações
        Console.WriteLine("Digite até quanto vai a tabuada: ");
        int limit = Convert.ToInt32(Console.ReadLine());
    //Função para multiplicar
        ImprimeTabuada(num, limit, i);
    }

    static void ImprimeTabuada(int num, int limit, int i) {
        if (i > limit) //Caso base
        {
            Console.WriteLine($"Tauaba Completa");
        }
        else if (i <= limit) {
            Console.WriteLine($"{num} x {i} = {num*i}\r");
            i++;
            ImprimeTabuada(num, limit, i); // Chamada recursiva
        }
    }
}