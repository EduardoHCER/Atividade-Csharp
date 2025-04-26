namespace Exercicios
{
    public class Exercicio02
    {
        public static void Executar()
        {
            Console.WriteLine("Executando exercício 02");
            int n;

            do
            {
                // Pedindo o número ao usuário
                Console.WriteLine("Digite um numero: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out n))
                {
                    break; //Sai do laço se a entrada for válida.
                }
            } while (true);

            Console.WriteLine("Tabuada do " + n);

            for (int i = 1; i <= 10; i++)
            {
                int x = n * i;
                Console.WriteLine($"{n} x {i} = {x}");
            }
        }
    }
}
