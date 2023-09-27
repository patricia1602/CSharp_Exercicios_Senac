using System;
using System.Collections.Generic;
using System.IO;

namespace Csharp_Arquivos_Exe1_CriadorDeListaDeTarefas
{
    class Program
    {
        private const string ArquivoTarefas = "tarefas.txt";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1.Adicionar tarefa: ");
                Console.WriteLine("2.Mostrar tarefa: ");
                Console.WriteLine("3.Sair. ");
                Console.WriteLine("Escolha um opção: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AdicionarTarefa();
                        break;
                    case "2":
                        MostrarTarefas();
                        break;
                    case "3": return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }
            }

        }

        private static void AdicionarTarefa()
        {
            Console.Write("Digite a tarefa: ");
            string tarefa = Console.ReadLine();
            File.AppendAllText(ArquivoTarefas, tarefa + Environment.NewLine);
        }

        private static void MostrarTarefas()
        {
            if (!File.Exists(ArquivoTarefas))
            {
                Console.WriteLine("Ainda não há taferas adicionadas.");
                return;
            }
            List<string> tarefas = new List<string>(File.ReadAllLines(ArquivoTarefas));
            Console.WriteLine("\nTarefas: ");
            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{tarefas[i]}");

            }
            Console.WriteLine();
        }

    }
}
