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
    public partial class frmParImpar: Form
    {
        public frmParImpar()
        {
            InitializeComponent();
        }

        int contarPares = 0;
        int contarImpares = 0;

        private void ContarPares()
        {
            contarPares = contarPares + 1;
            lblContrarPares.Text = contarPares.ToString();
        }

        private void ContarImpares()
        {
            //contarImpares = contarImpares + 1;
            contarImpares++;
            lblContarImpares.Text = contarImpares.ToString();
        }

        private void Contar(double numero)
        {
            if(numero % 2 == 0)
            {
                ContarPares();
            }
            else
            {
                ContarImpares();
            }
        }

        private void LimparCampo()
        {
            txtNumero.Clear();
            txtNumero.Focus();
        }
        private void btnContar_Click(object sender, EventArgs e)
        {
           double numero = Convert.ToDouble(txtNumero.Text);
            Contar(numero);
            LimparCampo();
        }



    }
}
