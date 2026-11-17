
string entrada;
int maiores = 0;
int menores = 0;
do
{
    Console.WriteLine("Digite uma idade ou -1 para sair:");
    entrada = Console.ReadLine();

    if (!int.TryParse(entrada, out int idade))
    {
        Console.WriteLine("Idade inválida. Por favor, digite um número inteiro.");
        continue;

    }
    else if (idade == -1)
    {
        Console.WriteLine("Encerrando o programa.");
        continue;
    }
    else if (idade < 0)
    {
        Console.WriteLine("Idade não pode ser negativa.");
        continue;
    }
    else if (idade >= 18) maiores++;
    else menores++;

} while (entrada != "-1");


Console.WriteLine($"Total de maiores de idade {maiores}");
Console.WriteLine($"Total de menores de idade {menores}");