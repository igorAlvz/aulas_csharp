namespace AulaClasses
{
    public class Leitor
    {
        public static int TotalCadastrados;
        public string Nome  {get;}

        public int LivrosEmprestado {get; set;}

        public Leitor(string nome, int livrosEmprestados)
        {
            this.Nome = nome;
            this.LivrosEmprestado = livrosEmprestados;
            TotalCadastrados++;
        }

        public static bool NomeValido(string nome)
        {
            return nome.Trim().Length >= 2;
        }
    }
}
