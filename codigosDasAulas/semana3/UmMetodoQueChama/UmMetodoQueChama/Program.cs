
static string ClassificarObra(int ano)
{
    string classificacao = "";
    if (ano < 1900)
    {
        classificacao = "Clássico";
    } else if (ano < 200)
    {
        classificacao = "Contemporâneo";
    }
    else
    {
        classificacao = "Moderno";
    }

    return classificacao;
}


static void MostrarResumo(string titulo, int ano)
{
    string categoria = ClassificarObra(ano);
    Console.WriteLine($"{titulo} ({ano}) - {categoria}");
}



MostrarResumo("Capitães de Area", 1937);
MostrarResumo("Iracema", 1865);