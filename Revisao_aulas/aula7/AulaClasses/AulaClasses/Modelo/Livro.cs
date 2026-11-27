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


        private int avaliacao;

        public int Avaliacao
        {
            get {return avaliacao;}
            set
            {
                if (value >=0 && value <= 5)
                {
                    avaliacao = value;
                }
            }
        }

        public bool Disponivel { get; private set; }

        public void Emprestar() { Disponivel = false; }
        public void Devolver() { Disponivel = true; }

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
            return $"Autor: {Autor} Livro: {Titulo} Ano: {Ano} Com avaliação = {Avaliacao}";
        }

    }
}
