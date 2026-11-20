using System.Security.Cryptography.X509Certificates;

namespace ClassesEConstrutores.Modelos
{
    public class Leitor
    {
        string Nome{get;}
        string Email{get;}
        DateTime DataCadastro {get;}

        public Leitor(string nome, string email)
        {
         Nome = nome;
         Email = email;
         DataCadastro = DateTime.Now;
        }


        public Leitor(string nome)
            {
                Nome = nome;
                Email = "Não Informado";
                DataCadastro = DateTime.Now;
            }

        public override string ToString()
        {
               return $"Nome: {Nome} | Email: {Email} | Data cadastro: {DataCadastro:dd/MM/yyyy HH:mm:ss}"; 

        }
    }

    }

