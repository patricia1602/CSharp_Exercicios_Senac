using System;
using System.IO;

namespace CSharp_Arquivos_Exe2_ContadorDePalavras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do arquivo: ");
            string nomeDoArquivo = Console.ReadLine();

            //verificar se arquivo existe
            if (!File.Exists(nomeDoArquivo))
            {
                Console.WriteLine("Arquivo não encontrado!");
                return;
            }

            //Ler o conteúdo do arquivo
            string conteudo = File.ReadAllText(nomeDoArquivo);

            // Dividir o conteúdo em palavras usando espaços como delimitadores
            string[] palavras = conteudo.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Exibir o número de palavras
            Console.WriteLine($"O arquivo contém {palavras.Length} palavras.");

        }
    }
}
