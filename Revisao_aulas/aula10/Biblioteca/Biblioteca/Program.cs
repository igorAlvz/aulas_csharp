using Biblioteca.Modelos;

Livro l1 = new Livro("Dom Casmurro", "Machado");
l1.Ano = 1922;
l1.Autor = "José de Alencar";

Revista r1 = new Revista("IstoÉ", 32);

List<IRelatavel> relatorio = new List<IRelatavel>();
//relatorio.Add(r1);
//relatorio.Add(new SalaDeEstudo(3,35));
//relatorio.Add(l1);

//foreach(IRelatavel r in relatorio)
//{
//    Console.WriteLine(r.GerarResumo());
//}

//MostrarResumo(new Livro("Dom Casmurro", "Machado"));
//MostrarResumo(new SalaDeEstudo(2,33));
//MostrarResumo("uma string");
//MostrarResumoComAs(1999);
//MostrarResumoComAs(new Revista("Isto É", 32));
//void MostrarResumo(object obj)
//{
//    if(obj is IRelatavel relatavel)
//    {
//        Console.WriteLine(relatavel.GerarResumo());
//    }
//    else
//    {
//        Console.WriteLine("Esse Objeto nao gera resumo");
//    }
//}

//void MostrarResumoComAs(object obj)
//{
//    IRelatavel? relatavel = obj as IRelatavel;

//    if(relatavel != null)
//    {
//        Console.WriteLine(relatavel.GerarResumo());
//    }
//    else
//    {
//        Console.WriteLine("O as devolvei null, não gera relatório");
//    }
//} 


List<ItemAcervo> tres = new List<ItemAcervo>();

tres.Add(new Livro("livro", "autor" ));
tres.Add(new Revista("Isto É", 32 ));
tres.Add(new Livro("livro2", "autor2" ));


////tres.Sort(CompararPorMulta);
//tres.Sort((a,b)=> a.CalcularMulta(3).CompareTo(b.CalcularMulta));
//foreach(ItemAcervo item in tres)
//{
//    Console.WriteLine($"{item.Titulo}: R$ {item.CalcularMulta(3):F2}");
//}
//int CompararPorMulta(ItemAcervo a, ItemAcervo b)
//{
//    return a.CalcularMulta(3).CompareTo(b.CalcularMulta(3));
//}

//Console.WriteLine(1.50.CompareTo(3.00));
//Console.WriteLine(1.50.CompareTo(1.50));
//Console.WriteLine(6.00.CompareTo(3.00));

ItemAcervo caro = tres.Find(i => i.CalcularMulta(3) > 2.00);
Console.WriteLine(caro.Titulo);