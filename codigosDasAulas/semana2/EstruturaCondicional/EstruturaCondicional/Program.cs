Console.WriteLine("Quantidade de páginas do pedido: ");
string? texto = Console.ReadLine();


if(!int.TryParse(texto, out int paginas)) // ! = "nao": se NÃO conseguiu converter
{
    Console.WriteLine("ERRO: Digite um número inteiro");
}
else if(paginas < 0)
{
    Console.WriteLine("ERRO: a quantidade de páginas não pode ser negativa.");
}
else if(paginas <= 20) // pedidos de até 20 páginas são imporessos na hora
{
    Console.WriteLine("Pedido Pequeno");
}
else if(paginas <= 100) // até 100 páginas: entrega no mesmo dia
{
    Console.WriteLine("Pedido Médio");
}
else
{
    Console.WriteLine("Pedido grande");
}

