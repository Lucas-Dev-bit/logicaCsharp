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
    public partial class frmFormulario2: Form
    {
        public frmFormulario2()
        {
            InitializeComponent();
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            if (txtJogador1.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o nome do jogador 1", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJogador1.Focus();
                txtJogador1.Clear();
            }
            else if (txtJogador2.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o nome do jogador 2", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJogador2.Focus();
                txtJogador2.Clear();
            }
            else if (txtJogador3.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o nome do jogador 3", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJogador3.Focus();
                txtJogador3.Clear();
            }
            else if (txtTecnico.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o nome do Técnico", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTecnico.Focus();
                txtTecnico.Clear();
            }
            else if(txtCapitao.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o nome do Capitão", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCapitao.Focus();
                txtCapitao.Clear();
            }
            else
            {
                string j1, j2, j3, Tecnico, Capitao;

                j1 = txtJogador1.Text;
                j2 = txtJogador2.Text;
                j3 = txtJogador3.Text;
                Tecnico = txtTecnico.Text;
                Capitao = txtCapitao.Text;

                MessageBox.Show("Jogador 1: " + j1 + "\nJogador 2: " + j2 + "\nJogador 3: " + j3 + "\nTécnico: " + Tecnico + "\nCapitão: " + Capitao, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
