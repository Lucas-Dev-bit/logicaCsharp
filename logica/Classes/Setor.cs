using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.Classes
{
    class Setor
    {
        public Setor(string nome, string coordenador, string lider, int colaboradores)
        {
            nomeSetor = nome.ToUpper();
            nomeCoordenador = coordenador.ToUpper();
            nomeLider = lider.ToUpper();
            qtdColaboradores = colaboradores;
        }

        public Setor()
        {
            
        }
        public string nomeSetor { set; get; }
        public string nomeCoordenador { set; get; }
        public string nomeLider { set; get; }
        public int qtdColaboradores { set; get; }


    }
}
