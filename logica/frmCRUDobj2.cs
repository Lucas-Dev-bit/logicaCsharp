using logica.Classes;
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
    public partial class frmCRUDobj2: Form
    {
        public frmCRUDobj2()
        {
            InitializeComponent();
        }

        List<Roupa> lstRoupas = new List<Roupa>();
        int posicaoIndex = 0;

        private enum EstadoTela { 
            Novo,
            Edicao
        }
        private void ConfigEstadoTela(EstadoTela tela)
        {
            switch (tela) {
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


        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            string tipo, cor;
            int numero;
            decimal valor;

            if (ValidarCampos())
            {
                tipo = txtTipo.Text;
                cor = txtCor.Text;
                numero = Convert.ToInt32(txtNumero.Text);
                valor = Convert.ToDecimal(txtValor.Text);

                Cadastrar(tipo, numero, cor, valor);
                LimparCampos();
            }

        }

        private void Cadastrar(string tipo, int numero, string cor, decimal valor)
        {
            Roupa objRoupas = new Roupa(tipo, numero, cor, valor);
            lstRoupas.Add(objRoupas);
            CarregarLista();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Alterar();
                CarregarLista();
                LimparCampos();
                ConfigEstadoTela(EstadoTela.Novo);
            }
        }

        private void Alterar() // tenho que trazer as propiedades como parametros
        {
            lstRoupas[posicaoIndex].TipoRoupa = txtTipo.Text;
            lstRoupas[posicaoIndex].Numero = Convert.ToInt32(txtNumero.Text);
            lstRoupas[posicaoIndex].Cor = txtCor.Text;
            lstRoupas[posicaoIndex].Valor = Convert.ToDecimal(txtValor.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Excluir();
                CarregarLista();
                LimparCampos();
                ConfigEstadoTela(EstadoTela.Novo);

            }
        }

        private void Excluir()
        {
            lstRoupas.RemoveAt(posicaoIndex);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            ConfigEstadoTela(EstadoTela.Novo);
        }

        private void CarregarLista()
        {
            grdRoupas.DataSource = null;
            grdRoupas.DataSource = lstRoupas;

        }

        private bool ValidarCampos()
        {
            bool flag = true;

            if(txtTipo.Text.Trim() == string.Empty || txtNumero.Text.Trim() == string.Empty
                  || txtCor.Text.Trim() == string.Empty || txtValor.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher todos os campos corretamente", "Erro");
            }

            return flag;
        }

        private void LimparCampos()
        {
            txtTipo.Clear();
            txtCor.Clear();
            txtNumero.Clear();
            txtValor.Clear();
            txtTipo.Focus();
        }

        private void frmCRUDobj2_Load(object sender, EventArgs e)
        {
            ConfigEstadoTela(EstadoTela.Novo);
        }

        private void grdRoupas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdRoupas.RowCount > 0)
            {
                Roupa objLinhaSelecionada = grdRoupas.CurrentRow.DataBoundItem as Roupa;
                txtTipo.Text = objLinhaSelecionada.TipoRoupa;
                txtCor.Text = objLinhaSelecionada.Cor;
                txtNumero.Text = objLinhaSelecionada.Numero.ToString();
                txtValor.Text = objLinhaSelecionada.Valor.ToString();
                posicaoIndex = e.RowIndex;
                ConfigEstadoTela(EstadoTela.Edicao);
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string corPesquisa = txtPesquisar.Text;
            Pesquisa(corPesquisa.ToUpper());
        }
        private void Pesquisa(string corPesquisa)
        {
            grdRoupas.DataSource = null;
            grdRoupas.DataSource = lstRoupas.Where(item => item.Cor.ToUpper().Contains(corPesquisa)).ToList();
        }
    }
}
