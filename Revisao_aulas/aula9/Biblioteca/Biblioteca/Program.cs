using Biblioteca.Modelos;

Livro l1 = new Livro("Dom Casmurro", "Machado");
l1.Ano = 1922;
l1.Autor = "José de Alencar";

Revista r1 = new Revista("IstoÉ", 32);


Console.WriteLine(r1.CalcularMulta(3));
Console.WriteLine(l1.CalcularMulta(3));


List<ItemAcervo> atrasados = new List<ItemAcervo>();
atrasados.Add(l1);
atrasados.Add(r1);

double total = 0;

foreach(ItemAcervo item in atrasados)
{
    double multa = item.CalcularMulta(3);
    Console.WriteLine($"{item.Titulo}: R${multa}");
    total += multa;
}

Console.WriteLine($"Total: R${total}");