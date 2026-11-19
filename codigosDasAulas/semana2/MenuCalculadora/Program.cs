using System.Runtime.CompilerServices;

static int LerNumero(string mensagem)
{
    int numero;
    Console.Write(mensagem);
    while (!int.TryParse(Console.ReadLine(), out numero)) //enquanto NÃO conseguir converter...
    {
        Console.Write("Valor inválido. " + mensagem);
    }

    return numero;
}


static bool EhPar(int numero)
{
    return numero % 2 == 0;
}

static void MostarTabuada(int numero)
{
    for (int i = 1 ; i <= 10; i++)
    {
        Console.WriteLine($"{numero} X {i} = {numero * i}");
    }
}


int opcao;

do
{
    Console.WriteLine();
    Console.WriteLine("""
Menu
1 - Verificar se um número é par.
2 - Mostrar tabuada.
0 - Sair
""");
    Console.Write("Escolha: ");
    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        opcao = -1; // texto inválido: vira uma opção que cai no default
    }

    switch (opcao)
    {
        case 1:
            int n = LerNumero("Número: ");
            if (EhPar(n))
            {
                Console.WriteLine("É par");
            }
            else
            {
                Console.WriteLine("É ímpar");
            }
            break;
        case 2:
            MostarTabuada(LerNumero("Tabuada de: "));
            break;
        case 0:
            Console.WriteLine("Até logo!");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}
while(opcao!= 0);