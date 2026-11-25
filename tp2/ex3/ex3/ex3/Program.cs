    namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FormataTickets(34,54.4);
            FormataTickets(4,4.4);
        }

        static void FormataTickets(int ticketsProcessados, double permanênciaMedia)
        {
            Console.WriteLine($"Tickets processados no dia: {ticketsProcessados} Permanência média {permanênciaMedia:F2} h");
        }
    }
}
