using System;

namespace CSharp_Exe1_BuscaPorUmVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            const int tamanhoDoVetor = 10;
            int[] vetor = new int[tamanhoDoVetor];
            // Preenchendo o vetor com 10 números fornecidos pelo usuário
            for (int i = 0; i < tamanhoDoVetor; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                if (!int.TryParse(Console.ReadLine(), out vetor[i]))
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                    i--; // Decrementa para repetir a entrada para o mesmo índice
                }
            }
            // Solicitando ao usuário um número a ser buscado
            Console.Write("\nDigite um número a ser buscado no vetor: ");
            int numeroBuscado;
            while (!int.TryParse(Console.ReadLine(), out numeroBuscado))
            {
                Console.Write("Por favor, insira um número válido: ");
            }
            // Realizando a busca linear
            int posicao = BuscaLinear(vetor, numeroBuscado);
            // Exibindo o resultado
            if (posicao == -1)
            {
                Console.WriteLine("Número não encontrado no vetor.");
            }
            else
            {
                Console.WriteLine($"Número encontrado na posição {posicao} do vetor.");
            }
        }
        static int BuscaLinear(int[] vetor, int numeroBuscado)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == numeroBuscado)
                {
                    return i;
                }
            }
            return -1; // Retorna -1 caso o número não seja encontrado
        }
    }
}
