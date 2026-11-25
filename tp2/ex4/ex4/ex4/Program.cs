namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p1 = "  ABC2D12   ";
            string p2 = "45ADC56";
            string p3 = "fsdfsdfsdfsfd";

            Console.WriteLine($"Placa informada: {p1} - É valida: {PlacaValida(p1)}");
            Console.WriteLine($"Placa informada: {p2} - É valida: {PlacaValida(p2)}");
            Console.WriteLine($"Placa informada: {p3} - É valida: {PlacaValida(p3)}");
        }

        static string NormalizarPlaca(string placa)
        {
            return placa.ToUpper().Trim();
        }

        static bool PlacaValida(string placa)
        {
            string placaNormalizada = NormalizarPlaca(placa);

            if(placaNormalizada.Length != 7)
            {
                return false;
            }

            for(int i = 0; i < placaNormalizada.Length; i++)
            {
                if(i <= 2)
                {
                    if (!char.IsLetter(placaNormalizada[i])){
                        return false;
                    }
                } else if (i == 3)
                {
                    if (!char.IsDigit(placaNormalizada[i]))
                    {
                        return false;
                    }
                } else if(i == 4)
                {
                    if (!char.IsLetter(placaNormalizada[i])){
                        return false;
                    }
                }
                else
                {
                    if (!char.IsDigit(placaNormalizada[i]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
