namespace Exercicios
{
    public class Exercicio01
    {
        public static void Executar()
        {
            string charespecial = "!@#$%¨&*()-+"; // Denominando os caracteres especiais

            // Variáveis para verificar as condições
            bool n = false;
            bool c = false;
            bool tam = false;
            bool especial = false;

            Console.WriteLine("Executando exercício 01");

            // Pedindo a senha ao usuário
            Console.WriteLine("Digite uma senha com as seguintes regras: ");
            string senha = Console.ReadLine();

            // Verificando as condições da senha
            // 1 - A senha deve ter no mínimo 8 caracteres
            if (senha.Length >= 8 && senha.Length <= 20)
            {
                tam = true;
            }

            // 2 - A senha deve conter pelo menos uma letra maiúscula
            foreach (char i in senha)
            {
                if (char.IsUpper(i))
                {
                    c = true;
                }
            }

            // 3 - A senha deve conter pelo menos um número
            foreach (char j in senha)
            {
                if (char.IsDigit(j))
                {
                    n = true;
                }
            }

            // 4 - A senha deve conter pelo menos um caractere especial
            foreach (char i in senha)
            {
                if (charespecial.Contains(i))
                {
                    especial = true;
                }
            }

            // Verificando se a senha atende as regras

            if (c == false || n == false || tam == false || especial == false)
            {
                Console.WriteLine(
                    "\nSenha nao atende as regras.\n Numero: "
                        + n
                        + "\n Maiusculo: "
                        + c
                        + "\n 8 digitos: "
                        + tam
                        + "\n Char Especial: "
                        + especial
                        + ""
                );
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\nSenha Válida.");
                Console.WriteLine("Senha: " + senha);
                Console.WriteLine();
            }
        }
    }
}
