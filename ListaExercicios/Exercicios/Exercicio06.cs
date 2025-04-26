namespace Exercicios
{
    public class Exercicio06
    {
        public static void Executar()
        {
            Console.WriteLine("Executando exercício 06");

            //Definindo qtd de produtos.
            Console.WriteLine("Qual a quantidade de produtos que deseja cadastrar: ");
            int tamanho = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[tamanho];//Instanciando 

            // Loop para receber dados.
            for (int i = 0; i < tamanho; i++)
            {
                produtos[i] = new Produto();

                Console.WriteLine($"Produto [{i + 1}]: ");

                Console.WriteLine("Nome: ");
                produtos[i].nome = Console.ReadLine();

                Console.WriteLine("Preco: ");
                produtos[i].preco = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Quantidade: ");
                produtos[i].qtd = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
            }

            //Exibir produtos.
            Console.WriteLine("Produtos Cadastrados: ");
            foreach (Produto p in produtos)
            {
                Console.WriteLine(
                    $"Nome: {p.nome}, Preco: {p.preco}, Quantidade: {p.qtd}.\nValor em estoque: {p.ValorTotal()}"
                );
            }
        }
    }

    public class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public int qtd { get; set; }

        public double ValorTotal()
        {
            return preco * qtd;
        }
    }
}
