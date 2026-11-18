
static double CalcularDesconto(double valor, int qtd)
{
    if(qtd >= 3)
    {
        return valor * 10 / 100;  }

    return 0;
}

static void MostrarRecibo(string cliente,double valor, int qtd)
{
    Console.WriteLine($"Nome: {cliente} | valor total: R$ {valor} | quantidade: {qtd}");
    Console.WriteLine($"Valor do desconto: R$ {CalcularDesconto(valor, qtd):F2}");
}


MostrarRecibo("João", 1500, 5);