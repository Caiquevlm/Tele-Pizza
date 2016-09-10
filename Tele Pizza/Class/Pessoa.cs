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
        protected DateTime dataNascimento { get; set; }


        protected Endereco endereco;
    }
}