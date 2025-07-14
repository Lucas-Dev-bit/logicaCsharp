using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace logica.Classes
{
    public class CalculoVeiculo
    {
        public double CalcularConsumoMedio(double distancia, double combustivel)
        {
            double consumoMedio;
            consumoMedio = distancia / combustivel;
            return consumoMedio;
        }

        public string VerClassificacao(double consumoMedio)
        {
            string msg = string.Empty;
            if(consumoMedio < 10)
            {
                msg = "GASTADOR";
            }
            else if(consumoMedio >= 10 && consumoMedio < 15)
            {
                msg =  "INTERMEDIÁRIO";
            }
            else
            {
                msg = "ECONÔMICO";
            }
            return msg;
        }
    }
}
