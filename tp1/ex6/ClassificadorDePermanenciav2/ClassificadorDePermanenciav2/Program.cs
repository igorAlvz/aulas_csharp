int veiculosRC = 0;
int veiculoRP = 0;
int veiculoRD = 0;

Console.WriteLine("Estacionamento");


while (true)
{
    Console.Write("Permanência (em minutos) -1 pra sair: ");
    string entradaMin = Console.ReadLine();

    if (!int.TryParse(entradaMin, out int totMin))
    {
        Console.WriteLine("Valor invalido - Digite Somente números inteiros");
    }
    else if (totMin == -1)
    {
        break;
    }
    else if (totMin <= 0)
    {
        Console.WriteLine("Valor inválido.");
    }
    else if (totMin <= 120)
    {
        Console.WriteLine("Rotativa curta.");
        veiculosRC++;
    }
    else if (totMin <= 240)
    {
        Console.WriteLine("Rotativa padrão");
        veiculoRP++;
    }
    else
    {
        Console.WriteLine("Rotativa Diária");
        veiculoRD++;
    }
}

Console.WriteLine($"""

    ==== Relatório ====
    Total de Veículos: {veiculosRC + veiculoRP + veiculoRD}
    Rotativa Curta = {veiculosRC}
    Rotativa Padrão = {veiculoRP}
    Rotativa Diária = {veiculoRD}
    
    ==================
    """);

Console.WriteLine("ATÉ LOGO!");