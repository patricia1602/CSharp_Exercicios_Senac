using System;

namespace CSharp_Matriz_Exe3_TranspostaDeMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare uma matriz retangular (qualquer tamanho) e calcule sua matriz transposta. A matriz transposta é obtida trocando as linhas pelas colunas da matriz original. Imprima a matriz transposta resultante.//
            int[,] matrizOriginal = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] matrizTransposta = new int[matrizOriginal.GetLength(1), matrizOriginal.GetLength(0)];

            for (int i = 0; i < matrizOriginal.GetLength(0); i++)
            {
                for (int j = 0; j < matrizOriginal.GetLength(1); j++)
                {
                    matrizTransposta[j, i] = matrizOriginal[i, j];

                }

            }

            for (int i = 0; i < matrizTransposta.GetLength(0); i++)
            {
                for (int j = 0; j < matrizTransposta.GetLength(1); j++)
                {
                    Console.Write(matrizTransposta[i, j] + " ");
                }

            }

            Console.WriteLine();
        }
    }
}
