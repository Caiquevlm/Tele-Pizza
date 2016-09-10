using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tele_Pizza.Class
{
    public class Fornecedor
    {
        protected string razaoSocial { get; set; }
        protected string nomeComercial { get; set; }
        protected string telefone { get; set; }
        protected string email { get; set; }
        protected string cnpj { get; set; }
        protected DateTime dataAbertura { get; set; }


        protected Endereco Endereco;
    }
}