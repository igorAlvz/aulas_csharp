using System.Globalization;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p1 = "   jHJK-9092 ";
            string p2 = "KJSK-1012";
            string p3 = "jdkk-1929";

            string p1Normalizada = NormalizaPlaca(p1);
            string p2Normalizada = NormalizaPlaca(p2);
            string p3Normalizada = NormalizaPlaca(p3);

            Console.WriteLine($"Placa digitada: {p1} - Normalizada: {p1Normalizada}");
            Console.WriteLine($"Placa digitada: {p2} - Normalizada: {p2Normalizada}");
            Console.WriteLine($"Placa digitada: {p3} - Normalizada: {p3Normalizada}");
        }


        static string NormalizaPlaca(string placa)
        {
           string placaNormalizada = placa.Trim().ToUpper();

            return placaNormalizada;
        }
    }
}
