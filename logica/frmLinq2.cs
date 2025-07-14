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
    public partial class frmLinq2: Form
    {
        public frmLinq2()
        {
            InitializeComponent();
        }

        List<int> lstFiccao = new List<int>();
        List<int> lstNaoFiccao = new List<int>();
        List<int> lstRomance = new List<int>();

        private enum FiltroGenero
        {
           Ficcao,
           NaoFiccao,
           Romance

        }
        private enum FiltroComparacao
        {
           Acima,
           Igual,
           Abaixo
        }
        private enum FiltroValidacao
        {
            Adicionar,
            FiltroPesquisa
        }

        #region ADICIONAR GENEROS E PÁGINAS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(FiltroValidacao.Adicionar))
            {
                int numero;
                try
                {
                    numero = Convert.ToInt32(txtNumeroPaginas.Text);
                    switch (cbGenero.SelectedIndex)
                    {
                        case 0:
                            AdicionarGeneros(FiltroGenero.Ficcao, numero);
                            CarregarGeneros(FiltroGenero.Ficcao);
                            LimparCampos();
                            break;
                        case 1:
                            AdicionarGeneros(FiltroGenero.NaoFiccao, numero);
                            CarregarGeneros(FiltroGenero.NaoFiccao);
                            LimparCampos();
                            break;
                        case 2:
                            AdicionarGeneros(FiltroGenero.Romance, numero);
                            CarregarGeneros(FiltroGenero.Romance);
                            LimparCampos();
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Preencher todos os campos corretamente");
                }
            }
        }
        private bool ValidarCampos(FiltroValidacao validacao)
        {
            bool flag = true;

            try
            {

                switch (validacao)
                {
                    case FiltroValidacao.Adicionar:
                        if (txtNumeroPaginas.Text.Trim() == string.Empty ||
                            cbGenero.SelectedIndex == -1)
                        {
                            flag = false;

                        }
                        break;
                    case FiltroValidacao.FiltroPesquisa:
                        if (cbGeneroPesquisa.SelectedIndex == -1 ||
                            cbOpcao.SelectedIndex == -1 ||
                            txtNumeroPesquisa.Text.Trim() == string.Empty)
                        {
                            flag = false;

                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Preencher todos os campos corretamente", "erro");
            }
            if (!flag)
            {
                MessageBox.Show("Preencher todos os campos corretamente", "erro");
            }

            return flag;
        }
        private void AdicionarGeneros(FiltroGenero genero, int numero)
        {
            switch (genero)
            {
                case FiltroGenero.Ficcao:
                    lstFiccao.Add(numero);
                    break;
                case FiltroGenero.NaoFiccao:
                    lstNaoFiccao.Add(numero);
                    break;
                case FiltroGenero.Romance:
                    lstRomance.Add(numero);
                    break;
            }
        }
        private void CarregarGeneros(FiltroGenero genero)
        {
            switch (genero)
            {
                case FiltroGenero.Ficcao:
                    listBoxFiccao.DataSource = null;
                    listBoxFiccao.DataSource = lstFiccao;
                    break;
                case FiltroGenero.NaoFiccao:
                    listBoxNaoFiccao.DataSource = null;
                    listBoxNaoFiccao.DataSource = lstNaoFiccao;
                    break;
                case FiltroGenero.Romance:
                    listBoxRomance.DataSource = null;
                    listBoxRomance.DataSource = lstRomance;
                    break;
            }
        }
        private void LimparCampos()
        {
            txtNumeroPaginas.Clear();
            txtNumeroPaginas.Focus();
        }

        #endregion

        #region FILTRO GENEROS

        private void PesquisarFiccao(FiltroComparacao comparacao, int numero)
        {
            listBoxFiccao.DataSource = null;

            switch (comparacao)
            {
                case FiltroComparacao.Acima:
                    listBoxFiccao.DataSource = lstFiccao.Where(item => item > numero).ToList();
                    break;
                case FiltroComparacao.Igual:
                    listBoxFiccao.DataSource = lstFiccao.Where(item => item == numero).ToList();
                    break;
                case FiltroComparacao.Abaixo:
                    listBoxFiccao.DataSource = lstFiccao.Where(item => item < numero).ToList();
                    break;
            }
        }

        private void PesquisarNaoFiccao(FiltroComparacao comparacao, int numero)
        {
            listBoxNaoFiccao.DataSource = null;

            switch (comparacao)
            {
                case FiltroComparacao.Acima:
                    listBoxNaoFiccao.DataSource = lstNaoFiccao.Where(item => item > numero).ToList();
                    break;
                case FiltroComparacao.Igual:
                    listBoxNaoFiccao.DataSource = lstNaoFiccao.Where(item => item == numero).ToList();
                    break;
                case FiltroComparacao.Abaixo:
                    listBoxNaoFiccao.DataSource = lstNaoFiccao.Where(item => item < numero).ToList();
                    break;
            }
        }

        private void PesquisarRomance(FiltroComparacao comparacao, int numero)
        {
            listBoxRomance.DataSource = null;
            switch (comparacao)
            {
                case FiltroComparacao.Acima:
                    listBoxRomance.DataSource = lstRomance.Where(item => item > numero).ToList();
                    break;
                case FiltroComparacao.Igual:
                    listBoxRomance.DataSource = lstRomance.Where(item => item == numero).ToList();
                    break;
                case FiltroComparacao.Abaixo:
                    listBoxRomance.DataSource = lstRomance.Where(item => item < numero).ToList();
                    break;
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(FiltroValidacao.FiltroPesquisa))
            {
                int numeroPesquisa;
                int filtroGenero = cbGeneroPesquisa.SelectedIndex;
                int filtroOpcao = cbOpcao.SelectedIndex;

                try
                {
            
                    numeroPesquisa = Convert.ToInt32(txtNumeroPesquisa.Text);
                    switch (filtroGenero)
                    {
                        case 0:// FICÇÃO
                            switch (filtroOpcao)
                            {
                                case 0: // ACIMA
                                    PesquisarFiccao(FiltroComparacao.Acima, numeroPesquisa);
                                    break;
                                case 1: // IGUAL
                                    PesquisarFiccao(FiltroComparacao.Igual, numeroPesquisa);
                                    break;
                                case 2: // ABAIXO
                                    PesquisarFiccao(FiltroComparacao.Abaixo, numeroPesquisa);
                                    break;
                            }
                            break;
                        case 1: // NÃO-FICÇÃO
                            switch (filtroOpcao)
                            {
                                case 0: // ACIMA
                                    PesquisarNaoFiccao(FiltroComparacao.Acima, numeroPesquisa);
                                    break;
                                case 1: // IGUAL
                                    PesquisarNaoFiccao(FiltroComparacao.Igual, numeroPesquisa);
                                    break;
                                case 2: // ABAIXO
                                    PesquisarNaoFiccao(FiltroComparacao.Abaixo, numeroPesquisa);
                                    break;
                            }
                            break;
                        case 2: // ROMANCE
                            switch (filtroOpcao)
                            {
                                case 0:
                                    PesquisarRomance(FiltroComparacao.Acima, numeroPesquisa);
                                    break;
                                case 1:
                                    PesquisarRomance(FiltroComparacao.Igual, numeroPesquisa);
                                    break;
                                case 2:
                                    PesquisarRomance(FiltroComparacao.Abaixo, numeroPesquisa);
                                    break;
                            }

                            break;
                    }

                }
                catch
                {
                    MessageBox.Show("Preencher todos os campos corretamente", "erro");
                }
            }
          
        }
        #endregion
    }
}
