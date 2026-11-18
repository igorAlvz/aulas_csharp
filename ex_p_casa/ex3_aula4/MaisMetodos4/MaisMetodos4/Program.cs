static int LerInteiro(string mensagem)
{
    int numero;
    Console.Write(mensagem);
    while(!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Valor inválido. " + mensagem);
    }
    return numero;
}

static double CalcularDesconto(double valor, int qtd)
{
    if (qtd >= 3) return valor * 10 / 100;
    else return 0;

}

static void MostrarRecibo(string nome, double valor, int qtd)
{
    Console.WriteLine($"Recibo Nome: {nome} | valor: R$ {valor:F2} | quantidade: {qtd}");
    Console.WriteLine($"Desconto {CalcularDesconto(valor, qtd):F2}");
}


MostrarRecibo("João", 1700, LerInteiro("Digite a quantidade: "));