using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica.Classes;
using static logica.Classes.Produto;

namespace logica
{
    public partial class frmCRUDobj3 : Form
    {
        public frmCRUDobj3()
        {
            InitializeComponent();
        }

        #region LIST
        List<Produto> lstProdutos = new List<Produto>();
        #endregion

        #region VARIAVEL GLOBAL
        int posicaoIndex = 0;
        #endregion

        #region ENUM
        private enum EstadoTela
        {
            Novo,
            Edicao
        }
      
        private void ConfigurarTela(EstadoTela tela)
        {
            switch (tela)
            {
                case EstadoTela.Novo:
                    btnCadastrar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    break;
                case EstadoTela.Edicao:
                    btnCadastrar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnAlterar.Enabled = true;
                    break;
            }
        }


        #endregion

        #region EVENTOS CLICK

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    string nomeProduto;
                    int qtd, categoria;
                    double valorUn;

                    nomeProduto = txtNome.Text;
                    qtd = Convert.ToInt32(txtQtd.Text);
                    valorUn = Convert.ToDouble(txtPrecoUn.Text);
                    categoria = cbCategoria.SelectedIndex;
                    

                    Cadastrar(nomeProduto, qtd, valorUn, categoria);
                }
                catch
                {
                    MessageBox.Show("Não foi possivel cadastrar a informação", "Erro");
                }
            }
        }



        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string nome;
                int qtd, categoria;
                double valorUn;

                nome = txtNome.Text;
                qtd = Convert.ToInt32(txtQtd.Text);
                valorUn = Convert.ToDouble(txtPrecoUn.Text);
                categoria = cbCategoria.SelectedIndex;

                Alterar(nome, qtd, valorUn, categoria);
              
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja exluir o registro?", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Excluir();
                CarregarLista();
                LimparCampos();
                ConfigurarTela(EstadoTela.Novo);
            }
            MessageBox.Show("Registro excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            ConfigurarTela(EstadoTela.Novo);
            
        }
        #endregion

        #region METODOS


        private void Cadastrar(string nome, int qtd, double valorUn, int categoria)
        {
            Produto objProdutos = new Produto(nome, qtd, (Categoria)categoria, valorUn);
            lstProdutos.Add(objProdutos);
            CarregarLista();
            LimparCampos();
        }

        private void CarregarLista()
        {
            grdProdutos.DataSource = null;
            grdProdutos.DataSource = lstProdutos;
            grdProdutos.Columns["CategoriaValor"].Visible = false;
        }
        private void Alterar(string nome, int qtd, double valorUn, int categoria)
        {
            Produto objProduto = new Produto(nome, qtd, (Categoria)categoria, valorUn);
            lstProdutos[posicaoIndex].NomeProduto = txtNome.Text;
            lstProdutos[posicaoIndex].Quantidade = (int)Convert.ToDecimal(txtQtd.Text);
            lstProdutos[posicaoIndex].Valor = (int)Convert.ToDecimal(txtPrecoUn.Text);
            lstProdutos[posicaoIndex].CategoriaValor = (Categoria)cbCategoria.SelectedIndex;
            lstProdutos[posicaoIndex].ImpostoTotal = objProduto.ImpostoTotal;

            CarregarLista();
            LimparCampos();
            ConfigurarTela(EstadoTela.Novo);

            MessageBox.Show("Dados alterados com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Excluir()
        {
            lstProdutos.RemoveAt(posicaoIndex);
        }
        private bool ValidarCampos()
        {
            bool flag = true;

            if (txtNome.Text.Trim() == string.Empty || txtQtd.Text.Trim() == string.Empty
                    || txtPrecoUn.Text.Trim() == string.Empty || cbCategoria.SelectedIndex == -1)
            {
                flag = false;
                MessageBox.Show("Preencha todos os campos corretamente", "Erro");
            }
            return flag;
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtQtd.Clear();
            txtPrecoUn.Clear();
            cbCategoria.SelectedIndex = -1;
            cbPesquisa.SelectedIndex = -1;
            txtNome.Focus();
            ConfigurarTela(EstadoTela.Novo);
        }
        private void frmCRUDobj3_Load(object sender, EventArgs e)
        {
            ConfigurarTela(EstadoTela.Novo);
        }

        private void grdProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (grdProdutos.RowCount > 0)
            {
                Produto objLinhaClicada = grdProdutos.CurrentRow.DataBoundItem as Produto;

                txtNome.Text = objLinhaClicada.NomeProduto;
                txtQtd.Text = objLinhaClicada.Quantidade.ToString();
                txtPrecoUn.Text = objLinhaClicada.Valor.ToString();
                cbCategoria.SelectedIndex = (int)objLinhaClicada.CategoriaValor;

                posicaoIndex = e.RowIndex;

                ConfigurarTela(EstadoTela.Edicao);

            }
        }
        private void cbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pesquisaCategoria = cbPesquisa.SelectedItem.ToString();
            Filtrar(pesquisaCategoria.ToUpper());
        }
        private void Filtrar(string categoria)
        {
            grdProdutos.DataSource = null;
            grdProdutos.DataSource = lstProdutos.Where(produto => produto.CategoriaProduto.Contains(categoria)).ToList();
        }
        #endregion

    }
}
