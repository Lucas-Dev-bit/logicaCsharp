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
    public partial class frmListGenerics3: Form
    {
        public frmListGenerics3()
        {
            InitializeComponent();
        }

        List<int> lstInfantil = new List<int>();
        List<int> lstFundamental1 = new List<int>();
        List<int> lstFundamental2 = new List<int>();
        List<int> lstEnsinoMedio = new List<int>();
        List<int> lstEnsinoSuperior = new List<int>();

        private enum EtapaEscolar
        {
            Infantil,
            Fundamental1, 
            Fundamental2,
            EnsinoMedio,
            EnsinoSuperior
        }

        private bool ValidarCampo()
        {
            bool flag = true;
            
                if (txtIdade.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Idade", "Erro");
                    flag = false;
                }
                return flag;
        }

        private void CarregarInfantil()
        {
            listBoxInfantil.DataSource = null;
            listBoxInfantil.DataSource = lstInfantil;
        }
        private void CarregarFundamenta1()
        {
            listBoxFundamental1.DataSource = null;
            listBoxFundamental1.DataSource = lstFundamental1;
        }
        private void CarregarFundamental2()
        {
            listBoxFundamental2.DataSource = null;
            listBoxFundamental2.DataSource = lstFundamental2;
        }
        private void CarregarEnsinoMedio()
        {
            listBoxEnsinoMedio.DataSource = null;
            listBoxEnsinoMedio.DataSource = lstEnsinoMedio;
        }
        private void CarregarEnsinoSuperior()
        {
            listBoxEnsinoSuperior.DataSource = null;
            listBoxEnsinoSuperior.DataSource = lstEnsinoSuperior;
        }

        private void AdicionarIdade(int idade, EtapaEscolar categoria)
        {
            switch (categoria)
            {
                case EtapaEscolar.Infantil:
                    lstInfantil.Add(idade);
                    break;
                case EtapaEscolar.Fundamental1:
                    lstFundamental1.Add(idade);
                    break;
                case EtapaEscolar.Fundamental2:
                    lstFundamental2.Add(idade);
                    break;
                case EtapaEscolar.EnsinoMedio:
                    lstEnsinoMedio.Add(idade);
                    break;
                case EtapaEscolar.EnsinoSuperior:
                    lstEnsinoSuperior.Add(idade);
                    break;
            }
        }
        private int FiltrarIdade(int idade)
        {
            if(idade < 6)
            {
                AdicionarIdade(idade, EtapaEscolar.Infantil);
                CarregarInfantil();
            }
            else if(idade >= 6 && idade < 11)
            {
                AdicionarIdade(idade, EtapaEscolar.Fundamental1);
                CarregarFundamenta1();
            }
            else if(idade >= 11 && idade < 15)
            {
                AdicionarIdade(idade, EtapaEscolar.Fundamental2);
                CarregarFundamental2();
            }
            else if (idade >= 15 && idade < 18)
            {
                AdicionarIdade(idade, EtapaEscolar.EnsinoMedio);
                CarregarEnsinoMedio();
            }
            else
            {
                AdicionarIdade(idade, EtapaEscolar.EnsinoSuperior);
                CarregarEnsinoSuperior();
            }

                return idade;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

           if(ValidarCampo())
            {
                int idade = Convert.ToInt32(txtIdade.Text);
                FiltrarIdade(idade);
            }
            
        }
    }
}
