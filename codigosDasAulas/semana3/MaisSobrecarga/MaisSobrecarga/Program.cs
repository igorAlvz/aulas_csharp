namespace MaisSobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] titulos = {"Senhora", "Dom Casmurro", "O Guarani"};
            int[] contagens = contagens = ContarVogais(titulos);
            for (int i = 0; i < titulos.Length; i++)
            {
                Console.WriteLine($"{titulos[i]}: {contagens[i]} vogais");
            }
            
        }

        static int ContarVogais(string texto)
        {
            int total = 0;
            foreach (char letra in texto.ToLower()) // foreach: "para cada letra do texto"
            {
                if ("aeiou".Contains(letra))
                {
                    total++;
                }
            }

            return total;
        }

        //Versão 2: mesmo nome, mas recebe vários texto e devolve UM resultado por texto
        static int[] ContarVogais(string[] textos)
        {
            int[] resultados = new int[textos.Length]; // Um espaço para cada texto recebido
            for(int i = 0; i < textos.Length; i++)
            {
                resultados[i] = ContarVogais(textos[i]); // a posição i do resultado corresponde ao texto 1
            }

            return resultados;
        }
    }
}
