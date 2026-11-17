


using System.Globalization;

Console.WriteLine("Empréstimo");
Console.Write("Nome do leitor: ");
string nomeLeitor = Console.ReadLine();

if (string.IsNullOrWhiteSpace(nomeLeitor)){
    Console.WriteLine("Nome inválido");
    return;
} 

Console.Write("Quantidade de livros: ");
string entradaLivros = Console.ReadLine();

if(!int.TryParse(entradaLivros,out int qtdLivros))
{
    Console.WriteLine("Erro: Digite somente números inteiros");
} else if (qtdLivros < 0)
{
    Console.WriteLine("ERRO: Você digitou número negativo");
}
else
{
    Console.WriteLine($"Empréstimo para: {nomeLeitor} / Quntidade de livros: {qtdLivros}");
}