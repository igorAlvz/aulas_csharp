using System;
using System.Collections.Generic;
using System.Text;

namespace AulaClasses.Modelo
{
    public class Livro
    {
        public string Titulo {get;}
        public string Autor {get;}

        public int Ano {get;}

        public static int TotalLivros = 0;
        
        public DateTime DataCadastro {get;} = DateTime.Now;

        public Livro(string titulo, string autor, int ano)
        {
            this.Titulo =  titulo;
            this.Autor = autor;
            this.Ano = ano;
            this.DataCadastro = DateTime.Now;
        }

         public Livro(string titulo, int ano)
        {
            this.Titulo =  titulo;
            this.Autor = "Autor desconhecido";
            this.Ano = ano;
            this.DataCadastro = DateTime.Now;
            TotalLivros++;
        }

        public Livro()
        {
            
        }

        public override string ToString()
        {
            return $"Autor: {Autor} Livro: {Titulo} Ano: {Ano}";
        }

    }
}
