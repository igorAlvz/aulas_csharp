namespace ex4v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] placas = {"   abc1d23  ", "ABC1D23", "45ADC56", "ABC1D2", "ABC-1234"};

           foreach (string entrada in placas)
            {
               string placaNormalizada = NormalizarPlaca(entrada);
               if (PlacaValida(placaNormalizada))
                {
                    Console.WriteLine($"Placa: {placaNormalizada} - válida");
                }
                else
                {
                    Console.WriteLine($"Placa: {placaNormalizada} - inválida");
                }
            }
        }

        static string NormalizarPlaca(string placa)
        {
            return placa.Trim().ToUpper();
        }

        static bool PlacaValida (string placa)
        {
            if (placa.Length != 7)
            {
                return false;
            }
            
            for (int i = 0; i < placa.Length; i++)
            {
                bool deveSerLetra = i <= 2 || i == 4;

                if (deveSerLetra && !char.IsLetter(placa[i]))
                {
                    return false;
                }
                if (!deveSerLetra && !char.IsDigit(placa[i]))
                {
                    return false;
                }
               
            }
            return true;
        }

        
    }
}
