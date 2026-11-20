using System.Security.Cryptography.X509Certificates;

namespace ClassesEConstrutores.Modelos
{
    public class Leitor
    {
        string Nome{get;}
        //string Email{get;}
        //DateTime DataCadastro {get;}

        public static int TotalCadastrados; // static: um só valor, da classe inteira
        public int LivrosEmprestados {get;set;}
        //public Leitor(string nome, string email)
        //{
        // Nome = nome;
         //Email = email;
         //DataCadastro = DateTime.Now;
       //}


        public Leitor(string nome, int livrosEmprestados)
            {
                Nome = nome;
                TotalCadastrados++;
                LivrosEmprestados = livrosEmprestados;
            }

       public static bool NomeValido(string nome)
        {
            return nome.Trim().Length >= 2;
        }
    }

    }

