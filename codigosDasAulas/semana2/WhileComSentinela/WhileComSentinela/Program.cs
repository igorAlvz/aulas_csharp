int soma = 0; // acumulador: vai somando as notas 
int quantidade = 0; // contador = conta quantas notas válidas entraram

Console.Write("Nota (ou -1 para terminar): ");
int nota = Convert.ToInt32(Console.ReadLine()); // primeira leitura, ANTES do laço

while(nota != -1) // Enquanto não digitar sentinela;
{
    soma = soma + nota;
    quantidade++;

    Console.Write("Nota (ou -1 para terminar): ");
    nota = Convert.ToInt32(Console.ReadLine());

}

if (quantidade > 0)
{
    double media = (double)soma / quantidade;
    Console.WriteLine($"{quantidade} notas, média {media:F2}");
}
else
{
    Console.WriteLine("Nenhuma nota foi digitada.");
}
