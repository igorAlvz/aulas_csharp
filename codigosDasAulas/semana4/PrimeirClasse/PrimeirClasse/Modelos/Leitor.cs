namespace PrimeirClasse.Modelos
{
    public class Leitor
    {

        public static int TotalCadastrados; // Static: um só valor, da classe inteira
        public string Nome {get;} // instância: um valor para cada  objeto

        public Leitor(string nome)
        {
            Nome = nome;
            TotalCadastrados++;
        }


        // static: não depende de nenhum leitor específico, só do texto recebido
        public static bool NomeValido(string nome)
        {
            return nome.Trim().Length >= 2;
        }

    }
}
