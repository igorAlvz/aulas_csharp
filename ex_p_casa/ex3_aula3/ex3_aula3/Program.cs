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