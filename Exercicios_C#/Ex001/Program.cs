using System;
Console.WriteLine("Digite um número:");
int input = Convert.ToInt32(Console.ReadLine());

if (input % 2 == 0)
{
    Console.WriteLine($"{input} é PAR");
}
else if (input % 2 == 1)
{
    System.Console.WriteLine($"{input} é IMPAR");
}
else
{
    System.Console.WriteLine($"{input} não é um número válido");
}