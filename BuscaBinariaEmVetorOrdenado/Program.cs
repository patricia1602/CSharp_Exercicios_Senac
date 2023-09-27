using System;

namespace BuscaBinariaEmVetorOrdenado
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
                while (!int.TryParse(Console.ReadLine(), out vetor[i]))
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                    Console.Write($"Digite o {i + 1}º número novamente: ");
                }
            }
            // Ordenando o vetor
            Console.WriteLine("Ordenando os números inseridos...");
            Array.Sort(vetor);
            // Solicitando ao usuário um número a ser buscado
            Console.Write("\nDigite um número a ser buscado no vetor: ");
            int numeroBuscado;
            while (!int.TryParse(Console.ReadLine(), out numeroBuscado))
            {
                Console.Write("Por favor, insira um número válido: ");
            }
            // Realizando a busca binária
            int posicao = BuscaBinaria(vetor, numeroBuscado);
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
        static int BuscaBinaria(int[] vetor, int numeroBuscado)
        {
            int esquerda = 0;
            int direita = vetor.Length - 1;
            while (esquerda <= direita)
            {
                int meio = (esquerda + direita) / 2;
                if (vetor[meio] == numeroBuscado)
                {
                    return meio;
                }
                else if (vetor[meio] < numeroBuscado)
                {
                    esquerda = meio + 1;
                }
                else
                {
                    direita = meio - 1;
                }
            }
            return -1; // Retorna -1 caso o número não seja encontrado
        }
    }
}
