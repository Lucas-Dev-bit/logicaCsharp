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
    public partial class frmLinq4: Form
    {
        public frmLinq4()
        {
            InitializeComponent();
        }

        #region LISTAS

        List<double> lstSaoPaulo = new List<double>();
        List<double> lstRioDeJaneiro = new List<double>();
        List<double> lstCuritiba = new List<double>();

        #endregion

        #region ENUM VALIDAÇÕES | CIDADES | OPÇÕES
        private enum Validacao
        {
            Adicionar,
            Pesquisa
        }

        private enum Cidades
        {
            SãoPaulo,
            RioDeJaneiro,
            Curitiba
        }

        private enum Opcao
        {
            Acima,
            Igual,
            Abaixo
        }
        #endregion | 

        #region VALIDAÇOES
        private bool ValidarCampos(Validacao validacao)
        {
            bool flag = true;

            switch (validacao)
            {
                case Validacao.Adicionar:
                    if (txtTemperatura.Text.Trim() == string.Empty
                        || cbCidade.SelectedIndex == -1)
                    {
                        flag = false;
                    }
                    break;
                case Validacao.Pesquisa:
                    if(txtTemperaturaPesquisa.Text.Trim() == string.Empty 
                        || cbCidadePesquisa.SelectedIndex == -1
                        || cbOpcaoPesquisa.SelectedIndex == -1)
                    {
                        flag = false;
                    }
                    break;

            }
            if (!flag)
            {
                MessageBox.Show("Preencher os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return flag;
        }
        #endregion

        #region ADICIONAR INFORMAÇÕES
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(Validacao.Adicionar))
            {
                int FiltroCidade = cbCidade.SelectedIndex;
                double temperatura;

                try
                {
                    temperatura = Convert.ToDouble(txtTemperatura.Text);
                    switch (FiltroCidade)
                    {
                        case 0: // SAO PAULO
                            AdicionarCidade(Cidades.SãoPaulo, temperatura);
                            CarregarCidade(Cidades.SãoPaulo);
                            LimparCampos();
                            break;
                        case 1: // RIO DE JANEIRO
                            AdicionarCidade(Cidades.RioDeJaneiro, temperatura);
                            CarregarCidade(Cidades.RioDeJaneiro);
                            LimparCampos();
                            break;
                        case 2: // CURITIBA
                            AdicionarCidade(Cidades.Curitiba, temperatura);
                            CarregarCidade(Cidades.Curitiba);
                            LimparCampos();
                            break;

                    }

                }
                catch
                {
                    MessageBox.Show("Preencher os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void AdicionarCidade(Cidades cidade, double temperatura)
        {
            switch (cidade)
            {
                case Cidades.SãoPaulo:
                    lstSaoPaulo.Add(temperatura);
                    break;
                case Cidades.RioDeJaneiro:
                    lstRioDeJaneiro.Add(temperatura);
                    break;
                case Cidades.Curitiba:
                    lstCuritiba.Add(temperatura);
                    break;
            }
        }
        private void CarregarCidade(Cidades cidade)
        {
            switch (cidade)
            {
                case Cidades.SãoPaulo:
                    listBoxSaoPaulo.DataSource = null;
                    listBoxSaoPaulo.DataSource = lstSaoPaulo;
                    break;
                case Cidades.RioDeJaneiro:
                    listBoxRio.DataSource = null;
                    listBoxRio.DataSource = lstRioDeJaneiro;
                    break;
                case Cidades.Curitiba:
                    listBoxCuritiba.DataSource = null;
                    listBoxCuritiba.DataSource = lstCuritiba;
                    break;
            }
        }
        private void LimparCampos()
        {
            txtTemperatura.Clear();
            txtTemperatura.Focus();
        }

        #endregion

        #region PESQUISA
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           if(ValidarCampos(Validacao.Pesquisa))
            {
                double temperatura;
                int FiltroCidade = cbCidadePesquisa.SelectedIndex;
                int FiltroOpcao = cbOpcaoPesquisa.SelectedIndex;

                try
                {
                    temperatura = Convert.ToDouble(txtTemperaturaPesquisa.Text);
                    switch (FiltroCidade) 
                    {
                        case 0: // SÃO PAULO
                            switch(FiltroOpcao)
                            {
                                case 0: //ACIMA
                                    PesquisarCidadeSaoPaulo(Opcao.Acima, temperatura);
                                    break;
                                case 1: //IGUAL
                                    PesquisarCidadeSaoPaulo(Opcao.Igual, temperatura);
                                    break;
                                case 2: // ABAIXO
                                    PesquisarCidadeSaoPaulo(Opcao.Abaixo, temperatura);
                                    break;
                            }
                        break;

                        case 1: // RIO DE JANEIRO
                            switch (FiltroOpcao)
                            {
                                case 0: // ACIMA
                                    PesquisarCidadeRio(Opcao.Acima, temperatura);
                                        break;
                                case 1: // IGUAL
                                    PesquisarCidadeRio(Opcao.Igual, temperatura);
                                    break;
                                case 2:// ABAIXO
                                    PesquisarCidadeRio(Opcao.Abaixo, temperatura);
                                    break;
                            }
                        break;

                        case 2: // CURITIBA
                            switch(FiltroOpcao)
                            {
                                case 0: // ACIMA
                                    PesquisarCidadeCuritiba(Opcao.Acima, temperatura);
                                    break;
                                case 1: // IGUAL
                                    PesquisarCidadeCuritiba(Opcao.Igual, temperatura);
                                    break;
                                case 2:// ABAIXO
                                    PesquisarCidadeCuritiba(Opcao.Abaixo, temperatura);
                                    break;
                            }
                            break;
                    }


                }
                catch
                {
                    MessageBox.Show("Preencher todos os campos corretamente", "Erro");
                }
            }
            
        }

        private void PesquisarCidadeSaoPaulo(Opcao opcao, double temperatura)
        {
            listBoxSaoPaulo.DataSource = null;
            switch (opcao) 
            {
                case Opcao.Acima:
                    listBoxSaoPaulo.DataSource = lstSaoPaulo.Where(item => item > temperatura).ToList();
                    break;
                case Opcao.Igual:
                    listBoxSaoPaulo.DataSource = lstSaoPaulo.Where(item => item == temperatura).ToList();
                    break;
                case Opcao.Abaixo:
                    listBoxSaoPaulo.DataSource = lstSaoPaulo.Where(item => item < temperatura).ToList();
                    break;
            }

        }

        private void PesquisarCidadeRio(Opcao opcao, double temperatura)
        {
            listBoxRio.DataSource = null;
            switch (opcao) 
            {
                case Opcao.Acima:
                    listBoxRio.DataSource = lstRioDeJaneiro.Where(item => item > temperatura).ToList();
                    break;
                case Opcao.Igual:
                    listBoxRio.DataSource = lstRioDeJaneiro.Where(item => item == temperatura).ToList();
                    break;
                case Opcao.Abaixo:
                    listBoxRio.DataSource = lstRioDeJaneiro.Where(item => item < temperatura).ToList();
                    break;
            }

        }

        private void PesquisarCidadeCuritiba(Opcao opcao, double temperatura)
        {
            listBoxCuritiba.DataSource = null;
            switch (opcao)
            {
                case Opcao.Acima:
                    listBoxCuritiba.DataSource = lstCuritiba.Where(item => item > temperatura).ToList();
                    break;
                case Opcao.Igual:
                    listBoxCuritiba.DataSource = lstCuritiba.Where(item => item == temperatura).ToList();
                    break;
                case Opcao.Abaixo:
                    listBoxCuritiba.DataSource = lstCuritiba.Where(item => item < temperatura).ToList();
                    break;
            }

        }
        #endregion


    }
}
