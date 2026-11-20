static void MostrarLirvro(string titulo, string autor, int ano)
{
    Console.WriteLine($"Título: {titulo}");
    Console.WriteLine($"Autor: {autor}");
    Console.WriteLine($"Ano: {ano} ({ClassificarObra(ano)})");

}

static string ClassificarObra(int ano)
{
    if (ano < 1900)
    {
        return "Clássico";
    }
    else if (ano < 2000)
    {
        return "Moderno";
    }
    else
    {
        return "Contemporâneo";
    }
}

Console.Write("Digite o livro (titulo;autor;ano): ");
string? linha = Console.ReadLine();

if (string.IsNullOrWhiteSpace(linha))
{
    Console.WriteLine("ERRO: Nenhuma informação foi digitada");
}
else
{
    string[] partes = linha.Split(';');
    if (partes.Length != 3)
    {
        Console.WriteLine($"ERRO: esperava 3 informações separadas por ';' mas recebi {partes.Length}.");

    }
    else if(!int.TryParse(partes[2], out int ano))
    {
        Console.WriteLine($"Erro: '{partes[2]}' não é um ano válido.");
    }

    else
    {
        MostrarLirvro(partes[0].Trim(), partes[1].Trim(), ano);
    }
}