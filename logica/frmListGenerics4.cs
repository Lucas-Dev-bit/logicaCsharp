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
    public partial class frmListGenerics4: Form
    {
        public frmListGenerics4()
        {
            InitializeComponent();
        }

        List<string> lstMes = new List<string>();
        List<double> lstTemperatura = new List<double>();
        List<string> lstResultadoPesquisa = new List<string>();

        private enum Validacao
        {
            TempeMes,
            Filtro
            
        }

        private enum Filtros
        {
            Maior,
            Igual,
            Menor
        }

        private enum CarregarMesTemperatura
        {
            CarregarMes,
            CarregarTemperatura
        }
        
        private bool ValidarCampos(Validacao validacao)
        {
            bool flag = true;

            switch (validacao)
            {
                case Validacao.TempeMes:
                    if (txtMes.Text.Trim() == string.Empty
                    || txtTemperatura.Text.Trim() == string.Empty)
                    {
                        flag = false;
                    }
                    break;
                case Validacao.Filtro:
                    if(txtPesquisa.Text.Trim() == string.Empty ||
                        cbFiltro.SelectedIndex == -1)
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
        private void CarregarTemperatura()
        {
            listBoxTemperatura.DataSource = null;
            listBoxTemperatura.DataSource = lstTemperatura;
        }
        private void AdicionarMes(string mes)
        {
            lstMes.Add(mes);
        }
        private void AdicionarTemperatura(double temperatura)
        {
            lstTemperatura.Add(temperatura);
        }

        private void LimparCampos()
        {
            txtMes.Clear();
            txtTemperatura.Clear();
            txtMes.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        
        {
            try
            {
                if (ValidarCampos(Validacao.TempeMes))
                {
                    string mes = txtMes.Text;
                    double temperatura = Convert.ToDouble(txtTemperatura.Text);

                    AdicionarMes(mes);
                    CarregarMes();
                    AdicionarTemperatura(temperatura);
                    CarregarTemperatura();
                    LimparCampos();
                }
            }
            catch
            {
                MessageBox.Show("Digitar somente valores numéricos");
            }
           
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(Validacao.Filtro))
            {
                double pesquisar; 
                try
                {
                    pesquisar = Convert.ToDouble(txtPesquisa.Text);

                    if(cbFiltro.SelectedIndex == 0)
                    {
                        Pesquisar(Filtros.Maior, pesquisar);
                    }
                    else if (cbFiltro.SelectedIndex == 1)
                    {
                        Pesquisar(Filtros.Igual, pesquisar);
                    }
                    else if (cbFiltro.SelectedIndex == 2)
                    {
                        Pesquisar(Filtros.Menor, pesquisar);
                    }

                    CarregarPesquisa(CarregarMesTemperatura.CarregarTemperatura);
                   
                }
                catch
                {
                    MessageBox.Show("Preencher o valor corretamente");
                }
            }
        }

        private void AdicionarResultadoPesquisa(int posicao, string mes, double temperatura)
        {
            lstResultadoPesquisa.Add("Temperatura: " + temperatura + " registrada no mês: " + mes + " está na posição: " + posicao);
        }

        private void Pesquisar(Filtros filtro, double temperatura)
        {
            switch (filtro)
            {
                case Filtros.Maior:
                    for (int i = 0; i < lstTemperatura.Count; i++)
                    {
                        if (lstTemperatura[i] > temperatura)
                        {
                            AdicionarResultadoPesquisa(i, lstMes[i], lstTemperatura[i]);
                        }
                    }
                    break;
                case Filtros.Igual:
                    for(int i = 0; i < lstTemperatura.Count; i++)
                    {
                        if (lstTemperatura[i] == temperatura)
                        {
                            AdicionarResultadoPesquisa(i, lstMes[i], lstTemperatura[i]);
                        }
                    }
                    break;
                case Filtros.Menor:
                    for (int i = 0; i < lstTemperatura.Count; i++)
                    {
                        if (lstTemperatura[i] < temperatura)
                        {
                            AdicionarResultadoPesquisa(i, lstMes[i], lstTemperatura[i]);
                        }
                    }
                    break;
            }
        }

        private void CarregarPesquisa(CarregarMesTemperatura loading)
        {
            switch (loading)
            {
                case CarregarMesTemperatura.CarregarMes:
                    listBoxMes.DataSource = null;
                    listBoxMes.DataSource = lstMes;
                    break;
                case CarregarMesTemperatura.CarregarTemperatura:
                    if(lstResultadoPesquisa.Count == 0)
                    {
                        MessageBox.Show("Não foi encontrado nenhum valor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    listBoxPesquisa.DataSource = null;
                    listBoxPesquisa.DataSource = lstResultadoPesquisa;
                    lstResultadoPesquisa.Clear();
                    break;

            }
        }
    }
}
