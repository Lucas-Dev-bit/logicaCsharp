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

namespace logica
{
    public partial class frmCliente: Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        List<Cliente> lstClientes = new List<Cliente>();
        int posicaoIndex = 0;
       
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                String nome, rua, bairro, cep;

                nome = txtNome.Text;
                rua = txtRua.Text;
                bairro = txtBairro.Text;
                cep = txtCep.Text;

                Cadastrar(nome, rua, bairro, cep);
            }
        }
        private bool ValidarCampos()
        {
            bool flag = true;

            if(txtNome.Text.Trim() == string.Empty
                || txtRua.Text.Trim() == string.Empty
                || txtBairro.Text.Trim() == string.Empty
                || txtCep.Text.Trim() == string.Empty)
            {
                flag = false;
                MessageBox.Show("Preencher todos os campos corretamente", "Erro");
            }

            return flag;
        }
        private void Cadastrar(string nome, string rua, string bairro, string cep)
        {
            Cliente objCliente = new Cliente(nome, rua, bairro, cep);
            lstClientes.Add(objCliente);
            CarregarCliente();
            LimparCampos();
        }
        private void CarregarCliente()
        {
            grdClientes.DataSource = null;
            grdClientes.DataSource = lstClientes;
        }
        private void LimparCampos()
        {
            txtBairro.Clear();
            txtCep.Clear();
            txtNome.Clear();
            txtRua.Clear();
            txtNome.Focus();
        }

        private void grdClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdClientes.RowCount > 0)
            {
                Cliente objLinhaSelecionada = (Cliente)grdClientes.CurrentRow.DataBoundItem;

                txtNome.Text = objLinhaSelecionada.Nome;
                txtRua.Text = objLinhaSelecionada.Rua;
                txtBairro.Text = objLinhaSelecionada.Bairro;
                txtCep.Text = objLinhaSelecionada.Cep;
                posicaoIndex = e.RowIndex;
                Util.ConfigurarEstadoTela(Util.EstadoTela.Edicao, btnCadastrar, btnAlterar, btnExcluir);   
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Alterar();
                CarregarCliente();
                LimparCampos();
                Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
            }
        }

        private void Alterar()
        {
            
            lstClientes[posicaoIndex].Nome = txtNome.Text;
            lstClientes[posicaoIndex].Rua = txtRua.Text;
            lstClientes[posicaoIndex].Bairro = txtBairro.Text;
            lstClientes[posicaoIndex].Cep = txtCep.Text;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
            {
                Excluir();
                CarregarCliente();
                LimparCampos();
                Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
            }
            MessageBox.Show("Registro excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Excluir()
        {
            lstClientes.RemoveAt(posicaoIndex);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
        }

        private void Filtrar(string pesquisarInfo)
        {
            grdClientes.DataSource = null;
            grdClientes.DataSource = lstClientes.Where(cliente => cliente.Nome.ToUpper().Contains(pesquisarInfo)
                                                               || cliente.Rua.ToUpper().Contains(pesquisarInfo)).ToList();                                                       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisar.Text;
            Filtrar(pesquisa.ToUpper());
        }
    }
}
