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
    public partial class frmLinq3: Form
    {
        public frmLinq3()
        {
            InitializeComponent();
        }

        #region LIST - lstInfantil | lstJuvenil | lstAdulto
        List<int> lstInfantil = new List<int>();
        List<int> lstJuvenil = new List<int>();
        List<int> lstAdulto = new List<int>();
        #endregion

        #region ENUM - Grupo etário | Filtro Comparação | Filtro Validação
        private enum GrupoEtario 
        {
            Infantil, 
            Juvenil,
            Adulto
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
            Pesquisa
        }

        #endregion FIM ENUM

        #region ADICIONAR
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(FiltroValidacao.Adicionar)){

                int altura;
                int filtroGenero = cbGrupoEtario.SelectedIndex;
                try
                {
                    altura = Convert.ToInt32(txtAltura.Text);
                    switch (filtroGenero) {
                        case 0:
                            AdicionarGrupoEtario(GrupoEtario.Infantil, altura);
                            CarregarGrupoEtario(GrupoEtario.Infantil);
                            LimparCampos();
                            break;
                        case 1:
                            AdicionarGrupoEtario(GrupoEtario.Juvenil, altura);
                            CarregarGrupoEtario(GrupoEtario.Juvenil);
                            LimparCampos();
                            break;
                        case 2:
                            AdicionarGrupoEtario(GrupoEtario.Adulto, altura);
                            CarregarGrupoEtario(GrupoEtario.Adulto);
                            LimparCampos();
                            break;
                    }

                }
                catch
                {
                    MessageBox.Show("Preencher todos os campos corretamente", "Erro");
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
                        if(txtAltura.Text.Trim() == string.Empty ||
                            cbGrupoEtario.SelectedIndex == -1)
                        {
                            flag = false;
                        }
                        break;
                    case FiltroValidacao.Pesquisa:
                        if(txtAlturaPesquisa.Text.Trim() == string.Empty ||
                            cbGrupoPesquisa.SelectedIndex == -1 ||
                            cbOpcaoPesquisa.SelectedIndex == -1)
                        {
                            flag = false;
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Preencher todos os campos corretamente", "Erro");
            }
            if (!flag)
            {
                MessageBox.Show("Preencher todos os campos corretamente", "Erro");
            }

            return flag;
        }

        private void AdicionarGrupoEtario(GrupoEtario grupo, int altura)
        {
            switch (grupo)
            {
                case GrupoEtario.Infantil:
                    lstInfantil.Add(altura);
                    break;
                case GrupoEtario.Juvenil:
                    lstJuvenil.Add(altura);
                    break;
                case GrupoEtario.Adulto:
                    lstAdulto.Add(altura);
                    break;

            }
        }

        private void CarregarGrupoEtario(GrupoEtario grupo)
        {
            switch (grupo) 
            {
                case GrupoEtario.Infantil:
                    listBoxInfantil.DataSource = null;
                    listBoxInfantil.DataSource = lstInfantil;
                    break;
                case GrupoEtario.Juvenil:
                    listBoxJuvenil.DataSource = null;
                    listBoxJuvenil.DataSource = lstJuvenil;
                    break;
                case GrupoEtario.Adulto:
                    listBoxAdulto.DataSource = null;
                    listBoxAdulto.DataSource = lstAdulto;
                    break;
            }

        }

        private void LimparCampos()
        {
            txtAltura.Clear();
            txtAltura.Focus();
        }

        #endregion

        #region FILTRO PESQUISA

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(FiltroValidacao.Pesquisa))
            {
                int altura;
                int filtroGenero = cbGrupoPesquisa.SelectedIndex;
                int filtroOpcao = cbOpcaoPesquisa.SelectedIndex;

                try
                {
                    altura = Convert.ToInt32(txtAlturaPesquisa.Text);
                    switch (filtroGenero)
                    {
                        case 0:
                            switch (filtroOpcao) 
                            {
                                case 0:
                                    PesquisarGrupoInfantil(FiltroComparacao.Acima, altura);
                                    break;
                                case 1:
                                    PesquisarGrupoInfantil(FiltroComparacao.Igual, altura);
                                    break;
                                case 2:
                                    PesquisarGrupoInfantil(FiltroComparacao.Abaixo, altura);
                                    break;
                            }
                            break;
                        case 1:
                            switch (filtroOpcao)
                            {
                                case 0:
                                    PesquisarGrupoJuvenil(FiltroComparacao.Acima, altura);
                                    break;
                                case 1:
                                    PesquisarGrupoJuvenil(FiltroComparacao.Igual, altura);
                                    break;
                                case 2:
                                    PesquisarGrupoJuvenil(FiltroComparacao.Abaixo, altura);
                                    break;
                            }
                            break;
                        case 2:
                            switch (filtroOpcao)
                            {
                                case 0:
                                    PesquisarGrupoAdulto(FiltroComparacao.Acima, altura);
                                    break;
                                case 1:
                                    PesquisarGrupoAdulto(FiltroComparacao.Igual, altura);
                                    break;
                                case 2:
                                    PesquisarGrupoAdulto(FiltroComparacao.Abaixo, altura);
                                    break;
                            }

                            break;

                    }
                }
                catch
                {
                    MessageBox.Show("Preencha os campos corretamente", "Erro");
                }
            }
        }
        private void PesquisarGrupoInfantil(FiltroComparacao comparacao, int altura)
        {
            listBoxInfantil.DataSource = null;
            switch (comparacao)
            {
                case FiltroComparacao.Acima:
                    listBoxInfantil.DataSource = lstInfantil.Where(item => item > altura).ToList();
                    break;
                case FiltroComparacao.Igual:
                    listBoxInfantil.DataSource = lstInfantil.Where(item => item == altura).ToList();
                    break;
                case FiltroComparacao.Abaixo:
                    listBoxInfantil.DataSource = lstInfantil.Where(item => item < altura).ToList();
                    break;
            }

        }
        private void PesquisarGrupoJuvenil(FiltroComparacao comparacao, int altura)
        {
            listBoxJuvenil.DataSource = null;
            switch (comparacao)
            {
                case FiltroComparacao.Acima:
                    listBoxJuvenil.DataSource = lstJuvenil.Where(item => item > altura).ToList();
                    break;
                case FiltroComparacao.Igual:
                    listBoxJuvenil.DataSource = lstJuvenil.Where(item => item == altura).ToList();
                    break;
                case FiltroComparacao.Abaixo:
                    listBoxJuvenil.DataSource = lstJuvenil.Where(item => item < altura).ToList();
                    break;
            }
        }
        private void PesquisarGrupoAdulto(FiltroComparacao comparacao, int altura)
        {
            listBoxAdulto.DataSource = null;
            switch (comparacao)
            {
                case FiltroComparacao.Acima:
                    listBoxAdulto.DataSource = lstAdulto.Where(item => item > altura).ToList();
                    break;
                case FiltroComparacao.Igual:
                    listBoxAdulto.DataSource = lstAdulto.Where(item => item == altura).ToList();
                    break;
                case FiltroComparacao.Abaixo:
                    listBoxAdulto.DataSource = lstAdulto.Where(item => item < altura).ToList();
                    break;
            }
        }
        #endregion
    }
}
