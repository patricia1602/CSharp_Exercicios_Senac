using System;

namespace CSharp_Matriz_Exe5_BuscaEmMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare uma matriz retangular (qualquer tamanho) preenchida com números inteiros. Solicite ao usuário um valor para busca. Verifique se o valor está presente na matriz e, se estiver, imprima a posição (linha e coluna) onde o valor foi encontrado.//
            int[,] matriz = { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };
            int valorBuscado;

            Console.Write("Digite o valor a ser buscado na matriz: ");
            if (int.TryParse(Console.ReadLine(), out valorBuscado))
            {

            }
            bool encontrado = false;
            int linhaEncontrada = -1;
            int colunaEncontrada = -1;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == valorBuscado)
                    {
                        encontrado = true;
                        linhaEncontrada = i;
                        colunaEncontrada = j;
                        break;
                    }
                }
                if (encontrado)
                {
                    break;
                }
            }
            if (encontrado)
            {
                Console.WriteLine("Valor encontrado na posição: Linha " + linhaEncontrada + ", Coluna" + colunaEncontrada);
            }
            else
            {
                Console.WriteLine("Valor não encontrado na matriz.");
            }
        }
    }
}
