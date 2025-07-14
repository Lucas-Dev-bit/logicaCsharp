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
    public partial class frmFormulario3: Form
    {
        public frmFormulario3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtRazaoSocial.Text.Trim() == "")
            {
                MessageBox.Show("Peencha o campo Razão Social", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRazaoSocial.Focus();
                txtRazaoSocial.Clear();
            }
            else if (txtFantasia.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nome Fantasia", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFantasia.Focus();
                txtFantasia.Clear();
            }
            else if (mtxtCnpj.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo CNPJ", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtCnpj.Focus();
                mtxtCnpj.Clear();
            }
            //if (mtxtCnpj.Text.Length != 14)
            //{
            //MessageBox.Show("CNPJ INCORRETO", "Erro");
            // return;
            //}
            else if(mtxtTelefone.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo Telefone", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtTelefone.Focus();
                mtxtTelefone.Clear();
            }
            else if(txtObs.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo Observações", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtObs.Focus();
                txtObs.Clear();
            }
            else
            {
                string razaoSocial, nomeFantasia, cnpj, telefone, obs;

                razaoSocial = txtRazaoSocial.Text;
                nomeFantasia = txtFantasia.Text;
                cnpj = mtxtCnpj.Text;
                telefone = mtxtTelefone.Text;
                obs = txtObs.Text;

                MessageBox.Show("Razão Social: " + razaoSocial + "\nNome Fantasia: " + nomeFantasia + "\nCNPJ: " + cnpj + " | Telefone: " + telefone);
            }
        }
    }
}
