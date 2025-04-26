using System.Net;

namespace Exercicios
{
    public class Exercicio10
    {
        public static void Executar()
        {
            Console.WriteLine("Executando exercício 10");

            //Definir parametros da Lista.

            List<Tarefa> tarefas = new List<Tarefa>();
            string opcao;

            do
            {
                Console.WriteLine("\nMenu: ");
                Console.WriteLine("1 - Adicionar Tarefa");
                Console.WriteLine("2 - Listar Tarefas");
                Console.WriteLine("3 - Marcar Tarefa como concluída");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Descrição da tarefa: ");
                        string descricao = Console.ReadLine();
                        tarefas.Add(new Tarefa { descricao = descricao });
                        break;
                    case "2":
                        Console.WriteLine("Tarefas: ");

                        foreach (var tarefa in tarefas)
                        {
                            string exibirStatus = tarefa.status ? "Concluida" : "Pendente";
                            Console.WriteLine($"{exibirStatus} - {tarefa.descricao}");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Numero da tarefa: ");
                        int n = int.Parse(Console.ReadLine()) - 1;

                        if (n >= 0 && n < tarefas.Count)
                        {
                            for (int i = 0; i < tarefas.Count; i++)
                            {
                                if (i == n)
                                {
                                    tarefas[i].AlterarStatus();
                                }
                            }
                        }
                        break;

                    case "0":
                        Console.WriteLine("Encerrando programa.");
                        break;

                    default:
                        Console.WriteLine("Opção Inválida.");
                        break;
                }
            } while (opcao != "0");
        }
    }

    class Tarefa
    {
        public string descricao { get; set; }
        public bool status { get; set; }

        public void AlterarStatus()
        {
            status = true;
        }
    }
}
