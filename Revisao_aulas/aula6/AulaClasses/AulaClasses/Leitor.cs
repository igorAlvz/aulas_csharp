namespace AulaClasses
{
    public class Leitor
    {
        public string Nome = "";
        public int LivrosEmprestado;

        public void PegarLivro()
        {
            LivrosEmprestado++;
            Console.WriteLine($"{Nome} agora tem {LivrosEmprestado} livro(s) emprestado(s).");
        }
    }
}
