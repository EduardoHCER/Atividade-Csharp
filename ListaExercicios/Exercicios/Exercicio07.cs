/*
Soma de Números Pares de um Array
Peça ao usuário 10 números e armazene em um array. Depois, calcule a soma apenas
dos números pares.
*/

namespace Exercicios
{
    public class Exercicio07
    {
        public static void Executar()
        {
            Console.WriteLine("Executando exercício 07");

            int[] numeros = new int[10]; //Vetor de 10 posições inteiras.
            int somaPares = 0;

            //Loop para pedir os 10 numeros, ler e verificar se são pares.
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o valor do indice[{i + 1}]: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if (numeros[i] % 2 == 0)
                {
                    somaPares += numeros[i];
                }
            }

            //Impressão do resultado.
            Console.WriteLine($"Soma dos numeros pares: {somaPares}");
        }
    }
}
