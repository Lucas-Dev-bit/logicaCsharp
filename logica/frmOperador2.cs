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
    public partial class frmOperador2: Form
    {
        public frmOperador2()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Trim() == string.Empty || txtNumero2.Text.Trim() == string.Empty || txtNumero3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Prencha todos os campos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal  n1, n2, n3, dividir;

                try
                {
                    n1 = Convert.ToDecimal (txtNumero1.Text);
                    n2 = Convert.ToDecimal(txtNumero2.Text);
                    n3 = Convert.ToDecimal(txtNumero3.Text);

                    dividir = n2 / 2;

                    if(n1 <= dividir && n3 >= dividir)
                    {
                        MessageBox.Show("O NUMERO " + dividir + " está entre o número " + n1 + " e " + n3, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(n3 <= dividir && dividir <= n1)
                    {
                        MessageBox.Show("O NÚMERO " + dividir + " ESTÁ ENTRE O NÚMERO " + n3 + " E " + n1, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("O número " + dividir + " Não esta entre o número " + n1 + " e " + n3, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch
                {
                    MessageBox.Show("PREENCHA TODOS OS CAMPOS", "ERRO");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero3.Clear();
        }
    }
}
