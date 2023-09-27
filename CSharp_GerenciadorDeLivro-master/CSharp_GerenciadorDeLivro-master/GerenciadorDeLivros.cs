using System;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace TAD
{
    public class GerenciadorDeLivros
    {
        private Livro[] livros;
        private int count;

        public GerenciadorDeLivros(int capacidade)
        {
            livros = new Livro[capacidade];
            count = 0;
        }

        public bool Novo(Livro livro)
        {
            if (count < livros.Length)
            {
                livros[count] = livro;
                count++;
                return true;
            }
            return false;
        }


        public void ListarProdutos()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(livros[i].ToString());

            }
        }

        public Livro LocalizarPeloNome(string nome)
        {
            for (int i = 0; i < count; i++)
            {
                if (livros[i].getNome() == nome) return livros[i];
            }
            return null;
        }

        public bool RemoverProdutoPeloNome(string nome)
        {
            for (int i = 0; i < count; i++)
            {
                if (livros[i].getNome() == nome)
                {
                    for (int j = i; j < count -1; j++)
                    {
                        livros[j] = livros[j + 1];
                    }
                    livros[count - 1] = null;
                    count--;
                    return true;
                }
            }
            return false;
        }

        public bool EntradaDeEstoque(string nome, int quantidade)
        {
            Livro livro = LocalizarPeloNome(nome);

            if (livro != null)
            {
                livro.setQuantidadeEmEstoque(livro.GetQuantidadeEmEstoque() + quantidade);
                return true;
            }
            return false;
        }

        public bool SaidaDeEstoque(string nome, int quantidade)
        {
            Livro livro = LocalizarPeloNome(nome);


                if(livro != null && livro.GetQuantidadeEmEstoque() >= quantidade)
            {
                livro.setQuantidadeEmEstoque(livro.GetQuantidadeEmEstoque() - quantidade);
                livro.setQuantidadeVendida(livro.getQuantidadeVendida() + quantidade);
                return true;
            }
            return false;

        }
    }
}
    
