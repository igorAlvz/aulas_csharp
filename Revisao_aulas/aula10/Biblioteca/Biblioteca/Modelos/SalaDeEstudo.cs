using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Modelos
{
    public class SalaDeEstudo : IRelatavel
    {
        public int Numero { get; set; }
        public int Capacidade {get; set;}

        public SalaDeEstudo(int numero, int capacidade)
        {
            this.Numero = numero;
            this.Capacidade = capacidade;
        }
        public string GerarResumo()
        {
            return $"Sala {Numero}: até {Capacidade} pessoas"; 
        }
    }
}
