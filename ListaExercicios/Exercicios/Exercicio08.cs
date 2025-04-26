using System.Globalization; // Necessário para configurar como os números decimais são lidos (ponto ou vírgula)

namespace Exercicios
{
    public class Exercicio08
    {
        public static void Executar()
        {
            Console.WriteLine("Executando exercício 08");

            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite suas informações: ");
            Console.WriteLine("\nSeu peso: ");
            pessoa.peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            // Uso de CultureInfo.InvariantCulture permite aceitar números com ponto decimal.

            Console.WriteLine("\nSua altura: ");
            pessoa.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Condições baseadas na classificação do IMC
            if (pessoa.IMC() < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (pessoa.IMC() <= 24.9)
            {
                Console.WriteLine("Peso normal");
            }
            else if (pessoa.IMC() <= 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obesidade");
            }

            Console.WriteLine($"IMC: {pessoa.IMC()}"); // Mostra o valor calculado de IMC
        }
    }

    class Pessoa
    {
        public double peso { get; set; }   // Propriedade com encapsulamento padrão
        public double altura { get; set; }

        public double IMC()
        {
            return peso / (altura * altura); // Fórmula do Índice de Massa Corporal
        }
    }
}
