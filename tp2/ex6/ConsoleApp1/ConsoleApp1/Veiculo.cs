namespace ConsoleApp1
{
    public class Veiculo
    {
        public string Placa;
        public string Tipo;
        public DateTime HoraEntrada;

        public Veiculo(string placa, string  tipo, DateTime horaEntrada)
        {
            this.Placa = placa;
            this.Tipo = tipo;
            this.HoraEntrada = horaEntrada;
        }

        public Veiculo(string placa, string tipo)
        {
            this.Placa = placa;
            this.Tipo = tipo;
            this.HoraEntrada = DateTime.Now;
        }
       
    }
}
