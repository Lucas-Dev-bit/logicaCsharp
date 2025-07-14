using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace logica
{
    public partial class frmCRUDobj1: Form
    {
        public frmCRUDobj1()
        {
            InitializeComponent();
        }
        List<Matricula> lstMatricula = new List<Matricula>();
        int posicaoIndex = 0;
        private enum EstadoTela
        {
            Novo,
            Edicao
        }
        private void ConfigurarEstadoTela(EstadoTela tela)
        {
            switch (tela)
            {
                case EstadoTela.Novo:
                    //btnCadastrar.Visible = true;
                    //btnAlterar.Visible = false;
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnExcluir.Enabled = false;
                    break;
                case EstadoTela.Edicao:
                    //btnAlterar.Visible = true;
                    //btnCadastrar.Visible = false;
                    btnAlterar.Enabled = true;
                    btnCadastrar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnExcluir.Enabled = true;
                    break;
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomeCompleto, endereco, numero, bairro, cep, cidade, telefone, profissao,
               estadoCivil, email, emailCobranca, cpf, rg;
            DateTime dataNascimento;

            if (ValidarCampos())
            {
                try
                {
                    nomeCompleto = txtNome.Text.Trim();
                    endereco = txtEndereco.Text.Trim();
                    numero = txtNumero.Text.Trim();
                    bairro = txtBairro.Text.Trim();
                    cep = mtxtCep.Text.Trim();
                    cidade = txtCidade.Text.Trim();
                    telefone = mtxtTelefone.Text.Trim();
                    profissao = txtProfissao.Text.Trim();
                    estadoCivil = txtEstadoCivil.Text.Trim();
                    email = txtEmail.Text.Trim();
                    emailCobranca = txtEmailCobranca.Text.Trim();
                    cpf = mtxtCpf.Text.Trim();
                    rg = mtxtRg.Text.Trim();
                    dataNascimento = dtpDataNascimento.Value;

                    Cadastrar(nomeCompleto, endereco, numero, bairro, cep, cidade, telefone, profissao, estadoCivil, dataNascimento, email,
                   emailCobranca, cpf, rg);
                    LimparCampos();
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar a informação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
               
            }
            
            
                
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
           
               
            if (ValidarCampos())
            {
                string nomeCompleto, endereco, numero, bairro, cep, cidade, telefone, profissao,
              estadoCivil, email, emailCobranca, cpf, rg;
                DateTime dataNascimento;

                try
                {
                    nomeCompleto = txtNome.Text.Trim().ToUpper();
                    endereco = txtEndereco.Text.Trim().ToUpper();
                    numero = txtNumero.Text.Trim();
                    bairro = txtBairro.Text.Trim();
                    cep = mtxtCep.Text.Trim();
                    cidade = txtCidade.Text.Trim();
                    telefone = mtxtTelefone.Text.Trim();
                    profissao = txtProfissao.Text.Trim();
                    estadoCivil = txtEstadoCivil.Text.Trim();
                    email = txtEmail.Text.Trim();
                    emailCobranca = txtEmailCobranca.Text.Trim();
                    cpf = mtxtCpf.Text.Trim();
                    rg = mtxtRg.Text.Trim();
                    dataNascimento = dtpDataNascimento.Value;

                    Alterar(nomeCompleto, endereco, numero, bairro,
                    cep, cidade, telefone, profissao, estadoCivil,
                    dataNascimento, email, emailCobranca, cpf, rg);
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao alterar a informação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            ConfigurarEstadoTela(EstadoTela.Novo);
        }
        private void Cadastrar(string nome, string endereco, string numero, string bairro,
            string cep, string cidade, string telefone, string profissao, string estadoCivil,
            DateTime dataNascimento, string email, string emailCobranca, string cpf, string rg)
        {
                    Matricula objMatricula = new Matricula(nome, endereco, numero, bairro,
                    cep, cidade, telefone, profissao, estadoCivil,
                    dataNascimento, email, emailCobranca, cpf, rg);

                    lstMatricula.Add(objMatricula);
                    CarregarLista();
                    LimparCampos();
                    MessageBox.Show("Informação cadastrada com sucesso!", "Secesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void Alterar(string nome, string endereco, string numero, string bairro,
            string cep, string cidade, string telefone, string profissao, string estadoCivil,
            DateTime dataNascimento, string email, string emailCobranca, string cpf, string rg)
        {
            //  lstMatricula[posicaoIndex]  representa o OBJETO [ MATRICULA ] dentro da lista
            lstMatricula[posicaoIndex].NomeCompleto = nome; // vai sobreescrever o valor que estava com o novo informado pelo usuário
            lstMatricula[posicaoIndex].Endereco = endereco;
            lstMatricula[posicaoIndex].Numero = numero;
            lstMatricula[posicaoIndex].Bairro = bairro;
            lstMatricula[posicaoIndex].Cep = cep;
            lstMatricula[posicaoIndex].Cidade = cidade;
            lstMatricula[posicaoIndex].Telefone = telefone;
            lstMatricula[posicaoIndex].Profissao = profissao;
            lstMatricula[posicaoIndex].EstadoCivil = estadoCivil;
            lstMatricula[posicaoIndex].DataNascimento = dataNascimento;
            lstMatricula[posicaoIndex].Email = email;
            lstMatricula[posicaoIndex].EmailCobranca = emailCobranca;
            lstMatricula[posicaoIndex].Cpf = cpf;
            lstMatricula[posicaoIndex].Rg = rg;

            CarregarLista();
            LimparCampos();
            ConfigurarEstadoTela(EstadoTela.Novo);
        }
        private void CarregarLista()
        {
            grdMatricula.DataSource = null;

            if (lstMatricula.Count > 0)
            {
                
                grdMatricula.DataSource = lstMatricula;
            }
               
        }
        private bool ValidarCampos()
        {
            bool flag = true;
            if(txtNome.Text.Trim() == string.Empty
                || txtEndereco.Text.Trim() == string.Empty || txtNumero.Text.Trim() == string.Empty || txtBairro.Text.Trim() == string.Empty
                || mtxtCep.Text == null || txtCidade.Text.Trim() == string.Empty || mtxtTelefone.Text == null || txtProfissao.Text.Trim() == string.Empty
                || txtEstadoCivil.Text.Trim() == string.Empty || dtpDataNascimento.Text == "" || txtEmail.Text.Trim() == string.Empty
                || txtEmailCobranca.Text.Trim() == string.Empty || mtxtCpf.Text.Trim() == "" || mtxtRg.Text.Trim() == null)
            {
                flag = false;
                MessageBox.Show("Prencha todos os campos corretamente");
            }

            return flag;
        }

        private void grdMatricula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //verifica se tem item na grid
            if(grdMatricula.RowCount > 0)
            {                    // OBJETO        //conversãoRápida //GRID    //Linha atual                  
                Matricula objLinhaClicadaMatricula = (Matricula)grdMatricula.CurrentRow.DataBoundItem; // usamos a conversao rapida visto nas aula de ENUM

                txtNome.Text = objLinhaClicadaMatricula.NomeCompleto;
                txtEndereco.Text = objLinhaClicadaMatricula.Endereco;
                txtNumero.Text = objLinhaClicadaMatricula.Numero;
                txtBairro.Text = objLinhaClicadaMatricula.Bairro;
                mtxtCep.Text = objLinhaClicadaMatricula.Cep;
                txtCidade.Text = objLinhaClicadaMatricula.Cidade;
                mtxtTelefone.Text = objLinhaClicadaMatricula.Telefone;
                txtProfissao.Text = objLinhaClicadaMatricula.Profissao;
                txtEstadoCivil.Text = objLinhaClicadaMatricula.EstadoCivil;
                dtpDataNascimento.Value = objLinhaClicadaMatricula.DataNascimento;
                txtEmail.Text = objLinhaClicadaMatricula.Email;
                txtEmailCobranca.Text = objLinhaClicadaMatricula.EmailCobranca;
                mtxtCpf.Text = objLinhaClicadaMatricula.Cpf;
                mtxtRg.Text = objLinhaClicadaMatricula.Rg;

                // vamos marcar o index (informação que o usuário clicou)
                //a letra E representa todas as propriedades da DataGridView
                // RowIndex
                posicaoIndex = e.RowIndex;
                ConfigurarEstadoTela(EstadoTela.Edicao);

            }
        }
        private void frmCRUDobj1_Load(object sender, EventArgs e)
        {
            ConfigurarEstadoTela(EstadoTela.Novo);
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            mtxtCep.Clear();
            txtCidade.Clear();
            mtxtTelefone.Clear();
            txtProfissao.Clear();
            txtEstadoCivil.Clear();
            dtpDataNascimento.Text = null;
            txtEmail.Clear();
            txtEmailCobranca.Clear();
            mtxtCpf.Clear();
            mtxtRg.Clear();
            txtNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja excluir o registo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Excluir();
                CarregarLista();
                LimparCampos();
                ConfigurarEstadoTela(EstadoTela.Novo);
            }
            MessageBox.Show("Registro excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Excluir()
        {
            lstMatricula.RemoveAt(posicaoIndex);
        }

        private void txtPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            string pesquisaNome = txtPesquisaNome.Text;
            Filtrar(pesquisaNome.ToUpper());
        }

        private void Filtrar(string pesquisaNome)
        {
            grdMatricula.DataSource = null;
            grdMatricula.DataSource = lstMatricula.Where(matricula => matricula.NomeCompleto.ToUpper().Contains(pesquisaNome) 
                                                                    || matricula.Cpf.Contains(pesquisaNome)
                                                                    || matricula.Rg.Contains(pesquisaNome)).ToList();

        }

        private void grdMatricula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
