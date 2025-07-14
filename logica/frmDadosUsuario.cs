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
    public partial class frmDadosUsuario: Form
    {
        public frmDadosUsuario()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //verifica se campo nome esta vazio
            if (txtNome.Text.Trim() == "")
            {   
                //mostra a menssagem
                MessageBox.Show("Preencher o nome");
                //joga o cursor no cmapo
                txtNome.Focus();
                //limpa o campo
                txtNome.Clear();
            }
            else if(txtRua.Text.Trim() == "")
            {
                MessageBox.Show("Preencher a rua");
                txtRua.Focus();
                txtRua.Clear();
            }
            else
            {
                string nome, rua;

                nome = txtNome.Text;
                rua = txtRua.Text;

                MessageBox.Show("Nome: " + nome + "\nRua: " + rua);

            }
        }

        
    }
}
