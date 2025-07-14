using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica.Classes;


namespace logica
{
    public partial class frmMetodoReaproveitamento: Form
    {
       
        public frmMetodoReaproveitamento()
        {
            InitializeComponent();
        }

        private void btbCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string produto1, produto2;
                double valor1, valor2, porcentagem1, porcentagem2, 
                    valorfinal1, valorfinal2, valorfinalgeral;

                try
                {
                    produto1 = txtProduto1.Text;
                    produto2 = txtProduto2.Text;

                    valor1 = Convert.ToDouble(txtValor1.Text);
                    valor2 = Convert.ToDouble(txtValor2.Text);

                    // Instancia o objeto CALCULO
                    Calculo objCalculo = new Calculo();

                    porcentagem1 = Convert.ToDouble(txtDesc1.Text);
                    porcentagem2 = Convert.ToDouble(txtDesc2.Text);

                    valorfinal1 = objCalculo.CalcularDescontoPorcentagem(valor1, porcentagem1);   //objCalculo.CalcularDescontoPorcentagem(valor1, porcentagem1);
                    valorfinal2 = objCalculo.CalcularDescontoPorcentagem(valor2, porcentagem2); //CalcularValorFinalDesconto(valor2, porcentagem2);

                    valorfinalgeral = objCalculo.CalcularValorFinalGeral(valorfinal1, valorfinal2);

                    MostrarResultado(valorfinal1, valor2, valorfinalgeral);
                }
                catch
                {
                    MessageBox.Show("Preencha os campos corretamente", "Erro");
                }
            }
        }

        private void MostrarResultado(double valorFinal1, double valorFinal2, double valorFinalGeral)
        {
            lblValorFinalGeral.Text = valorFinalGeral.ToString("c");
            lblValorProduto1.Text = valorFinal1.ToString("c");
            lblValorProduto2.Text = valorFinal2.ToString("c");
        }

        private bool ValidarCampos()
        {
            bool flag = true;

            if(txtProduto1.Text.Trim() == string.Empty
                || txtProduto2.Text.Trim() == string.Empty
                || txtDesc1.Text.Trim() == string.Empty
                || txtDesc2.Text.Trim() == string.Empty
                || txtValor1.Text.Trim() == string.Empty
                || txtValor2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher todos os campos.", "Erro");
                flag = false;
            }

            return flag;
        }

        
    }
}
