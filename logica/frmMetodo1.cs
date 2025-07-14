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
    public partial class frmMetodo1: Form
    {
        public frmMetodo1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                try
                {         
                    double n1, n2, n3, n4, n5, resultado;

                    n1 = Convert.ToDouble(txtN1.Text);
                    n2 = Convert.ToDouble(txtN2.Text);
                    n3 = Convert.ToDouble(txtN3.Text);
                    n4 = Convert.ToDouble(txtN4.Text);
                    n5 = Convert.ToDouble(txtN5.Text);

                    resultado = SomaTotal(n1, n2, n3, n4, n5);
                    lblResultado.Text = Convert.ToString(resultado);
                }
            
                catch
                {
                    MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool ValidarCampos()
        {
            bool flag = true;

            if(txtN1.Text.Trim() == string.Empty
                || txtN2.Text.Trim() == string.Empty
                || txtN3.Text.Trim() == string.Empty
                || txtN4.Text.Trim() == string.Empty
                || txtN5.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            return flag;
        }

        private double SomaTres(double numero1, double numero2, double numero3)
        {
            double resultadoFinal;

            resultadoFinal = numero1 + numero2 + numero3;

            return resultadoFinal;
        }

        private double SomaTotal(double numero1, double numero2, double numero3, double numero4, double numero5)
        {
            double resultadoSomaTres;
            double resultadoFinal;

            resultadoSomaTres = SomaTres(numero1, numero2, numero3);
            resultadoFinal = (numero4 + numero5) * resultadoSomaTres;

            return resultadoFinal;

            
        }
    }
}
