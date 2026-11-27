

using AulaClasses;
using AulaClasses.Modelo;

Livro l1 = new Livro("Dom Casmurro", "Machado", 1944);
l1.Avaliacao = 3;
l1.Avaliacao = 9;


l1.Emprestar();
l1.Devolver();



Console.WriteLine(l1);