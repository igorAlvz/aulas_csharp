namespace ModificadoresDeAcesso
{
    public class Leitor
    {
        private const int LimiteEmprestimo = 3; // detalhe interno: ninguém de fora precisa ver
        private string email = "";  // o dado guardado, escondido
        public string Nome {get;} //Construtor define
        public int LivrosEmprestados{get; private set;} //todos leem, so a classe altera

        public Leitor(string nome)
        {
            Nome = nome;
        }

        public string Email
        {
            get {return email;}
            set
            {
                if (value.Contains('@')) // a porta só abre para valores válidos
                {
                    email = value;

                }
            }

        }
        public bool PegarLivro()
        {
            if(LivrosEmprestados >= LimiteEmprestimo)
            {
                return false;

            }
            LivrosEmprestados++;
            return true;
        }

        public void DevolverLivro()
        {
            if (LivrosEmprestados > 0) // nao deixa ficar negativo
            {
                LivrosEmprestados--;
            }
        }
    }


}
