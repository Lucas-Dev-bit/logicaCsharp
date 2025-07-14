using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica.Classes;

namespace logica
{
    public partial class frmPooMetodo1 : Form
    {
        public frmPooMetodo1()
        {
            InitializeComponent();
        }
      

        List<string> lstModelo = new List<string>();
        List<double> lstConsumoMedio = new List<double>();
        List<string> lstClassificacao = new List<string>();


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                double distancia, combustivel, consumoMedio;
                string modelo, classificacao;
                CalculoVeiculo objcalculoVeiculo = new CalculoVeiculo();

                try
                {
                    modelo = txtModelo.Text.Trim();
                    distancia = Convert.ToDouble(txtDistancia.Text);
                    combustivel = Convert.ToDouble(txtCombustivel.Text);
                    consumoMedio = objcalculoVeiculo.CalcularConsumoMedio(distancia, combustivel);
                    classificacao = objcalculoVeiculo.VerClassificacao(consumoMedio);


                    Cadastrar(modelo, consumoMedio, classificacao);
                    CarregarListas();
                    LimparCampos();

                }
                catch
                {
                    MessageBox.Show("Digite somente números");
                }




            }
        }
        private void Cadastrar(string nomeModelo, double consumoMedio, string classificacao )
        {
            lstModelo.Add(nomeModelo);
            lstConsumoMedio.Add(consumoMedio);
            lstClassificacao.Add(classificacao);

        }
        private bool ValidarCampos()
        {
            bool flag = true;

            if (txtDistancia.Text.Trim() == string.Empty
                || txtModelo.Text.Trim() == string.Empty
                || txtCombustivel.Text.Trim() == string.Empty)
            {
                flag = false;
                MessageBox.Show("Preencha todos os campos corretamente", "Erro");

            }

            return flag;
        }

        private void LimparCampos()
        {
            txtCombustivel.Clear();
            txtDistancia.Clear();
            txtModelo.Clear();
        }

        private void CarregarListas()
        {

            listBoxModelo.DataSource = null;
            listBoxModelo.DataSource = lstModelo;

            listBoxConsumo.DataSource = null;
            listBoxConsumo.DataSource = lstConsumoMedio;

            listBoxClassificacao.DataSource = null;
            listBoxClassificacao.DataSource = lstClassificacao;

        }
    }



}
