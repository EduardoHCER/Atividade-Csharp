namespace Exercicios
{
    public class Exercicio04
    {
        public static void Executar()
        {
            Console.WriteLine("Executando exercício 04");

            while (true) // Loop infinito, usado para manter o menu funcionando até o usuário decidir sair
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Celsius para Fahrenheit");
                Console.WriteLine("2 - Fahrenheit para Celsius");
                Console.WriteLine("3 - Sair");
                Console.WriteLine("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao) // Escolha da funcionalidade com base na entrada do usuário
                {
                    case "1":
                        Console.Write("Digite a temperatura em Celsius: ");
                        if (double.TryParse(Console.ReadLine(), out double celsius)) // Validação segura da entrada
                        {
                            double fahrenheit = (celsius * 9 / 5) + 32; // Fórmula de conversão
                            Console.WriteLine($"Resultado: {celsius}°C = {fahrenheit}°F\n");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido. Tente novamente.\n");
                        }
                        break;

                    case "2":
                        Console.Write("Digite a temperatura em Fahrenheit: ");
                        if (double.TryParse(Console.ReadLine(), out double fah)) // TryParse evita exceções ao converter
                        {
                            double cel = (fah - 32) * 5 / 9; // Fórmula de conversão inversa
                            Console.WriteLine($"Resultado: {fah}°F = {cel}°C\n");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido. Tente novamente.\n");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Saindo do programa...");
                        return; // Interrompe o método, saindo do loop e do programa

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.\n"); // Tratamento de entrada incorreta
                        break;
                }
            }
        }
    }
}
