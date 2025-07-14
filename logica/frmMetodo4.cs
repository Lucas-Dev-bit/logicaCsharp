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
    public partial class frmMetodo4 : Form
    {
        public frmMetodo4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {

                    double valorComJuros, totalComJuros, juros;

                    valorComJuros = Convert.ToDouble(txtValor.Text);
                    totalComJuros = Convert.ToDouble(txtTotalCompra.Text);
                    //parcela = Convert.ToDouble(txtParcela.Text);
                    juros = Convert.ToDouble(txtJuros.Text);

                    valorComJuros = CalcularValorComJuros(valorComJuros, juros);

                    lblResultado.Text = ExibirResultado(valorComJuros);
                    LimparCampos();
                }
                catch
                {
                    MessageBox.Show("Preencha todos os campos corretamente");
                }
            }
        }

        private bool ValidarCampos()
        {
            bool flag = true;

            if (txtNome.Text.Trim() == string.Empty
                || txtValor.Text.Trim() == string.Empty
                || txtTotalCompra.Text.Trim() == string.Empty
                || txtParcela.Text.Trim() == string.Empty
                || txtJuros.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos corretamente");
                flag = false;
            }
            return flag;

        }

        private double CalcularValorComJuros(double valor, double juros)
        {
            double resultadoFinal;

            resultadoFinal = valor * (1 + juros / 100);

            return resultadoFinal;
        }

        private double CalcularTotalComJuros(double valor, double juros)
        {
            double resultadoFinal;

            resultadoFinal = valor * (1 + juros / 100);

            return resultadoFinal;
        }

        private string ExibirResultado(double resultado)
        {
            string classificacao = "";

            if (resultado < 2001)
            {
                classificacao = " TOTAL DA COMPRA É " + resultado.ToString("c2") + " ABAIXO DE R$ 2.000,00";
            }
            else if (resultado >= 2001 && resultado < 3000)
            {
                classificacao = " TOTAL DA COMPRA ESTÁ ENTRE R$ 2.000,00 " + resultado.ToString("c2") + " R$ 3.000,00";
            }
            else
            {
                classificacao = " TOTAL DA COMPRA ESTÁ ACIMA DE R$ 3000 " + resultado.ToString("c2");
            }
            return classificacao;

        }


        private void LimparCampos()
        {
            txtNome.Clear();
            txtValor.Clear();
            txtTotalCompra.Clear();
            txtParcela.Clear();
            txtJuros.Clear();
        }
    }
}
