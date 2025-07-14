using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.Classes
{
    public class Roupa
    {
        public Roupa(string tipo, int numero, string cor, decimal valor)
        {
            TipoRoupa = tipo.ToUpper();
            Numero = numero;
            Cor = cor.ToUpper();
            Valor = valor;
        }

        public Roupa()
        {

        }

        public string TipoRoupa { get; set; }
        public int Numero { get; set; }
        public string Cor { get; set; }
        public decimal Valor { get; set; }

       
    }
}
