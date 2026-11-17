Console.Write("Digite sua idade: ");
string entrada = Console.ReadLine();

if(!int.TryParse(entrada,out int idade ) || idade < 0 )
{
    Console.WriteLine("Digite um valor válido.");
}
else
{
    if(idade > 0 && idade <= 12)
    {
        Console.WriteLine("Criança");
    } else if(idade <= 17)
    {
        Console.WriteLine("Adolescente");
    } else if(idade <= 59)
    {
        Console.WriteLine("Adulto");
    }
    else
    {
        Console.WriteLine("Idoso");
    }
}

Console.Write("Digite a temperatura em Celsius: ");
string entradaTemp = Console.ReadLine();

if (!double.TryParse(entradaTemp, out double temperatura))
{
    Console.WriteLine("Digite um valor válido.");
}
else
{
    if (temperatura < 15)
    {
        Console.WriteLine("Frio");
    } else if(temperatura <= 28)
    {
        Console.WriteLine("Agradável");
    } else
    {
        Console.WriteLine("Quente");
    }
}

Console.Write("Digite o número 1: ");
if(!int.TryParse(Console.ReadLine(), out int num1))
{
    Console.WriteLine("Número inválido.");
    return;
}

Console.Write("Digite o número 2: ");
if(!int.TryParse(Console.ReadLine(), out int num2))
{
    Console.WriteLine("Número inválido.");
    return;
}

if (num1 > 0 && num2 > 0)
{
    Console.WriteLine("Ambos os números são positivos.");
}
else if (num1 > 0)
{
    Console.WriteLine("Apenas o primeiro número é positivo.");
}
else if(num2 > 0)
{
    Console.WriteLine("Apenas o segundo número é positivo");
}
else
{
    Console.WriteLine("Nenhum dos números é positivo.");
}