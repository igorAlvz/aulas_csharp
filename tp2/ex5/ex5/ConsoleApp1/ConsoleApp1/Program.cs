using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PlacaValida("ABC1D0"));
            string[] placasInput = { "ABC1D20", "JK21000", "  dsaao20", "jdadj", "abc1d20", "   abd2f25" };
            //bool[] placasValidadas = PlacaValida(placasInput);

            string[] placasNormalizada = NormalizarPlaca(placasInput);
            bool[] placasValidadas = PlacaValida(placasNormalizada);
            
            for(int i = 0; i < placasInput.Length; i++)
            {
                bool isValida = placasValidadas[i];
                if (isValida)
                {
                    Console.WriteLine($"Placa: {placasNormalizada[i]} - Válida");
                }
                else
                {
                    Console.WriteLine($"Placa: {placasNormalizada[i]} - Inválida");
                }
            }
        }
        

        
        static string NormalizarPlaca(string placa)
        {
            return placa.ToUpper().Trim();
        }

        static string[] NormalizarPlaca(string[] placas)
        {
            string[] placasNormalizada = new string[placas.Length];

            for(int i = 0; i < placas.Length; i++)
            {
                placasNormalizada[i] = placas[i].ToUpper().Trim();
            }
            return placasNormalizada;
        }

        static bool PlacaValida(string placa)
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


        static bool[] PlacaValida(string[] placas)
        {
            bool[] placasValidas = new bool[placas.Length];

            for (int i = 0; i < placas.Length; i++)
            {
                if (placas[i].Length != 7)
                {
                    placasValidas[i] = false;
                    continue;
                }
                for (int j = 0; j < placas[i].Length; j++)
                {
                    placasValidas[i] = true;
                    bool deverSerLetra = j <= 2 || j == 4;
                    if (deverSerLetra && !char.IsLetter(placas[i][j]))
                    {
                        placasValidas[i] = false;
                        break;
                    }

                    if (!deverSerLetra && !char.IsDigit(placas[i][j]))
                    {
                        placasValidas[i] = false;
                        break;
                    }
                }
                if (!placasValidas[i])
                {
                    continue;
                }
                placasValidas[i] = true;
            }
            return placasValidas;

        }

    }
}
