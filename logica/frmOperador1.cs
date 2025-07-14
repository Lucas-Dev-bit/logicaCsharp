using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logica
{
    public partial class frmOperador1: Form
    {
        public frmOperador1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txtN1.Text.Trim() == string.Empty 
                || txtN2.Text.Trim() == string.Empty
                || txtN3.Text.Trim() == string.Empty 
                || txtN4.Text.Trim() == string.Empty 
                || txtN5.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher todos os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal n1, n2, n3, n4, n5, multi1, multi2, resultado;

                try
                {
                    n1 = Convert.ToDecimal(txtN1.Text);
                    n2 = Convert.ToDecimal(txtN2.Text);
                    n3 = Convert.ToDecimal(txtN3.Text);
                    n4 = Convert.ToDecimal(txtN4.Text);
                    n5 = Convert.ToDecimal(txtN5.Text);

                    // MULTIPLICAÇÃO DO N1 E N2
                    multi1 = n1 * n2;
                    //lblR1.Text = Convert.ToString(multi1);

                    //SOMA DO N3 , N4 E N5
                    multi2 = n3 * n4 * n5;
                    //lblR2.Text = Convert.ToString(multi2);

                    resultado = multi1 + multi2;

                    lblResultado1.Text = Convert.ToString(resultado);

                    if (resultado > 100)
                    {
                        MessageBox.Show("ACIMA DE 100", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblResultado1.ForeColor = Color.Blue;
                    }
                    else if(resultado < 100)
                    {
                        MessageBox.Show("ABAIXO DE 100", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblResultado1.ForeColor = Color.Red;
                    }
                    else
                    {
                        MessageBox.Show("IGUAL A 100", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblResultado1.ForeColor = Color.Green;
                    }

                        
                }
                catch
                {
                    MessageBox.Show("Preencha todos os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();
            txtN5.Clear();
            
        }

    }
}
