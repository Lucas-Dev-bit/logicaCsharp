using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.Classes
{
    public class Calculo
    {
        /// <summary>
        /// CALCULA O VALOR FINAL DO AUMENTO
        /// </summary>
        /// <param name="valor">VALOR DO USUARIO</param>
        /// <param name="porcentagem"> VALOR DA PORCENTAGEM DO AUMENTO</param>
        /// <returns>RETORNA O VALOR FINAL DO AUMENTO</returns>
        public double CalcularAumentoPorcentagem(double valor, double porcentagem)
        {
            double resposta;
            resposta = valor + (valor * porcentagem) / 100;
            return resposta;
        }


        /// <summary>
        /// CALCULA O VALOR FINAL DO DESCONTO
        /// </summary>
        /// <param name="valor">VALOR DO USUARIO</param>
        /// <param name="porcentagem">VALOR DA PORCENTAGEM DO DESCONTO</param>
        /// <returns>RETORNA O VALOR FINAL DO DESCONTO</returns>
        public double CalcularDescontoPorcentagem(double valor, double porcentagem)
        {
            double resposta;
            resposta = valor - (valor * porcentagem) / 100;
            return resposta;
        }

        public double CalcularValorFinalGeral(double valorFinal1, double valorFinal2)
        {
            double resultadoFinal;

            resultadoFinal = valorFinal1 + valorFinal2;

            return resultadoFinal;
        }


    }
}
