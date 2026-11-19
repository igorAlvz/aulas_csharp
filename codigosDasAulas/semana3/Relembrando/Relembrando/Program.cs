int quantidade = 3; // número inteiro
double preco = 49.90; // número com casas decimais
bool disponivel = true; // verdadeiro ou falso
string titulo = "Iracema"; // texto

if (quantidade > 0) // decisão: Só executa se a condição for verdadeira
{
    Console.WriteLine("Tem em estoque");

}
else
{
    Console.WriteLine("Esgotado");
}

for (int i = 0; i < 3; i++) // repitação: executa o bloco 3 vezes (i = 0, 1, 2)
{
    Console.WriteLine(i);
}