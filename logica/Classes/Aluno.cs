 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.Classes
{
    public class Aluno
    {
        public Aluno(string nomeParametro, string telParametro)
        {
            Nome = nomeParametro.ToUpper();
            Telefone = telParametro.Replace("(", "")
                                   .Replace(")", "")
                                   .Replace("-", "")
                                   .Replace(" ", "");
        }

        public Aluno()
        {
             
        }
        public string Nome { set; get; }
        public string Telefone { set; get; }
    }
}
