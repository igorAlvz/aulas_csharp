namespace ModificadoresDeAcesso
{
    public class Livro
    {

        private int avaliacao; // campo privado: só a própria classe enxerga
        public int Avaliacao // propriedade pública: a porta controlada
        {
            get{return avaliacao;}
            set
            {
                if(value >= 0 && value <= 5)
                {
                    avaliacao = value;
                }
                // fora de 0 a 5: nao faz nada - o valor anterior é mantido
            }
        }
    }
}
