namespace Sobregarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] vetor = { "B200", "b120", "C500", "B9f0" };

            Console.WriteLine($"Na lista {string.Join(", ", vetor)} temos: {SalaValida(vetor)} salas válidas.");
            
        }


        static bool SalaValida(string codigo)
        {
            if (codigo.Length < 4)
            {
                return false;
            }

            for (int i = 0; i < codigo.Length; i++)
            {
                if (i == 0)
                {
                    if (!char.IsLetter(codigo[i]) && char.IsUpper(codigo[i])) return false;
                }

                else if (!char.IsDigit(codigo[i])) return false;
            }

            return true;

        }

        static int SalaValida(string[] codigo)
        {
            int validos = 0;
            bool valido = false;

            for (int i = 0; i < codigo.Length; i++)

            

            {
                if (valido) validos++;

                valido = false;
                if (codigo[i].Length < 4)
                {
                    continue;
                }

                for (int j = 0; j < codigo[i].Length; j++) {
                    valido = false;
                    Console.WriteLine(codigo[i][j]);
                    if (j == 0) {
                        if (!char.IsLetter(codigo[i][j]) && char.IsUpper(codigo[i][j])) break; ;
                    }
                    else if (!char.IsDigit(codigo[i][j])) break;
                    
                    valido = true;
                   
            }
            }

            return validos;

        }
    }
}
