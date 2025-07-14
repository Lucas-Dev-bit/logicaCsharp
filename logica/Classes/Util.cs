using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logica.Classes
{
    public static class Util
    {
        public enum EstadoTela
        {
            Novo,
            Edicao
        }

        public enum TipoCombustivel
        {
            Gasolina = 0,
            Alcool = 1 ,
            Diesel = 2,
            Etanol = 3,
            Flex = 4
        }
        public static void ConfigurarEstadoTela(Util.EstadoTela tela, Button btnCadastrar,
                                                                       Button btnAlterar,
                                                                       Button btnExcluir
                                                                      )
        {
            switch (tela)
            {
                case EstadoTela.Novo:
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    //btnCancelar.Enabled = true;
                    break;
                case EstadoTela.Edicao:
                    btnCadastrar.Enabled = false;
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                   // btnCancelar.Enabled = true;
                    break;
            }
        }

        public static string pathFileXml = "C:\\Users\\Lucas\\Desktop\\Curso de Programação\\ArquivoXML\\armazenagem.xml";
        public static string pathFileXml1 = "C:\\Users\\Lucas\\Desktop\\Curso de Programação\\ArquivoXML\\ExercicioXML1.xml";
    }
}
