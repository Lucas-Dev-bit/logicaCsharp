using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logica
{
    public partial class frmEnum: Form
    {
        public frmEnum()
        {
            InitializeComponent();
        }

        private enum TipoPessoa {
            PessoaFisica,
            PessoaJuridica
        }

        private void ExibirGrupo(int index)
        {
            switch ((int) index) {
                case (int)TipoPessoa.PessoaFisica:
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = false;

                break;
                case (int)TipoPessoa.PessoaJuridica:
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    break;
                default:
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    break;
            }

        }



        private void frmEnum_Load(object sender, EventArgs e)
        {
            ExibirGrupo(-1);
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExibirGrupo(cbTipo.SelectedIndex);
        }
    }
}
