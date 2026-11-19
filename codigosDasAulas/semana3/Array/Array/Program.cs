string linha = "Dom Casmurro;Machado de Assis;1899";
string[] partes = linha.Split(';');


Console.WriteLine(partes.Length);
Console.WriteLine($"Título: {partes[0]}");
Console.WriteLine($"Autor: {partes[1]}");
Console.WriteLine($"Ano: {partes[2]}");
