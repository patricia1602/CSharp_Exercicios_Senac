using System;

namespace CSharp_Vetor_Exe4_ContagemDeParesEImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            //Um vetor com números predefinidos
            int[] valores = { 2, 3, 4, 5, 6, 7, 8, 9 };
            int pares = 0;
            int impares = 0;

            //Um loop percorre para saber se os números são divisivéis por 2
            foreach (int valor in valores)
            {
                if (valor % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine("Pares" + pares);
            Console.WriteLine("Ímpares" + impares);
        }
    }
}
