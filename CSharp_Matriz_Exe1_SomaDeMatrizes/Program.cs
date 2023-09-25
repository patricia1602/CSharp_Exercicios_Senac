using System;

namespace CSharp_Matriz_Exe1_SomaDeMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
         //Duas matrizes quadradas de ordem 3x3. Preencha essas matrizes com valores inteiros de sua escolha. Em seguida, crie uma terceira matriz que armazene a soma dos elementos correspondentes das duas matrizes anteriores.//
            int[,] matriz1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matriz2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            int[,] resultado = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultado[i, j] = matriz1[i, j] + matriz2[i, j];
                    Console.Write(resultado[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
