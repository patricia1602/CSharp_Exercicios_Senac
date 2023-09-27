namespace TAD
{
    public class Livro
    {
        private string nome;
        private string autor;
        private string genero;
        private int quantidadeEmEstoque;
        private int quantidadeVendida;
        internal readonly int Lenght;

        //construtor 
        public Livro(string nome, string autor, string genero, int quantidadeEmEstoque, int quantidadeVendida)
        {
            this.nome = nome;
            this.autor = autor;
            this.genero = genero;
            this.quantidadeEmEstoque = 0;
            this.quantidadeVendida = 0;
        }

        public Livro(string nome, string autor, string genero)
        {
            this.nome = nome;
            this.autor = autor;
            this.genero = genero;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getAutor()
        {
            return autor;
        }

        public void setAutor(string autor)
        {
            this.autor = autor;
        }

        public string getGenero()
        {
            return genero;
        }

        public void setGenero(string genero)
        {
            this.genero = genero;
        }

        public int GetQuantidadeEmEstoque()
        {
            return quantidadeEmEstoque;
        }

        public void setQuantidadeEmEstoque(int quantidadeEmEstoque)
        {
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }

        public int getQuantidadeVendida()
        {
            return quantidadeVendida;
        }

        public void setQuantidadeVendida(int quantidadeVendida)
        {
            this.quantidadeVendida = quantidadeVendida;
        }

        public override string ToString()
        {
            return ($"{nome} {autor}, Gênero {genero}");
        }
    }
}