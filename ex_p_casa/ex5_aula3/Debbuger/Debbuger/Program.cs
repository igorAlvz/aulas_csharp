using System.Globalization;

Console.WriteLine("Vamos calcular média.");
Console.Write("Digite a primeira nota: ");
string n1Entrada = Console.ReadLine();

Console.Write("Digite a segunda: ");
string n2Entrada = Console.ReadLine();



int media = 0;
if(!int.TryParse(n1Entrada, out int n1) || !int.TryParse(n2Entrada, out int n2))
{
    Console.WriteLine("Digite somente números inteiros.");
    return;
}
else
{
   media = (n1 + n2) / 2;
}

Console.WriteLine($"Média {media:F2}");

