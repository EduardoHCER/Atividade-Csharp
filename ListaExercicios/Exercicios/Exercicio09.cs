namespace Exercicios
{
    public class Exercicio09
    {
        public static void Executar()
        {
            Console.WriteLine("Executando exercício 09");

            int chute;
            int contador = 0;

            //Gerar numero random  entre 1-100. e mostra-lo.
            Random random = new Random();
            int aleatorio = random.Next(1, 101);
            Console.WriteLine(aleatorio);

            do
            {
                Console.WriteLine("=== Jogo de advinhação ===");
                Console.WriteLine("Chute um numero: ");
                chute = int.Parse(Console.ReadLine());

                if (chute > aleatorio)
                {
                    Console.WriteLine("Random é menor que seu chute");
                }
                else
                {
                    Console.WriteLine("Random é maior que seu chute");
                }
                contador++;
            } while (chute != aleatorio);

            Console.WriteLine("\nVocê acertou o numero.");
            Console.WriteLine("Tentativas: " + contador);
        }
    }
}
