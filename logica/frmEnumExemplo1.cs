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
    public partial class frmEnumExemplo1: Form
    {
        public frmEnumExemplo1()
        {
            InitializeComponent();
        }

        private enum TipoCalculo
        {
            Aumento,
            Desconto
        }

        private double CalcularValor(double valor, double porcentagem, TipoCalculo tipoCalculo)
        {
            double resultado = 0;
            Calculo objCalculo = new Calculo();

            switch (tipoCalculo)
            {
                case TipoCalculo.Aumento:
                    resultado = objCalculo.CalcularAumentoPorcentagem(valor, porcentagem); //resultado = valor + (valor * porcentagem) / 100;
                    break;

                case TipoCalculo.Desconto:
                    resultado = objCalculo.CalcularDescontoPorcentagem(valor, porcentagem); //valor - (valor * porcentagem) / 100;
                    break;
            }
            return resultado;
        }

        private bool ValidarCampos()
        {
            bool flag = true;

            if(txtValor.Text.Trim() == string.Empty || txtPorcentagem.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Prencha todos os campos!", "Erro");
                flag = false;
            }

            if(!rbAumento.Checked && !rbDesconto.Checked)
            {
                MessageBox.Show("Selecione uma opção", "Erro");
                flag = false;
            }
            return flag;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MostrarResultado();
            }
            
        }

        private void MostrarResultado()
        {
            try
            {
                double valor, porcentagem, resultadoFinal = 0;

                valor = Convert.ToDouble(txtValor.Text);
                porcentagem = Convert.ToDouble(txtPorcentagem.Text);

                if (rbAumento.Checked)
                {
                    resultadoFinal = CalcularValor(valor, porcentagem, TipoCalculo.Aumento);
                }
                else if (rbDesconto.Checked)
                {
                    resultadoFinal = CalcularValor(valor, porcentagem, TipoCalculo.Desconto);
                }

                lblResultado.Text = resultadoFinal.ToString("c2");
            }
            catch
            {
                MessageBox.Show("preencher somente números", "erro");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            txtPorcentagem.Clear();
            rbAumento.Checked = false;
            rbDesconto.Checked = false;
            lblResultado.Text = string.Empty;
        }
    }
}
