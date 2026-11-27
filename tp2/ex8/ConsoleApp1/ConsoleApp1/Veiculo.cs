namespace ConsoleApp1
{
    public class Veiculo
    {
        public string Placa;
        public string Tipo;
        public DateTime HoraEntrada;
        public DateTime RegistroTicket;

        private decimal vlrPago; 
        public decimal VlrPago {
            get {return vlrPago;}
            set
            {
                if (value >= 0)
                {
                    vlrPago = value;
                }
            }
        }

        public Veiculo(string placa, string tipo, DateTime horaEntrada)
        {
            this.Placa = placa;
            this.Tipo = tipo;
            this.HoraEntrada = horaEntrada;
            this.RegistroTicket = DateTime.Now;
        }

        public Veiculo(string placa, string tipo)
        {
            this.Placa = placa;
            this.Tipo = tipo;
            this.HoraEntrada = DateTime.Now;
            this.RegistroTicket = DateTime.Now;
            

        }


        public override string ToString()
        {
            return $"Placa: {Placa} - Tipo: {Tipo} - Entrada: {HoraEntrada} - Registro: {RegistroTicket} - Valor Pago: R$ {VlrPago}";
        }
    }
}
