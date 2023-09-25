using System;

namespace CSharp_Matriz_Exe2_MatrizIdentidade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie uma matriz identidade de ordem 4x4. Uma matriz identidade é uma matriz quadrada onde os elementos da diagonal principal são 1 e os demais elementos são 0.//
            int[,] matrizIdentidade = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        matrizIdentidade[i, j] = 1;
                    }
                    else
                    {
                        matrizIdentidade[i, j] = 0;
                    }
                    Console.WriteLine(matrizIdentidade[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
