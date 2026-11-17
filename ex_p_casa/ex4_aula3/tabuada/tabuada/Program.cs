Console.Write("Digite um número para mostrar a tabuada: ");
string entrada = Console.ReadLine();
if(int.TryParse(entrada, out int numero))
{
    for(int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numero} X {i} = {numero * i}");
    }
}
else
{
    Console.WriteLine("Número inválido. Digite um número inteiro.");
}