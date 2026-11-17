

string frase = "Sala B204, andar 3";
int qtdDigitos = 0;

for(int i = 0; i <= frase.Length -1; i++)
{
    if (char.IsDigit(frase[i]))
    {
        qtdDigitos++;
    }
}

Console.WriteLine($"Na frase {frase} foram encontrados {qtdDigitos} digitos");