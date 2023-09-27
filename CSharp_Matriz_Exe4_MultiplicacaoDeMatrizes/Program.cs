using System;

namespace CSharp_Matriz_Exe4_MultiplicacaoDeMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare duas matrizes, uma de ordem 2x3 e outra de ordem 3x2. Preencha essas matrizes com valores inteiros de sua escolha. Realize a multiplicação dessas matrizes e imprima a matriz resultante.//

            int[,] matriz1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] matriz2 = { { 7, 8 }, { 9, 10 }, { 11, 12 } };
            int[,] resultado = new int[matriz1.GetLength(0), matriz2.GetLength(1)];

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    for (int k = 0; k < matriz1.GetLength(1); k++)
                    {
                        resultado[i, j] += matriz1[i, k] * matriz2[k, j];

                    }

                    Console.Write(resultado[i, j] + " ");
                }

            }

            Console.WriteLine();
        }
    }
}
