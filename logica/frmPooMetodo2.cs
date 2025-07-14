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
    public partial class frmPooMetodo2 : Form
    {
        public frmPooMetodo2()
        {
            InitializeComponent();
        }
        private enum Tipo
        {
            Desconto,
            Aumento
        }

        List<string> lstNomeFuncionario = new List<string>();
        List<double> lstSalarioLiquido = new List<double>();
        List<string> lstClassificacao = new List<string>();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                double salario = 0, porcentagem = 0, salarioLiquido = 0;
                string nome, classificacao;
                CalculosSalario objcalculoSalario = new CalculosSalario();

                try
                {
                    salario = Convert.ToDouble(txtSalario.Text.Trim());
                    porcentagem = Convert.ToDouble(txtPorcentagem.Text.Trim());
                    nome = txtNomeFuncionario.Text.Trim();
                    classificacao = objcalculoSalario.Classificacao(salario);


                    switch (cbPorcentagem.SelectedIndex)
                    {
                        case (int)Tipo.Desconto:
                            salarioLiquido = objcalculoSalario.CalcularPorcentagemDesconto(salario, porcentagem);
                            break;

                        case (int)Tipo.Aumento:
                            salarioLiquido = objcalculoSalario.CalcularPorcentagemAumento(salario, porcentagem);
                            break;
                    }

                    Cadastrar(nome, salarioLiquido, classificacao);
                    CarregarListas();
                    LimparCampos();
                }
                catch
                {
                    MessageBox.Show("Preencha todos os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }
        public void Cadastrar(string nome, double salarioLiquido, string classificacao)
        {
            lstNomeFuncionario.Add(nome);
            lstSalarioLiquido.Add(salarioLiquido);
            lstClassificacao.Add(classificacao);
        }

        private void LimparCampos()
        {
            txtNomeFuncionario.Clear();
            txtPorcentagem.Clear();
            txtSalario.Clear();
            txtNomeFuncionario.Focus();
        }
        public bool ValidarCampos()
        {
            bool flag = true;

            if (txtNomeFuncionario.Text.Trim() == string.Empty
                || txtSalario.Text.Trim() == string.Empty
                || cbPorcentagem.SelectedIndex == -1)
            {
                flag = false;
                MessageBox.Show("Preencha todos os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flag;
        }

        public void CarregarListas()
        {
            listBoxFuncionario.DataSource = null;
            listBoxFuncionario.DataSource = lstNomeFuncionario;
            listBoxSalario.DataSource = null;
            listBoxSalario.DataSource = lstSalarioLiquido;
            listBoxClassificacao.DataSource = null;
            listBoxClassificacao.DataSource = lstClassificacao;
        }
    }
}
