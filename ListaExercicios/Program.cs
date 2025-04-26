using System;
using Exercicios;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Escolha o Exercício (1 a 10) ou 0 para sair:");
            string input = Console.ReadLine();

            // Valida se o que foi digitado é um número e impede de travar.
            if (!int.TryParse(input, out int opcao))
            {
                Console.WriteLine("Entrada inválida. Digite um número.");
                continue;
            }

            switch (opcao)
            {
                case 0:
                    continuar = false;
                    Console.WriteLine("Encerrando...");
                    break;
                case 1:
                    Exercicio01.Executar();
                    break;
                case 2:
                    Exercicio02.Executar();
                    break;
                case 3:
                    Exercicio03.Executar();
                    break;
                case 4:
                    Exercicio04.Executar();
                    break;
                case 5:
                    Exercicio05.Executar();
                    break;
                case 6:
                    Exercicio06.Executar();
                    break;
                case 7:
                    Exercicio07.Executar();
                    break;
                case 8:
                    Exercicio08.Executar();
                    break;
                case 9:
                    Exercicio09.Executar();
                    break;
                case 10:
                    Exercicio10.Executar();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Escolha de 1 a 10 ou 0 para sair.");
                    break;
            }

            Console.WriteLine(); // linha extra por estética
        }
    }
}
