namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m = CalculaMedia(7.8, 8.5);
            Console.WriteLine($"Média {m:F2}");
            MostraSeparador();
        }

        static double CalculaMedia(double n1, double n2)
        {
            double media = (n1 + n2) / 2;
            return media;
        }

        static void MostraSeparador()
        {
            Console.WriteLine("-------------------------");
        }
    }
}
