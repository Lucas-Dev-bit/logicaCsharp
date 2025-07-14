using logica.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logica.Classes
{
    public class CalculosSalario
    {

        public double CalcularPorcentagemDesconto(double salario, double porcentagem)
        {
            double salarioLiquido;
            salarioLiquido = salario - (salario * porcentagem) / 100;
            return salarioLiquido;
        }
        public double CalcularPorcentagemAumento(double salario, double porcentagem)
        {
            double salarioLiquido;
            salarioLiquido = salario + (salario * porcentagem) / 100;
            return salarioLiquido;
        }

        public string Classificacao(double salarioLiquido)
        {

            string msg = string.Empty;
            
                if (salarioLiquido < 1501)
                {
                    msg = "BAIXO ";
                  
                }
                else if (salarioLiquido >= 1501 && salarioLiquido < 2501)
                {
                    msg = "MÉDIO";
                }
                else if (salarioLiquido >= 2501)
                {
                    msg = "ALTO";
                }
                 return msg;
        }
    }
}
