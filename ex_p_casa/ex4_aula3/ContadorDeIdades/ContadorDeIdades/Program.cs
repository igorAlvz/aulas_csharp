int maiores = 0;
int menores = 0;

while (true)
{
    Console.Write("Digite uma idade (ou -1 para sair): ");
    string entrada = Console.ReadLine();

    if (entrada == "-1") break;
    else if (!int.TryParse(entrada, out int idade))
    {
        Console.WriteLine("Idade inválida. Digite um número inteiro.");
        continue;

    }
    else if (idade < 0)
    {
        Console.WriteLine("Idade inválida. Digite um número inteiro positivo.");
        continue;
    }

    else if (idade >= 18) maiores++;
    else menores++;
    
}

Console.WriteLine($"Total de pessoas maiores de idade {maiores}");
Console.WriteLine($"Total de pessoas menores de idade {menores}");
