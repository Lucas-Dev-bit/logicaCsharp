using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logica
{
    public partial class frmExemploOperador1: Form
    {
        public frmExemploOperador1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if(txtN1.Text.Trim() == string.Empty || txtN2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Prencha o campos necessários", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int numero1, numero2;

                try
                {
                    numero1 = Convert.ToInt32(txtN1.Text);
                    numero2 = Convert.ToInt32(txtN2.Text);

                    if(numero1 > numero2)
                    {
                        MessageBox.Show("O número maior é: " + numero1, "Resultado");
                    }
                    else if(numero2 > numero1)
                    {
                        MessageBox.Show("O número maior é: " + numero2, "Resultado");
                    }
                    else if(numero1 == numero2)
                    {
                        MessageBox.Show("Os números são iguais!!", "Resultado");
                    }

                }
                catch
                {
                    MessageBox.Show("Favor digitar somente númros!");
                }
            }
        }
    }                                                                               
}
