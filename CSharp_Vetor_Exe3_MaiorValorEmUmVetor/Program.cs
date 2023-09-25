using System;

namespace CSharp_Vetor_Exe3_MaiorValorEmUmVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare um vetor de inteiros com valores predefinidos. Encontre e imprima o maior valor presente no vetor.//
            //Um vetor de inteiros chamado numeros predefinidos
            int[] numeros = { 10, 5, 15, 20 };
            int maior = numeros[0];//Neste caso o maior iniciado com 10

            //Um loop for é feito para saber quem é o maior comparando entre os números restante no vetor 
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }
            Console.WriteLine("Maior" + maior);
        }
    }
}
