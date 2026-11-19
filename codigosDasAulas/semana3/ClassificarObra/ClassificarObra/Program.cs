static string ClassificarObra(int ano) { 

    string classificacao = "";

    if (ano < 1900)
    {
        classificacao = "Clássico";
    } 
    else if (ano < 2000)
    {
        classificacao = "Contemporâneo";
    }
    else
    {
        classificacao = "Moderno";
    }

    return classificacao;
}


Console.WriteLine(ClassificarObra(1850));
Console.WriteLine(ClassificarObra(2000));
Console.WriteLine(ClassificarObra(1980));