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
    public partial class frmMetodo: Form
    {
        public frmMetodo()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //1 - validar os campos
            //bool flagRetorno = ValidarCampos();

            if(!ValidarCampos())
            {
                MessageBox.Show("Preencher todos os campos.");
            }
            //2 - realizar calculos
            else
            {
                double numero1, numero2, resultado;

                numero1 = Convert.ToDouble(txtN1.Text);
                numero2 = Convert.ToDouble(txtN2.Text);

                resultado = CalcularSoma(numero1, numero2);
                txtResultado.Text = Convert.ToString(resultado);
           
            }

        }

        private Boolean ValidarCampos()
        {
            bool flag = true;

            if(txtN1.Text.Trim() == string.Empty || txtN2.Text.Trim() == string.Empty)
            {
                flag = false;
            }
            return flag;
        }

        private double CalcularSoma (double n1, double n2)
        {
            double resultado;

            resultado = n1 + n2;

            return resultado;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtN1.Clear();
            txtN2.Clear();
            txtResultado.Clear();
        }
    }
}
