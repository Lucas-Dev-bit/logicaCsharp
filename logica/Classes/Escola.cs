using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.Classes
{
    class Escola
    {
       
        public Escola(int professores, int alunos) 
        {     
            QtdProfessores = professores;
            QtdAlunos = alunos;
        }
       


        public string NomeEscola { set; get; }
        public string NomeDiretor { set; get; }
        public int QtdProfessores { set; get; }
        public int QtdAlunos { set; get; }


    }
}
