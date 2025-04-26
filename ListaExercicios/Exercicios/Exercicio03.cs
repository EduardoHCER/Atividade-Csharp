using System.ComponentModel;

namespace Exercicios
{
    public class Exercicio03
    {
        public static void Executar()
        {
            Console.WriteLine("Executando exercício 03");

            //Declaração de variavel.
            int fat = 1; //fatorial deve iniciar em 1 caso usuario digite 0 ou 1.
            int numero;

            // Do-While para impedir entrada errada.
            do
            {
                Console.WriteLine("Digite um numero: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out numero) && numero > 0) // int.TryParse força a converter em inteiro.
                {
                    break; //sai do laço Do-While.
                }
                else
                {
                    Console.WriteLine("Entrada invalida");
                }
            } while (true);

            int n = numero;

            // Executa a equação do Fatorial até que 'n' seja menor que 1.
            while (n >= 1)
            {
                fat = fat * n;
                n--;
            }
            Console.WriteLine($"\nO fatorial de {numero} é {fat}.");
        }
    }
}
