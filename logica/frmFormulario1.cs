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
    public partial class frmFormulario1: Form
    {
        public frmFormulario1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtNomeProduto.Text.Trim() == "")
            {
                //preencher o campo nome produto
                MessageBox.Show("Preencha o campo Nome do Produto", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Coloca o curosor no campo
                txtNomeProduto.Focus();
                //limpa a campo nome produto
                txtNomeProduto.Clear();
            }
            else if (txtValorCompra.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo Valor da Compra", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorCompra.Focus();
                txtValorCompra.Clear();
            }
            else if (txtValorVenda.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo Valor da Venda", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorVenda.Focus();
                txtValorVenda.Clear();
            }
            else if(txtDescricao.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo Descrição", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Focus();
                txtDescricao.Clear();
            }
            else
            {
                string nomeProduto, valorCompra, valorVenda, Descricao;

                nomeProduto = txtNomeProduto.Text;
                valorCompra = txtValorCompra.Text;
                valorVenda = txtValorVenda.Text;
                Descricao = txtDescricao.Text;

                MessageBox.Show("Nome do Produto: " + nomeProduto + "\nValor da compra: " + valorCompra + "\nValor da venda: " + valorVenda + "\nDescrição: " + Descricao, "PRODUTO CADASTRADO");
            }
        
        }
    }
}
