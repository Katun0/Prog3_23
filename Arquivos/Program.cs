using Arquivos.Views;
using Arquivos.Utils;

/*
    Programa para leitura de dados de pessoas
    e exportação em arquivo .txt
*/
Bootstrapper.ChargeClients();
Bootstrapper.ChargeAnimals();
Bootstrapper.ChargeDoctors();
Bootstrapper.ChargeClinics();

int option = 0;

do
{
    Console.WriteLine("*******************************************");
    Console.WriteLine("Programa para leitura e exportação de dados");
    Console.WriteLine("*******************************************");
    Console.WriteLine("");    
    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Animais");
    Console.WriteLine("3 - Veterinários");
    Console.WriteLine("4 - Clínica");
    Console.WriteLine("0 - Sair");

    option = Convert.ToInt32( Console.ReadLine() );

    switch(option)
    {
        case 1 :
            Console.WriteLine("Cadastro de Clientes");
            ClientView clientView = new ClientView();
            break;

        case 2 :
            Console.WriteLine("Cadastro de Animais");
            AnimalView animalView = new AnimalView();
            break;
        case 3:
            Console.WriteLine("Cadastro de Veterinários");
            DoctorView doctorView = new DoctorView();
            break;        
        case 4:
            Console.WriteLine("Cadastro de Clínicas");
            ClinicView clinicView = new ClinicView();
            break;
    }
}
while( option > 0 );