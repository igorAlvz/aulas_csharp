Console.Write("Digite seu nome: ");
string? nome = Console.ReadLine();

if (string.IsNullOrWhiteSpace(nome))
{
    Console.WriteLine("ERRO: O  nome não pode ficar vázio.");
}
else
{
    Console.WriteLine($"Olá,{nome.Trim()}! Seja bem-vindo!");
}