
 static bool ehPar (int n)
{
    return n % 2 == 0;
}


Console.Write("Digite um número para verificar se é par ou ímpar ");

string entrada = Console.ReadLine();

if (!int.TryParse(entrada, out int numero))
{
    Console.WriteLine("ERRO: Digite somente um número inteiro.");
}
else
{
    if(ehPar(numero)) Console.WriteLine("É par");
    else Console.WriteLine("É ímpar");
}