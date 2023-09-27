using System;
using System.Linq;

namespace TAD
{
    class Program
    {
        static void Main()
        {
            GerenciadorDeLivros gerenciador = new GerenciadorDeLivros(10);

            while (true)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1- Novo: ");
                Console.WriteLine("2- Listar Livros: ");
                Console.WriteLine("3- Remover Livro: ");
                Console.WriteLine("4- Entrada de Estoque: ");
                Console.WriteLine("5- Saída de estoque: ");
                Console.WriteLine("0- Sair: ");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do livro:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o autor do livro:");
                        string autor = Console.ReadLine();
                        Console.WriteLine("Digite o gênero do livro:");


                        string genero = Console.ReadLine();
                        Livro novoLivro = new Livro(nome, autor, genero);

                        if (gerenciador.Novo(novoLivro))
                        {
                            Console.WriteLine("Livro adicionado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível adicionar o livro. Limite de capacidade atingido.");
                        }

                        break;

                    case 2:
                        Console.WriteLine("Lista de Produtos: ");
                        gerenciador.ListarProdutos();

                        break;

                    case 3:
                        Console.WriteLine("Digite o nome do livro a se removido:");

                        string nomeRemover = Console.ReadLine();
                        if (gerenciador.RemoverProdutoPeloNome(nomeRemover))
                        {
                            Console.WriteLine("Livro removido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado ou não pode ser removido.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Digite o nome do livro para entrada de estoque: ");
                        string nomeEntrada = Console.ReadLine();
                        Console.WriteLine("Digite a quantidade de entrada: ");
                        int quantidadeDeEntrada = int.Parse(Console.ReadLine());

                        if (gerenciador.EntradaDeEstoque(nomeEntrada, quantidadeDeEntrada)
                        )
                        {
                            Console.WriteLine("Entrada de estoque realizada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado ou entrada de estoque não realizada.");
                        }

                        break;

                    case 5:

                        Console.WriteLine("Digite o nome do livro para saída de estoque: ");
                        string nomeSaida = Console.ReadLine();

                        Console.WriteLine("Digite a quantidade de saída: ");

                        int quantidadeSaida = int.Parse(Console.ReadLine());

                        if (gerenciador.SaidaDeEstoque(nomeSaida, quantidadeSaida))
                        {
                            Console.WriteLine("Saída de estoque realizada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado, quantidade insuficiente em estoque ou saída de estoque não realizada.");
                        }
                        break;

                    case 0:
                        return;
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
