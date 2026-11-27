using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Modelos
{
    public abstract class ItemAcervo
    {
        private int ano;

        public int Ano { get { return ano; }
            set
            {
                if(value > 0)
                {
                    this.ano = value;

                }
            }
        }
        public string Titulo { get; } 

        public string Descrever()
        {
            return $"{Titulo} ({Ano})";
        }

        public ItemAcervo(string titulo)
        {
            this.Titulo = titulo;
        }

        public virtual double CalcularMulta(int diasAtraso)
        {
            return diasAtraso * 1.00;
        }

        public abstract int PrazoEmprestimoDias();
    }
}
