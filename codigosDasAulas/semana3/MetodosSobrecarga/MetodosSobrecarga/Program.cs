namespace MetodosSobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"5 + 90 = {Somar(5,90)}");
            Console.WriteLine($"90 + 80 + 20 = {Somar(90,80,20)}");
            Console.WriteLine($"4.5 + 9.2 = {Somar(4.5,9.2)}");
        }
    
    



    static int Somar(int a, int b) {return a + b;}
    static int Somar(int a, int b, int c) {return a + b + c;}

    static double Somar(double a, double b) {return a + b;}
}
}