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
    public partial class frmLacoRepeticao1: Form
    {
        public frmLacoRepeticao1()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                int qtd = Convert.ToInt32(txtQtd.Text);

                Repetir(qtd);
            }
           
        }

        private bool ValidarCampos()
        {
            bool flag = true;

            if(txtNome.Text.Trim() == string.Empty || 
                txtIdade.Text.Trim() == string.Empty)
            {
                
                MessageBox.Show("Preencha todos os campos corretamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }

            return flag;
            
        }

        private void Repetir(int qtd)
        {
            int idade = Convert.ToInt32(txtIdade.Text);
            string frase = Convert.ToString(txtNome.Text);

            for(int i = 0; i < qtd; i++)
            {
                MessageBox.Show("MEU NOME É: " + frase + ", TENHO: " + idade + " ANOS DE IDADE");
            }

            
        }
    }
}
