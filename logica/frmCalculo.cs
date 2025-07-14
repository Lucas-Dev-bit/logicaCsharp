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
    public partial class frmCalculo: Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (txtN1Somar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher o campo Número 1 da soma", "Erro! - Somar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN1Somar.Focus();
                txtN1Somar.Clear();
            }
            else if (txtN2Somar.Text.Trim() == string.Empty) 
            {
                MessageBox.Show("Preencha o campo Número 2 da soma", "Erro! - Somar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN2Somar.Focus();
                txtN2Somar.Clear();
            }
            else
            {
                double numero1, numero2, resultado;

                try
                {
                    numero1 = Convert.ToDouble(txtN1Somar.Text);
                    numero2 = Convert.ToDouble(txtN2Somar.Text);

                    resultado = numero1 + numero2;

                    txtResultadoSomar.Text = Convert.ToString(resultado);
                }
                catch
                {
                    MessageBox.Show("Digitar somente Números", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }
            
        }
        private void btnSubtrair_Click(object sender, EventArgs e)
        {   
            if(txtN1Subtrair.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo Número 1", "Erro! - Subtrair", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN1Subtrair.Focus();
                txtN1Subtrair.Clear();
            }
            else if(txtN2Subtrair.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo Número 2", "Erro! - Subtrair", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN2Subtrair.Focus();
                txtN2Subtrair.Clear();
            }
            else
            {
                double numero1, numero2, resultado;

                try
                {
                    numero1 = Convert.ToDouble(txtN1Subtrair.Text);
                    numero2 = Convert.ToDouble(txtN2Subtrair.Text);

                    resultado = numero1 - numero2;

                    txtResultadoSubtrair.Text = Convert.ToString(resultado);
                }
                catch
                {
                    MessageBox.Show("Preencha somente Número", "Erro! - Subtrair", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if(txtN1Dividir.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo Número 1", "Erro! - Dividir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN1Dividir.Focus();
                txtN1Dividir.Clear();
            }
            else if(txtN2Dividir.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo Número 2", "Erro! - Dividir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN2Dividir.Focus();
                txtN2Dividir.Clear();
            }
            else
            {
                double numero1, numero2, resultado;

                try
                {
                    numero1 = Convert.ToDouble(txtN1Dividir.Text);
                    numero2 = Convert.ToDouble(txtN2Dividir.Text);

                    resultado = numero1 / numero2;

                    txtResultadoDividir.Text = Convert.ToString(resultado);
                }
                catch
                {
                    MessageBox.Show("Preencha somente Números", "Erro! - Dividir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if(txtN1Multiplicar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo Número 1", "Erro! - Multiplicar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN1Multiplicar.Focus();
                txtN1Multiplicar.Clear();
            }
            else if(txtN2Multiplicar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo Número 2", "Erro! - Multiplicar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN2Multiplicar.Focus();
                txtN2Multiplicar.Clear();

            }
            else
            {
                try
                {
                    double numero1, numero2, resultado;

                    numero1 = Convert.ToDouble(txtN1Multiplicar.Text);
                    numero2 = Convert.ToDouble(txtN2Multiplicar.Text);

                    resultado = numero1 * numero2;

                    txtResultadoMultiplicar.Text = Convert.ToString(resultado);
                }
                catch
                {
                    MessageBox.Show("Preencha somente Números", "Erro! - Multiplicar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1Somar.Clear();
            txtN2Somar.Clear();
            txtResultadoSomar.Clear();
        }

        private void btnLimpar1_Click(object sender, EventArgs e)
        {
            txtN1Subtrair.Clear();
            txtN2Subtrair.Clear();
            txtResultadoSubtrair.Clear();
        }

        private void btnLimpar2_Click(object sender, EventArgs e)
        {
            txtN1Dividir.Clear();
            txtN2Dividir.Clear();
            txtResultadoDividir.Clear();
        }

        private void btnLimpar3_Click(object sender, EventArgs e)
        {
            txtN1Multiplicar.Clear();
            txtN2Multiplicar.Clear();
            txtResultadoMultiplicar.Clear();
        }
    }
}
