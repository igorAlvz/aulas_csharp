namespace Biblioteca.Modelos
{
    public class Exemplar
    {
        public string Titulo {get;}
        public DateTime DataAquisicao {get;}  //informada: o dia em que qa biblioteca comprou o livro
        public DateTime DataCadastro {get;} // do sistema: o instante em que o objeto foi criado

        public Exemplar(string titulo, DateTime dataAquisicao)
        {
            Titulo = titulo;
            DataAquisicao = dataAquisicao; // vem de fora, pelo parâmetro
            DataCadastro = DateTime.Now; //ninguém informa: o construtor registra sozinho
        }

        public override string ToString()
        {
            return $"{Titulo} | adquirido em {DataAquisicao:dd/MM/yyyy} | cadastrado em {DataCadastro:dd/MM/yyyy HH:mm:ss}";
        }
        
    }
}
