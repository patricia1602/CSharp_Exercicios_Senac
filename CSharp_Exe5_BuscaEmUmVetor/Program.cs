using System;

namespace CSharp_Exe5_BuscaEmUmVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Patrícia", "Josenildo", "Leonardo", "Manuela" };
            string nomeBuscado = "Manuela";
            bool encontrado = false;

            foreach (string nome in nomes)
            {
                if (nome == nomeBuscado)
                {
                    encontrado = true;
                    break;

                }
            }
            if (encontrado)
            {
                Console.WriteLine("Nome encontrado!");
            }
            else
            {
                Console.WriteLine("Nome não encontrado.");
            }
        }
    }
}
