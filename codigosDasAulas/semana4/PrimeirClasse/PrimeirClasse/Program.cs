using Biblioteca.Modelos;
using PrimeirClasse.Modelos;

/* Leitor l1 = new Leitor();
l1.Nome = "Igor"; // new: cria um objeto novo a partir do molde
l1.LivrosEmprestados = 2; // o ponto acessa um campo DAQUELE objeto

Leitor l2 = new Leitor();
l2.Nome = "Pedro";

Console.WriteLine($"{l1.Nome} : {l1.LivrosEmprestados} | {l2.Nome} {l2.LivrosEmprestados}");
l2.PegarLivro();
Console.WriteLine($"{l1.Nome} : {l1.LivrosEmprestados} | {l2.Nome} {l2.LivrosEmprestados}");
*/


/* l1 = new Livro("Dom Casmurro", "Machado de Assis", 1899);
Livro l2 = new Livro("Lendas Antigas", 1950);

Console.WriteLine(l1);
Console.WriteLine(l2); */

/* Leitor ana = new Leitor("Ana");
Leitor bruno = new Leitor("Bruno");

Console.WriteLine(ana.Nome);
Console.WriteLine(bruno.Nome);
Console.WriteLine(Leitor.TotalCadastrados);
Console.WriteLine(Leitor.NomeValido("   b   "));
Console.WriteLine(Leitor.NomeValido("Carla")); */

/*Livro[] estande =
{
    new Livro("Dom Casmurro", "Machado de Assis", 1899), 
    new Livro("Iracema", "José de Alencar", 1865),
    new Livro("Lendas Antigas", 1950)
};

foreach (Livro livro in estande)
{
    Console.WriteLine(livro);
}*/

Exemplar e1 = new Exemplar("Dom Casmurro", new DateTime(2019,3,15));
Console.WriteLine(e1);