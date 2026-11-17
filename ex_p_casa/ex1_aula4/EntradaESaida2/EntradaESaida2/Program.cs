
Console.WriteLine("Sistema de cadastro.");
Console.Write("Digite os dados no formato nome;email;cidade: ");
string dados = Console.ReadLine();

if(string.IsNullOrWhiteSpace(dados)){
    Console.WriteLine("ERRO: Linha vazia");
    return;
    }
string[] partes = dados.Split(';');

if(partes.Length < 3)
{
    Console.WriteLine($"ERRO: Formato errado -> {dados}\nEsperado: nome;email;cidade");
    return;
}

Console.WriteLine($"Dados cadastrados\nNome: {partes[0]}\nEmail: {partes[1]}\nCidade: {partes[2]}");