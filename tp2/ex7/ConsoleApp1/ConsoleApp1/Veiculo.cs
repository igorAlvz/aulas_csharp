namespace ConsoleApp1
{
    public class Veiculo
    {
        public string Placa;
        public string Tipo;
        public DateTime HoraEntrada;

        public DateTime HoraRegistro;


        public Veiculo(string placa, string tipo, DateTime horaEntrada)
        {
            this.Placa = placa;
            this.Tipo = tipo;
            this.HoraEntrada = horaEntrada;
            this.HoraRegistro = DateTime.Now;
            
        }

        public Veiculo(string placa, string tipo)
        {
            this.Placa = placa;
            this.Tipo = tipo;
            this.HoraEntrada = DateTime.Now;
            this.HoraRegistro = DateTime.Now;

        }

        public override string  ToString()
        {
            return $"Placa: {Placa} - Tipo: {Tipo} - Entrada: {HoraEntrada} - Registro: {HoraRegistro}";
        }

    }
}
