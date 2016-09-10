using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tele_Pizza.Class
{
    public class Pessoa
    {
        protected string nome { get; set; }
        protected string telefone { get; set; }
        protected string email { get; set; }
        protected string cpf { get; set; }
        protected DateTime? dataNascimento { get; set; }

        protected Endereco endereco;


        /// <summary>
        /// Criação dos atributos comuns para Pessoa Fisica
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="email"></param>
        /// <param name="cpf"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="endereco"></param>
        public void CreatePessoa(string nome, string telefone, string email, string cpf, DateTime dataNascimento, Endereco endereco)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
            this.endereco = endereco;
        }

    }
}