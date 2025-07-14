using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.Classes
{
    public class Cliente
    {
        public Cliente(string nome, string rua, string bairro, string cep)
        {
            this.Bairro = bairro.ToUpper();
            this.Cep = cep.ToUpper();
            this.Rua = rua.ToUpper();
            this.Nome = nome.ToUpper();
        }

        public Cliente()
        {

        }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }



    }
}
