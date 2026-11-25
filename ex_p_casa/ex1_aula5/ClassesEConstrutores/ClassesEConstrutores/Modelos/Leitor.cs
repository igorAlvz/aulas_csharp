using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesEConstrutores.Modelos
{
    public class Leitor
    {

        public string Nome { get; }
        public string Email { get; set; }

        public DateTime DataCadastrado { get; }

        private int livroEmprestado;

        public int LivrosEmprestados
        {
            get { return livroEmprestado; }
            set
            {
                if (value >= 0 && value <= 3)
                {
                    livroEmprestado = value;
                }
            }
        }

        public Leitor(string nome, string email,int qtdLivros)
        {
            this.Nome = nome;
            this.Email = email;
            this.DataCadastrado = DateTime.Now;
            this.LivrosEmprestados = qtdLivros;

        }

        public override string ToString()
        {
            return $"Nome: {Nome} | Email: {Email} | Data Cadastro {DataCadastrado:dd/MM/yyyy HH:mm:ss} | Livros emprestados: {LivrosEmprestados}";
        }

    }
}
