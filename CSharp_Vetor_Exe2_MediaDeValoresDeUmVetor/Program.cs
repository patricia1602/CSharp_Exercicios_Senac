using System;

namespace CSharp_Vetor_Exe2_MediaDeValoresDeUmVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Um vetor(5) de inteiros com valores predefinidos(total de 150)
            int[] valores = { 10, 20, 30, 40, 50 };

            double media = 0;

            //foreach criou o elemento valor e com o operador in percorrer valores
            foreach (int vetor in valores)
            {
                media += vetor;
            }
            //A média é 5 dividido pelos valores que é 150
            media /= valores.Length;

            //
            Console.WriteLine("média" + media);
        }
    }
}
