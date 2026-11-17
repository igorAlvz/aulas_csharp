
static string ClassficarNota(double nota)
{
    string classificacao = "";
    if(nota >= 9 && nota <= 10) classificacao = "Excelente";
    else if (nota >= 7 && nota < 9 ) classificacao = "Bom";
    else if (nota >= 5 && nota < 7) classificacao = "Regular";
    else if (nota < 5) classificacao = "Insuficiente";
    else
    {
        return "ERRO: A nota de estar no intervalo de 0 a 10";
    }

    return classificacao;
}


Console.WriteLine(ClassficarNota(56.9));