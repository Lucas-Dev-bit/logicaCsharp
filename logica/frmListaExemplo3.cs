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
    public partial class frmListaExemplo3: Form
    {
        public frmListaExemplo3()
        {
            InitializeComponent();
        }

        private enum Validacao {
        
            Adicao,
            Filtro
        }

        private enum LimparCampos
        {
            Adicao,
            Filtro
        }

        private enum CarregarSalariosResultados
        {
            CarregarSalarios,
            CarregarResultados
        }

        private enum Filtro
        {
            Maior,
            Menor
        }
        List<double> lstSalarios = new List<double>();
        List<string> lstResultadoFinal = new List<string>();
        List<string> lstNomes = new List<string>();

        private void Limpar(LimparCampos limpar)
        {
           switch (limpar)
            {
                case LimparCampos.Adicao:
                    txtNome.Clear();
                    txtValor.Clear();
                    txtPorcentagem.Clear();
                    txtValor.Focus();
                    txtPorcentagem.Focus();
                    break;
                case LimparCampos.Filtro:
                    txtValorPesquisar.Clear();
                    txtValorPesquisar.Focus();
                    cbFiltro.Text = null;
                    break;
            }
            
        }

        private void CarregarNomes()
        {
            listNomeBox.DataSource = null;
            listNomeBox.DataSource = lstNomes;
        }

        private void AdicionarNome(string nome)
        {
            lstNomes.Add(nome);
        }
        private void CarregarSalarios(CarregarSalariosResultados loading)
        {
            switch (loading)
            {
                case CarregarSalariosResultados.CarregarSalarios:
                    listSalarioBox.DataSource = null;
                    listSalarioBox.DataSource = lstSalarios;
                    break;
                case CarregarSalariosResultados.CarregarResultados:

                    if(lstResultadoFinal.Count == 0)
                    {
                        MessageBox.Show("Não foi encontrado nenhum valor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    listResultadoBox.DataSource = null;
                    listResultadoBox.DataSource = lstResultadoFinal;
                    lstResultadoFinal.Clear();
                    break;
            }
           
        }
        private void AdicionarSalarioFinal(double salarioFinal)
        {
            lstSalarios.Add(salarioFinal);
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
                    if (txtPorcentagem.Text.Trim() == string.Empty ||
                       txtValor.Text.Trim() == string.Empty || 
                       txtNome.Text.Trim() == string.Empty)
                    {
                        flag = false;
                    }
                    break;

                case Validacao.Filtro:
                    if (txtValorPesquisar.Text.Trim() == string.Empty ||
                        cbFiltro.SelectedIndex == -1)
                    {
                        flag = false;
                    }
                    break;             
            }
            if (!flag)
            {
                MessageBox.Show("Preencher todos os campos corretamente");
            }
            return flag;
        }        
        private void AdicionarResultadoLista(int posicao, double valorEncontrado, string nome)
        {
            lstResultadoFinal.Add("Valor encontrado: " + valorEncontrado + " na posição " + posicao + " - Nome: " + nome);
        }
            
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos(Validacao.Adicao))
                {
                    string nome = txtNome.Text;
                    double salario = Convert.ToInt32(txtValor.Text);
                    double porcentagem = Convert.ToInt32(txtPorcentagem.Text);
                    double salarioFinal;
                    salarioFinal = CalcularSalario(salario, porcentagem);
                    AdicionarSalarioFinal(salarioFinal);
                    AdicionarNome(nome);
                    CarregarSalarios(CarregarSalariosResultados.CarregarSalarios);
                    CarregarNomes();
                    Limpar(LimparCampos.Adicao);

                }

            }
            catch
            {
                MessageBox.Show("Digitar somente valores numéricos!");
            }
            
            
           
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(Validacao.Filtro))
            {
                double valorPesquisa;
                try
                {
                    valorPesquisa = Convert.ToDouble(txtValorPesquisar.Text);

                    if(cbFiltro.SelectedIndex == 0)
                    {
                        Pesquisar(Filtro.Maior, valorPesquisa);
                    }
                    else
                    {
                        Pesquisar(Filtro.Menor, valorPesquisa);
                    }

                    
                    CarregarSalarios(CarregarSalariosResultados.CarregarResultados);
                    Limpar(LimparCampos.Filtro);
                }
                catch
                {
                    MessageBox.Show("Preencher o valor corretamente");
                }
            }
            
            
            
        }

        private void Pesquisar(Filtro filtro, double valorPesquisa)
        {
            switch(filtro)
            {
                case Filtro.Maior:
                    for (int i = 0; i < lstSalarios.Count; i++)
                    {
                        if (lstSalarios[i] > valorPesquisa)
                        {
                            AdicionarResultadoLista(i, lstSalarios[i], lstNomes[i]);
                        }
                    }
                    break;

                case Filtro.Menor:
                    for (int i = 0; i < lstSalarios.Count; i++)
                    {
                        if (lstSalarios[i] < valorPesquisa)
                        {
                            AdicionarResultadoLista(i, lstSalarios[i], lstNomes[i]);
                        }
                    }
                    break;
                    
            }
            
        }
    }
}
