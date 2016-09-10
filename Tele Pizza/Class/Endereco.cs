using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tele_Pizza.Class
{
    public class Endereco
    {
        protected string cep { get; set; }
        protected string pais { get; set; }
        protected string estado { get; set; }
        protected string cidade { get; set; }
        protected string bairro { get; set; }
        protected int numero { get; set; }
        protected string complemento { get; set; }

    }
}