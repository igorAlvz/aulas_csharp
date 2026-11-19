static double CalcularMulta(int diasDeAtraso, double valorPordia)
{
    if (diasDeAtraso < 0)
    {
        return 0; // sem atraso (ou valor inválido)
    }

    return diasDeAtraso * valorPordia;
}

Console.WriteLine($"Multa: {CalcularMulta(4, 1.50):F2}"); // multa: 6,00
Console.WriteLine($"Multa: {CalcularMulta(0, 1.50):F2}"); // multa: 0,00
Console.WriteLine($"Multa: {CalcularMulta(-2, 1.50):F2}"); // multa: 0,00
