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
    public partial class frmLinqConsulta: Form
    {
        public frmLinqConsulta()
        {
            InitializeComponent();
        }

        private enum Validacao
        {
            Adicao,
            Filtro
        }

        private enum Filtro {
            Maior,
            Menor,
            Igual
        }

        List<double> lstSalariosFinal = new List<double>();

        private void CarregarSalarios()
        {
            listBoxSalarios.DataSource = null;
            listBoxSalarios.DataSource = lstSalariosFinal;
        }

        private void AdicionarSalarioFinal(double salarioFinal)
        {
            lstSalariosFinal.Add(salarioFinal);
        }

        private double CalcularSalario(double salario, double porcentagem)
        {
            double salarioFinal;
            salarioFinal = salario + (salario * porcentagem) / 100;
            return salarioFinal;
        }

        private bool ValidarCampos(Validacao validacao)
        {
            bool flag = true;
            switch (validacao)
            {
                case Validacao.Adicao:
                    if(txtPorcentagem.Text.Trim() == string.Empty ||
                        txtValor.Text.Trim() == string.Empty)
                    {
                        flag = false;
                    }
                    break;
                case Validacao.Filtro:
                    if(txtValorPesquisa.Text.Trim() == string.Empty ||
                        cbFiltro.SelectedIndex == -1)
                    {
                        flag = false;
                    }
                    break;
            }
            if (!flag)
            {
                MessageBox.Show("Preencher corretamente todos os campos com valores númericos", "erro");
            }
            return flag;
        }

        private void LimparCampos()
        {
            txtValor.Clear();
            txtPorcentagem.Clear();
            txtValor.Focus();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(Validacao.Adicao))
            {
                double valor, porcentagem, salarioFinal;
                try
                {
                    valor = Convert.ToDouble(txtValor.Text);
                    porcentagem = Convert.ToDouble(txtPorcentagem.Text);
                    salarioFinal = CalcularSalario(valor, porcentagem);
                    CarregarSalarios();
                    AdicionarSalarioFinal(salarioFinal);
                    LimparCampos();


                }
                catch
                {
                    MessageBox.Show("Preencher todos os campos corretamente", "erro");
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(Validacao.Filtro))
            {
                double valorPesquisa;

                try{

                    valorPesquisa = Convert.ToDouble(txtValorPesquisa.Text);
                    switch (cbFiltro.SelectedIndex)
                    {
                        case 0:
                            PesquisarLinqConsulta(Filtro.Maior, valorPesquisa);
                            break;
                        case 1:
                            PesquisarLinqConsulta(Filtro.Menor, valorPesquisa);
                            break;
                        case 2:
                            PesquisarLinqConsulta(Filtro.Igual, valorPesquisa);
                            MessageBox.Show("Nenhum valor encontrado");
                            break;
                    }

                }
                catch
                {
                    MessageBox.Show("asdsadsada");
                }

            }

        }

        // LINQ - EXEMPLO COM SINTAXE DE CONSULTA
        private void PesquisarLinqConsulta(Filtro filtro, double valorPesquisa)
        {
            listBoxSalarios.DataSource = null;

            switch (filtro)
            {
                case Filtro.Maior:
                    listBoxSalarios.DataSource = (from salario in lstSalariosFinal
                                                  where salario > valorPesquisa
                                                  select salario).ToList();
                    break;

                case Filtro.Menor:
                    listBoxSalarios.DataSource = (from salario in lstSalariosFinal
                                                  where salario < valorPesquisa
                                                  select salario).ToList();
                    break;

                case Filtro.Igual:
                    listBoxSalarios.DataSource = (from salario in lstSalariosFinal
                                                  where salario == valorPesquisa
                                                  select salario).ToList();
                    break;
            }
        }


        // LINQ - EXEMPLO COM SINTAXE DE METODO
        private void PesquisaLinqMetodo(Filtro filtro, double valorPesquisa)
        {
            listBoxSalarios.DataSource = null;

            switch (filtro)
            {
                case Filtro.Maior:
                    listBoxSalarios.DataSource = lstSalariosFinal.Where(salario => salario > valorPesquisa).ToList();
                    break;
                case Filtro.Menor:
                    listBoxSalarios.DataSource = lstSalariosFinal.Where(salario => salario < valorPesquisa).ToList();
                    break;
                case Filtro.Igual:
                    listBoxSalarios.DataSource = lstSalariosFinal.Where(salario => salario == valorPesquisa).ToList();
                    break;
            }

        }
    }
}
