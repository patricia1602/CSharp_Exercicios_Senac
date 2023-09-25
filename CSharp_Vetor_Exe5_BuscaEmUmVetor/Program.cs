using System;

namespace CSharp_Exe5_BuscaEmUmVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare um vetor de strings com nomes predefinidos. Solicite ao usuário um nome para busca. Verifique se o nome está presente no vetor e exiba uma mensagem informando se o nome foi encontrado ou não.//
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
