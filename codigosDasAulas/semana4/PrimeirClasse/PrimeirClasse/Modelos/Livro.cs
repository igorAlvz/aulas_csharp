namespace Biblioteca.Modelos
{
    internal class Livro
    {
        public string Titulo {get;}
        public string Autor {get;}
        public int Ano {get;}
        public DateTime DataCadastro {get;}

        // construtor 1 : recebe tudo 
        public Livro(string titulo, string autor, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano; 
            DataCadastro = DateTime.Now; // registra o instante em que o objeto foi criado

        }

        // construtor 2: para livros sem autor conhecido
        public Livro(string titulo, int ano)
        {
            Titulo = titulo;
            Autor = "Desconhecido";
            Ano = ano;
            DataCadastro = DateTime.Now;

        }

        public override string ToString()
        {
            return $"{Titulo} ({Ano}), de {Autor}";
        }
    }
}
