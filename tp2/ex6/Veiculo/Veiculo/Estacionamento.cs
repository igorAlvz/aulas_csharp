using System;
using System.Collections.Generic;
using System.Text;

namespace Estacionamento
{
    public class Veiculo
    {
        public string Placa;
        public DateTime HoraEntrada;
        public string Tipo;

        public Veiculo(string placa, DateTime horaEntrada, string tipo)
        {
            this.Placa = placa;
            this.HoraEntrada = horaEntrada;
            this.Tipo = tipo;
        }

        public Veiculo(string placa, string tipo)
        {
            this.Placa = placa;
            this.Tipo = tipo;
            this.HoraEntrada = DateTime.Now;
        }
    }
}
