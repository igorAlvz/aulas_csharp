// um método que recebe dois parâmetros e devolve um valor
class Program{
static double CalcularMedia(double nota1, double nota2)
{
    return (nota1 + nota2) / 2;
}

static void Main(){
double media = CalcularMedia(7.5, 9.0); // 7.5 e 9.0 são os argumentos
Console.WriteLine($"Média: {media:F2}"); // Média: 8,25;

Console.WriteLine(Somar(6,7));
Console.WriteLine(Somar(9,9,10));

}
// sobrecarga: mesmo nome, listas de parâmetros diferentes
static int Somar(int a, int b) {return a + b;}
static int Somar(int a, int b, int c){return a + b + c;}

}