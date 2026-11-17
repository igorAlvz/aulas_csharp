
static double CalcularDesconto(double valor, int qtd)
{
    double desconto = 0;
    if(qtd >= 3)
    {
        desconto = valor * 10 / 100;
        return desconto;
    }

    return desconto;
}


Console.WriteLine($"Desconto: R$ {CalcularDesconto(100,3):F2}");