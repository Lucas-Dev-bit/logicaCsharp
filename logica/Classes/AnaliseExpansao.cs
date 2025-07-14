using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.Classes
{
    public class AnaliseExpansao
    {
        public bool verificaHabitantes(int numeroHabitantes)
        {
            return numeroHabitantes >= 1000000;
        }
        public bool verificaRenda(double renda)
        {
            return renda >= 2000;
        }
        
        public string Verificacao(bool numeroHabitantes, bool renda)
        {
          
            if(numeroHabitantes && renda )
            {
                return "A cidade está apapta para receber a filial";
            }
            if(numeroHabitantes || renda)
            {
                return "A cidade atende parcialmente aos requisitos.Análise detalhada necessária.";
            }
            else
            {
                return "A cidade não atende aos critérios mínimos para expansão.";
            }

           
            
        }
    }
}
