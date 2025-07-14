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
    public partial class frmListGenerics5 : Form
    {
        public frmListGenerics5()
        {
            InitializeComponent();
        }

        List<string> lstMes = new List<string>();
        List<double> lstValorGanhoBruto = new List<double>();
        List<double> lstValorLiquido = new List<double>();
        List<double> lstPesquisa = new List<double>();

        private enum Validacoes
        {

            FiltroTextos,
            FiltroPesquisa

        }

        private enum Filtros
        {
            Maior,
            Igual,
            Menor
        }

        private enum Valores
        {
            ValorBruto,
            ValorLiquido
        }


        private bool ValidarCampos(Validacoes validacoes)
        {
            bool flag = true;

            switch (validacoes)
            {
                case Validacoes.FiltroTextos:
                    if (txtMes.Text.Trim() == string.Empty ||
                        txtValor.Text.Trim() == string.Empty ||
                        txtPorcentagem.Text.Trim() == string.Empty)
                    {
                        flag = false;
                    }
                    break;
                case Validacoes.FiltroPesquisa:
                    if (txtValorPesquisa.Text.Trim() == string.Empty ||
                        cbValor.SelectedIndex == -1)
                    //cbfiltros.SelectedIndex == -1)
                    {
                        flag = false;
                    }
                    break;

            }
            if (!flag)
            {
                MessageBox.Show("Preencher todos os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flag;
        }

        private void CarregarMes()
        {
            listBoxMes.DataSource = null;
            listBoxMes.DataSource = lstMes;
        }
        private void CarregarValorGanhoBruto()
        {
            listBoxValorBruto.DataSource = null;
            listBoxValorBruto.DataSource = lstValorGanhoBruto;
        }
        private void CarregarValorLiquido()
        {
            listBoxLiquido.DataSource = null;
            listBoxLiquido.DataSource = lstValorLiquido;
        }

        private void AdicionarMes(string mes)
        {
            lstMes.Add(mes);
        }
        private void AdicionarValorGanhoBruto(double valorBruto)
        {
            lstValorGanhoBruto.Add(valorBruto);
        }
        private void AdicionarValorLiquido(double valorLiquido)
        {
            lstValorLiquido.Add(valorLiquido);
        }

        private double CalcularValorLiquido(double valorBruto, double porcentagem)
        {
            double valorLiquido;
            valorLiquido = valorBruto - (valorBruto * porcentagem) / 100;
            return valorLiquido;
        }

        private void LimparCampos()
        {
            txtMes.Clear();
            txtValor.Clear();
            txtPorcentagem.Clear();
            txtMes.Focus();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(Validacoes.FiltroTextos))
            {
                string mes = txtMes.Text;
                double valorGanho = Convert.ToDouble(txtValor.Text);
                double porcentagem = Convert.ToDouble(txtPorcentagem.Text);
                double valorLiquido;
                valorLiquido = CalcularValorLiquido(valorGanho, porcentagem);
                AdicionarMes(mes);
                CarregarMes();
                AdicionarValorGanhoBruto(valorGanho);
                CarregarValorGanhoBruto();
                AdicionarValorLiquido(valorLiquido);
                CarregarValorLiquido();
                LimparCampos();

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(Validacoes.FiltroPesquisa))
            {
                double valor;
                int filtroLista = cbValor.SelectedIndex;
                int filtroComparacao = cbfiltros.SelectedIndex;

                try
                {
                    valor = Convert.ToDouble(txtValorPesquisa.Text);

                    switch (filtroLista)
                    {
                        case 0://Valor Bruto

                            switch (filtroComparacao)
                            {
                                case 0:
                                    PesquisarValores(valor, Valores.ValorBruto, Filtros.Maior);
                                    break;
                                case 1:
                                    PesquisarValores(valor, Valores.ValorBruto, Filtros.Igual);
                                    break;
                                case 2:
                                    PesquisarValores(valor, Valores.ValorBruto, Filtros.Menor);
                                    break;
                            }
                            break;

                        case 1://Valor Liquido
                            switch (filtroComparacao)
                            {
                                case 0:
                                    PesquisarValores(valor, Valores.ValorLiquido, Filtros.Maior);
                                    break;
                                case 1:
                                    PesquisarValores(valor, Valores.ValorLiquido, Filtros.Igual);
                                    break;
                                case 2:
                                    PesquisarValores(valor, Valores.ValorLiquido, Filtros.Menor);
                                    break;
                            }

                            break;
                    }

                }
                catch
                {
                    MessageBox.Show("Erro ");
                }
            }

        }

        private void AdicionarResultadoPesquisa(double valor, int posicao)
        {
           
            lstPesquisa.Add(valor);
        }

        private void PesquisarValores(double valor, Valores tipo, Filtros comparacao)
        {
           
            switch (tipo)
            {

                case Valores.ValorBruto:
                    for (int i = 0; i < lstValorGanhoBruto.Count; i++)
                    {
                        switch (comparacao)
                        {
                            
                            case Filtros.Maior:
                                if (lstValorGanhoBruto[i] > valor)
                                {
                                    CarregarPesquisa(Valores.ValorBruto);
                                    AdicionarResultadoPesquisa(lstValorGanhoBruto[i], i);
                                    
                                }
                                break;

                            case Filtros.Igual:

                                if (lstValorGanhoBruto[i] == valor)
                                {
                                    CarregarPesquisa(Valores.ValorBruto);
                                    AdicionarResultadoPesquisa(lstValorGanhoBruto[i], i);

                                }
                                break;

                            case Filtros.Menor:
                                if (lstValorGanhoBruto[i] < valor)
                                {
                                    CarregarPesquisa(Valores.ValorBruto);
                                    AdicionarResultadoPesquisa(lstValorGanhoBruto[i], i);
                                   
                                }
                                break;
                        }

                    }
                    break;

                case Valores.ValorLiquido:

                    for (int i = 0; i < lstValorLiquido.Count; i++)
                    {
                        switch (comparacao) {

                            case Filtros.Igual:
                                if (lstValorLiquido[i] == valor)
                                {
                                    CarregarPesquisa(Valores.ValorLiquido);
                                    AdicionarResultadoPesquisa(lstValorLiquido[i], i);
                                    
                                }
                                break;
                            case Filtros.Maior:
                                if (lstValorLiquido[i] > valor)
                                {
                                    CarregarPesquisa(Valores.ValorLiquido);
                                    AdicionarResultadoPesquisa(lstValorLiquido[i], i);
                                    
                                }

                                break;

                            case Filtros.Menor:
                                if (lstValorLiquido[i] < valor)
                                {
                                    CarregarPesquisa(Valores.ValorLiquido);
                                    AdicionarResultadoPesquisa(lstValorLiquido[i], i);
                                    
                                }

                                break;
                        }

                    }
                    break;
            }
        }

        private void CarregarPesquisa(Valores loading)
        {
            switch (loading)
            {
                case Valores.ValorBruto:
                    listBoxResultados.DataSource = null;
                    listBoxResultados.DataSource = lstPesquisa;
                    lstPesquisa.Clear();
                    
                    break;
                case Valores.ValorLiquido:
                    listBoxResultados.DataSource = null;
                    listBoxResultados.DataSource = lstPesquisa;
                    lstPesquisa.Clear();
                    break;
            }
        }


    }
}
