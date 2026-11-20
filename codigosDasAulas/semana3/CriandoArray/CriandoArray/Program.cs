int[] notas = new int[3];
Console.WriteLine($"{notas[0]} {notas[1]} {notas[2]} | Tamanho = {notas.Length}");

notas[0] = 7; //preenche a posição 0
notas[2] = 10; //preenche a posição 2

Console.WriteLine($"{notas[0]} {notas[1]} {notas[2]}"); // 7 0 10