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
    public partial class frmListGenerics6: Form
    {
        public frmListGenerics6()
        {
            InitializeComponent();
        }

        List<string> lstNome = new List<string>();
        List<double> lstQtd = new List<double>();
        List<double> lstPreco = new List<double>();

        private enum Info
        {
            Nome,
            Quantidade,
            Preco
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    string nome = txtNome.Text;
                    double qtd = Convert.ToDouble(txtQtd.Text);
                    double preco = Convert.ToDouble(txtPreco.Text);

                   //Adicionar(nome, qtd, preco);
                }
                catch
                {
                    MessageBox.Show("preencha todos os campos corretamente", "erro");
                }
            }

        }

        private bool ValidarCampos()
        {
            bool flag = true;

            if(txtNome.Text.Trim() == string.Empty ||
                txtQtd.Text.Trim() == string.Empty ||
                txtPreco.Text.Trim() == string.Empty)
            {
                
                flag = false;
            }
            if (!flag)
            {
                MessageBox.Show("Preencha os campos corretamente", "erro");
            }

            return flag;
        }

        private void Adicionar(string nome, Info info)
        {
            switch (info)
            {
                case Info.Nome:
                    lstNome.Add(nome);
                    break;
                case Info.Quantidade:
                    lstQtd.Add(1);
                    break;
                case Info.Preco:
                    lstPreco.Add(1);
                    break;
            }
        }
        private void Carregar(Info info)
        {
            switch (info)
            {
                case Info.Nome:
                    listBoxNomeProduto.DataSource = null;
                    listBoxNomeProduto.DataSource = lstNome;
                    break;
                case Info.Quantidade:
                    listBoxQtd.DataSource = null;
                    listBoxQtd.DataSource = lstQtd;
                    break;
                case Info.Preco:
                    listBoxPreco.DataSource = null;
                    listBoxPreco.DataSource = lstPreco;
                    break;

            }
        }

    }
}
