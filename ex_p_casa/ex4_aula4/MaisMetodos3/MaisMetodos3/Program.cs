static bool SalaValida(string codigo)
{
    if (codigo.Length < 4)
    {
        return false;
    }

    for (int i = 0; i < codigo.Length; i++)
    {
        if (i == 0)
        {
            if (!char.IsLetter(codigo[i]) && char.IsUpper(codigo[i])) return false;
        }

        else if (!char.IsDigit(codigo[i])) return false;
    }

    return true;

}

static bool SalaValida(string[] codigos)
{
    if (codigo.Length < 4)
    {
        return false;
    }

    for (int i = 0; i < codigo.Length; i++)
    {
        if (i == 0)
        {
            if (!char.IsLetter(codigo[i]) && char.IsUpper(codigo[i])) return false;
        }

        else if (!char.IsDigit(codigo[i])) return false;
    }

    return true;

}


Console.WriteLine($"A sala B200 é válida? {SalaValida("B200")}");
Console.WriteLine($"A sala B2K0 é válida? {SalaValida("B2K0")}");
Console.WriteLine($"A sala b2k0 é válida? {SalaValida("b2k0")}");