using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_VIII.Models
{
    public class Endereco
    {
        protected int id;
        public string logradouro;
        public int numero;
        public int cep;
        public string bairro;
        public string cidade;
        public string estado;
    }
}
