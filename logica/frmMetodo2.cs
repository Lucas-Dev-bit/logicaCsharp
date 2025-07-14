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
    public partial class frmMetodo2: Form
    {
        public frmMetodo2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())

                try
                {
                    double valor, tamanho, resultado;

                    valor = Convert.ToDouble(txtValor.Text);
                    tamanho = Convert.ToDouble(txtTamanho.Text);
                    resultado = Convert.ToDouble(lblResultado.Text);

                    ValorFinal(valor, tamanho);
                    ExibirResultado(resultado);
                   
                }
                catch
                {
                    MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
                   
                
        }

        private bool ValidarCampos()
        {
            bool flag = true;

            if(txtTamanho.Text.Trim() == string.Empty || txtValor.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }

            return flag;
        }

        private void ValorFinal(double valor, double tamanho)
        {
            double resultadoFinal;

            resultadoFinal = tamanho * valor;

        }

        private void ExibirResultado(double resultado)
        {
            lblResultado.Text = resultado.ToString("c2");
        }
    }
}
