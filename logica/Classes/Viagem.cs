using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.Classes
{
    class Viagem
    {
        public Viagem(string destino) 
        {
            DestinoViagem = destino;
        }

        public string DestinoViagem { get; set; }
        public string NomePassageiro { set; get; }
        public DateTime Data { set; get; }
        public decimal Valor { set; get; }
    }
    
    

}
