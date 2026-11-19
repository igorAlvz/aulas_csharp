Console.Write("Digite sua idade: ");
string? entrada = Console.ReadLine();

if (int.TryParse(entrada, out int idade))
{
    Console.WriteLine($"Ano que vem você terá {idade + 1} anos");
}
else
{
    Console.WriteLine($"Erro: Isso não é número inteiro válido"); 
}