using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Modelos
{
    public class Livro : ItemAcervo 
    {
        public string Autor { get; set; } = string.Empty;

        public void MostrarAutor()
        {
            Console.WriteLine($"{Titulo} foi escrito por {Autor}");
        }

        public Livro(string titulo, string autor) : base (titulo)
        {
            this.Autor = autor;
        }

        public override double CalcularMulta(int diasAtraso)
        {
            return diasAtraso * 3;
        }
    }
}
