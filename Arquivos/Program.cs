using Arquivos.Views;
/*
    Programa para leitura e exportação de dados
    exportação em arquivo .txt
*/
int option = 0;
do
{
    Console.WriteLine("*******************************************");
    Console.WriteLine("Programa para leitura e exportação de dados");
    Console.WriteLine("*******************************************");
    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Animais");
    Console.WriteLine("0 - Sair");
    option = Convert.ToInt32(Console.ReadLine());


    try
    {
        Convert.ToInt32(option);
    }
    catch (FormatException)
    {
        Console.WriteLine("Formato Inválido, favor tentar inserir um valor numérico");
    }

    switch(option)
    {
        case 1 :
            Console.WriteLine("Opção clientes");
            ClientView clientView = new ClientView();
        break;
        case 2:
            Console.WriteLine("Opção Animais");
            AnimalView animalView = new AnimalView();
        break;
    
    }
}
while(option != 0);
{

}
