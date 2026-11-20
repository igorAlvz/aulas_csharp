namespace ClassesEConstrutores.Modelos
{
    public class Livro
    {
        public static int TotaLivros = 0;
        public string Titulo {get;}
        public string Autor {get;}
        public int Ano {get;}

        public DateTime DataCadastro {get;}
        public bool Disponivel {get; private set; }// muda mas so por dentro

        private int avaliacao; // campo privado: só a própria classe enxerga
        public int Avalicao // propriedade pública: a porta controlada
        {
            get {return avaliacao; }
            set
            {
                if (value >= 0 && value <= 5)
                {
                    avaliacao = value;
                }
                // FORA DE 0 A 5: NÃO FAZ NADA - O VALOR ANTERIOR É MANTIDO

            }
        }

        public Livro(string titulo, string autor, int ano)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Ano = ano; 
            Disponivel = true;
            DataCadastro = DateTime.Now;


        }

        public void Emprestar() { Disponivel = false; }
        public void Devolver() { Disponivel = true; }


    }
}
