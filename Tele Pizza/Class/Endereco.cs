using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tele_Pizza.Class
{
    public class Endereco
    {
        protected string CEP { get; set; }
        protected string Pais { get; set; }
        protected string Estado { get; set; }
        protected string Cidade { get; set; }
        protected string Bairro { get; set; }
        protected string Numero { get; set; }
        protected string Complemento { get; set; }

    }
}