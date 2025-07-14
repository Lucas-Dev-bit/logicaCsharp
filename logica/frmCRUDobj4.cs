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
using static logica.Classes.ProdutoCRUD4;

namespace logica
{
    public partial class frmCRUDobj4: Form
    {
        public frmCRUDobj4()
        {
            InitializeComponent();
        }

        List<ProdutoCRUD4> lstCalculo = new List<ProdutoCRUD4>();
        int posicaoIndex = 0;

        #region ENUM
        private enum EstadoTela {
            Novo,
            Edicao
        }
        private void ConfigurarTela(EstadoTela tela)
        {
            switch (tela)
            {
                case EstadoTela.Novo:
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnCancelar.Enabled = true;
                    break;
                case EstadoTela.Edicao:
                    btnCadastrar.Enabled = false;
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;

            }
        }

        #endregion

        #region EVENTOS CLICK
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome;
            int qtd, tipoCliente;
            decimal precoUn;
            
            try
            {
                nome = txtNomeProduto.Text;  
                qtd = Convert.ToInt32(txtQtd.Text);
                precoUn = Convert.ToDecimal(txtPrecoUn.Text);
                tipoCliente = cbTipo.SelectedIndex;

                Cadastrar(nome, qtd, precoUn, tipoCliente);

            }
            catch
            {
                MessageBox.Show("teste");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string nome;
            int qtd, tipoCliente;
            decimal precoUn;

            try
            {
                nome = txtNomeProduto.Text;
                qtd = Convert.ToInt32(txtQtd.Text);
                precoUn = Convert.ToDecimal(txtPrecoUn.Text);
                tipoCliente = cbTipo.SelectedIndex;

               Alterar(nome, qtd, precoUn, tipoCliente);

            }
            catch
            {
                MessageBox.Show("teste");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Excluir();
                CarregarLista();
                LimparCampos();
                ConfigurarTela(EstadoTela.Novo);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            ConfigurarTela(EstadoTela.Novo);

        }

        private void btnGerarTxt_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region METODOS

        private void frmCRUDobj4_Load(object sender, EventArgs e)
        {
            ConfigurarTela(EstadoTela.Novo);
        }

        private void Cadastrar(string nome, int qtd, decimal precoUn, int clienteIndex)
        {
            ProdutoCRUD4 objCalculo = new ProdutoCRUD4(nome, qtd, precoUn, (TipoCliente) clienteIndex);
            lstCalculo.Add(objCalculo);
            CarregarLista();
            LimparCampos();
        }
        private void Alterar(string nome, int qtd, decimal precoUn, int clienteIndex)
        {
            ProdutoCRUD4 objProduto = new ProdutoCRUD4();

            lstCalculo[posicaoIndex].NomeProduto = txtNomeProduto.Text;
            lstCalculo[posicaoIndex].Quantidade = Convert.ToInt32(txtQtd.Text);
            lstCalculo[posicaoIndex].PrecoUn = Convert.ToDecimal(txtPrecoUn.Text);
            lstCalculo[posicaoIndex].ClienteIndex = (TipoCliente)cbTipo.SelectedIndex;
            //lstCalculo[posicaoIndex].DescontoTotal = objProduto.CalculoDesconto(DescontoTotal);
          //  lstCalculo[posicaoIndex].ValorFinal = objProduto.ValorFinal;

            CarregarLista();
            LimparCampos();
            ConfigurarTela(EstadoTela.Novo);

            MessageBox.Show("Registro alterado com sucesso!", "Sucesso");
        }
        private void Excluir()
        {
            lstCalculo.RemoveAt(posicaoIndex);
        }

        private void LimparCampos()
        {
            txtNomeProduto.Clear();
            txtPrecoUn.Clear();
            txtQtd.Clear();
            cbTipo.SelectedIndex = -1;

            txtNomeProduto.Focus();
        }

        private void CarregarLista()
        {
            grdProduto.DataSource = null;
            grdProduto.DataSource = lstCalculo;
            grdProduto.Columns["ClienteIndex"].Visible = false;
        }
        #endregion

        private void cbTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string pesquisa = cbTipoPesquisa.SelectedItem.ToString();
            Filtro(cbTipoPesquisa.SelectedIndex);
        }
        private void Filtro(int filtro)
        {
            grdProduto.DataSource = null;
           
            switch (filtro)
            {
                case (int)TipoClienteFiltro.PessoaFisica:
                    grdProduto.DataSource = lstCalculo.Where(item => item.Cliente == "PESSOA FISICA").ToList();/*.ToUpper().Contains(pesquisa)).ToList();*/
                    
                    break;

                case (int)TipoClienteFiltro.PessoaJuridica:
                    grdProduto.DataSource = lstCalculo.Where(item => item.Cliente == "PESSOA JURIDICA").ToList();
                    break;

                case (int)TipoClienteFiltro.Funcionario:
                    var resultado = lstCalculo.Where(item => item.Cliente == "FUNCIONARIO").ToList();
                    grdProduto.DataSource = resultado;
                    if(!resultado.Any())
                    {
                        MessageBox.Show("Não existe registro nesse tipo de filtro", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarLista();
                    }
                    break;
            }
            grdProduto.Columns["ClienteIndex"].Visible = false;
        }
        public enum TipoClienteFiltro
        {
            PessoaFisica = 0,
            PessoaJuridica = 1,
            Funcionario = 2
        }

        private void grdProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdProduto.RowCount > 0)
            {
                ProdutoCRUD4 objLinha = grdProduto.CurrentRow.DataBoundItem as ProdutoCRUD4;

                txtNomeProduto.Text = objLinha.NomeProduto;
                txtQtd.Text = objLinha.Quantidade.ToString();
                txtPrecoUn.Text = objLinha.PrecoUn.ToString();
                cbTipo.SelectedIndex = (int)objLinha.ClienteIndex;

                posicaoIndex = e.RowIndex;

                ConfigurarTela(EstadoTela.Edicao);
            }
        }
    }
}
