namespace Biblioteca.Modelos
{
    public class Revista : ItemAcervo
    {
        public int Edicao { get;}
        public Revista(string titulo, int edicao) : base(titulo)
        {
            this.Edicao = edicao;
        }

        public override double CalcularMulta(int diasAtraso)
        {
            return diasAtraso * 2.50;
        }
    }
}
