

using ModificadoresDeAcesso;

Livro l1 = new Livro();

l1.Avaliacao = 5;
l1.Avaliacao = 9; // ignorado
Console.WriteLine(l1.Avaliacao);
l1.Avaliacao = -1; //ignorado
Console.WriteLine(l1.Avaliacao);