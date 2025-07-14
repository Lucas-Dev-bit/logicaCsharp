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
    public partial class frmListGenerics2: Form
    {
        public frmListGenerics2()
        {
            InitializeComponent();
        }

        List<int> lstMoscaLigeiro = new List<int>();
        List<int> lstMosca = new List<int>();
        List<int> lstGalo = new List<int>();
        List<int> lstPena = new List<int>();
        List<int> lstLeve = new List<int>();

        private enum CategoriaPeso {
            MoscaLigeiro,
            Mosca,
            Galo,
            Pena,
            Leve
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarCampo())
            {
                int peso = Convert.ToInt32(txtPeso.Text);
                FiltroPeso(peso);
            }
        }

        private bool ValidarCampo()
        {
            bool flag = true;

                if (txtPeso.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Informar peso");
                    flag = false;
                }
  
            return flag;
        }

        private double FiltroPeso(int peso)
        {
            

            if(peso <= 48)
            {
                AdicionarPeso(peso, CategoriaPeso.MoscaLigeiro);
                CarregarMoscaLigeiro();
            }
            else if (peso > 48 && peso <= 51 )
            {
                AdicionarPeso(peso, CategoriaPeso.Mosca);
                CarregarMosca();
            }
            else if (peso > 51 && peso <= 54)
            {
                AdicionarPeso(peso, CategoriaPeso.Galo);
                CarregarGalo();
            }
            else if (peso > 54 && peso <= 57)
            {
                AdicionarPeso(peso, CategoriaPeso.Pena);
                CarregarPena();
            }
            else if (peso > 57 && peso <100)
            {
                AdicionarPeso(peso, CategoriaPeso.Leve);
                CarregarLeve();
            }

            return peso;
        }

        private void AdicionarPeso(int peso, CategoriaPeso Categoria)
        {
            switch(Categoria)
            {
                case CategoriaPeso.MoscaLigeiro:
                    lstMoscaLigeiro.Add(peso);
                    break;
                case CategoriaPeso.Mosca:
                    lstMosca.Add(peso);
                    break;
                case CategoriaPeso.Galo:
                    lstGalo.Add(peso);
                    break;
                case CategoriaPeso.Pena:
                    lstPena.Add(peso);
                    break;
                case CategoriaPeso.Leve:
                    lstLeve.Add(peso);
                    break;
            }
         
        }
        private void CarregarMoscaLigeiro()
        {
            lbMoscaLigeiro.DataSource = null;
            lbMoscaLigeiro.DataSource = lstMoscaLigeiro;
        }

        private void CarregarMosca()
        {
            ListBoxMosca.DataSource = null;
            ListBoxMosca.DataSource = lstMosca;
        }

        private void CarregarGalo()
        {
            listBoxGalo.DataSource = null;
            listBoxGalo.DataSource = lstGalo;
        }

        private void CarregarPena()
        {
            listBoxPena.DataSource = null;
            listBoxPena.DataSource = lstPena;
        }

        private void CarregarLeve()
        {
            listBoxLeve.DataSource = null;
            listBoxLeve.DataSource = lstLeve;
        }
    }
}
