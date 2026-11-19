// Métodos ficam no FINAL do Program.cs, depois do código principal.

static bool EhPar(int numero) // recebe int devolve um bool
{
    return numero % 2 == 0; // resto 0 na divisão por 2 = par

}

static void MostrarTabuada(int numero) // recebe um int, não devolve nada (void)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}


//Uso, no código principal

if (EhPar(8))
{
    Console.WriteLine("É par");
}

MostrarTabuada(3);