static int LerInteiro(string mensagem)
{
    int numero;
    Console.Write(mensagem);
    while(!int.TryParse(Console.ReadLine(), out  numero))
    {
        Console.Write("Valor inválido! " + mensagem);
    }

    return numero;
}


int dias = LerInteiro("Dias de atraso: ");
Console.WriteLine($"Você digitou {dias}");