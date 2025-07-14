using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace logica
{
    public partial class frmCalculo1: Form
    {
        public frmCalculo1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (txtN1.Text.Trim() == string.Empty)
            {
                txtN1.Clear();
                txtN1.Focus();

                MessageBox.Show("Preencha o campo Número 1", "Erro!!");
            }
            else if (txtN2.Text.Trim() == string.Empty)
            {
                txtN2.Clear();
                txtN2.Focus();
                MessageBox.Show("Preencha o campo Número 2", "Erro!!");
             }
            else if(txtN3.Text.Trim() == string.Empty)
            {
                txtN3.Clear();
                txtN3.Focus();
                MessageBox.Show("Preencha o campo Número 3", "Erro!!");
            }
            else
            {
                double n1, n2, n3, res, soma;

                try
                {
                    n1 = Convert.ToDouble(txtN1.Text);
                    n2 = Convert.ToDouble(txtN2.Text);
                    n3 = Convert.ToDouble(txtN3.Text);
                    
                    res = n1 + n2 + n3;

                    soma = res / 3;

                    txtResultado.Text = Convert.ToString(soma);

                }
                catch
                {
                    MessageBox.Show("Informe corretamento os números", "Erro!!");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtResultado.Clear();
        }
    }
}
