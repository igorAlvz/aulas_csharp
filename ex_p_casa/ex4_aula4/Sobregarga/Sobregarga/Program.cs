using System.Runtime.InteropServices.Marshalling;

namespace Sobregarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] vetor = { "B200", "b10", "b500", "b9f0" };

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
                    if (!char.IsLetter(codigo[i]) || !char.IsUpper(codigo[i])) return false;
                }

                else if (!char.IsDigit(codigo[i])) return false;
            }

            return true;

        }

        static int SalaValida(string[] codigo)
        {
            int validos = 0;
           

            for (int i = 0; i < codigo.Length; i++)
            {
                if (SalaValida(codigo[i]))
                    {
                    validos++;
                }
            }

    
            return validos;
               
                   
            } 
        } }
            

