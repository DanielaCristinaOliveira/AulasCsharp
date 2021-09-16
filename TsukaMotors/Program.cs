using System;

namespace TsukaMotors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //vamos criar um menu de opções

            do
            {
                Console.WriteLine("[1] - Cadastrar Veículo");
                Console.WriteLine("[2] - Listar Veículo");
                Console.WriteLine("[0] - Sair");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                    //Aqui iremos cadastrar um veiculo
                    VeiculoController veiculoController = new VeiculoController();
                    veiculoController.CadastrarVeiculo();
                    break;
                    case "2":
                    //Aqui vamos listar os veículos cadastrados

                    break;
                    case "0":
                    Console.WriteLine("Obrigado por utilizar nosso sistema");
                    break;
                    default:
                    Console.WriteLine("Error");
                    break;
                }
            }while (opcao != "0");

            {

        }
    }
}
