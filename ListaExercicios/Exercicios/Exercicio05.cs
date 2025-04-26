namespace Exercicios
{
    public class Exercicio05
    {
        public static void Executar()
        {
            Console.WriteLine("Executando exercício 01");

            //Pedindo a frase ao usuario
            Console.WriteLine("Digite uma palavra ou frase: ");
            string entrada = Console.ReadLine();

            //Removendo espaço com .Replace e deixando tudo em minusculo com .ToLower
            string texto = entrada.Replace(" ", "").ToLower();

            //
            char[] array = texto.ToCharArray();
            Array.Reverse(array);
            string invertida = new string(array);

            if (texto == invertida)
            {
                Console.WriteLine("É um palindromo");
            }
            else
            {
                Console.WriteLine("Não é um palindromo.");
            }
        }
    }
}
