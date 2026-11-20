
class Program
{
    static void MostrarLinha() // versão 1: sem parâmetros
{
    Console.WriteLine(new string('-', 20));

}

static void MostrarLinha(int tamanho)
{
    Console.WriteLine(new string ('-', tamanho));

}
static void MostrarLinha(int tamanho, char simbolo)
{
    Console.WriteLine(new string(simbolo, tamanho));
}

    static void Main()
{
        MostrarLinha();
        MostrarLinha(10);
        MostrarLinha(10,'*');

}

}


