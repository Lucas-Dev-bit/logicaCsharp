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
using System.IO;


namespace logica
{
    public partial class frmMediaAluno: Form
    {
        public frmMediaAluno()
        {
            InitializeComponent();
        }
        #region ENUM
        private enum EstadoTela
        {
            Novo,
            Edicao
        }
        private enum Filtro {
            SemFiltro = 0,
            Reprovado = 1,
            Exame = 2,
            Aprovado = 3
        }

        #endregion

        #region VARIÁVEL GLOBAL
        List<Boletim> lstBoletim = new List<Boletim>();
        int posicaoIndex = 0;
        #endregion
       
        #region EVENTOS CLICK
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string nome;
                decimal nota1, nota2, nota3, nota4;

                try
                {
                    nome = txtNome.Text;
                    nota1 = Convert.ToDecimal(txtN1.Text);
                    nota2 = Convert.ToDecimal(txtN2.Text);
                    nota3 = Convert.ToDecimal(txtN3.Text);
                    nota4 = Convert.ToDecimal(txtN4.Text);
                    Cadastrar(nome, nota1, nota2, nota3, nota4);
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar o Aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }     
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            ConfigurarEstadoTela(EstadoTela.Novo);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string nome;
                decimal nota1, nota2, nota3, nota4;
                try
                {
                    nome = txtNome.Text.ToUpper();
                    nota1 = Convert.ToDecimal(txtN1.Text);
                    nota2 = Convert.ToDecimal(txtN2.Text);
                    nota3 = Convert.ToDecimal(txtN3.Text);
                    nota4 = Convert.ToDecimal(txtN4.Text);

                    Alterar(nome, nota1, nota2, nota3, nota4);
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao alterar o aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Excluir();
                MessageBox.Show("Boletim excluido com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMediaAluno_Load(object sender, EventArgs e)
        {
            ConfigurarEstadoTela(EstadoTela.Novo);
        }

        private void grdMediaAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdMediaAluno.RowCount > 0)
            {
                Boletim objLinhaSelecionada = grdMediaAluno.CurrentRow.DataBoundItem as Boletim;

                txtNome.Text = objLinhaSelecionada.Nome;
                txtN1.Text = objLinhaSelecionada.Nota1.ToString();
                txtN2.Text = objLinhaSelecionada.Nota2.ToString();
                txtN3.Text = objLinhaSelecionada.Nota3.ToString();
                txtN4.Text = objLinhaSelecionada.Nota4.ToString();

                posicaoIndex = e.RowIndex;

                ConfigurarEstadoTela(EstadoTela.Edicao);
            }
        }

        #endregion

        #region METODOS
        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar(cbFiltro.SelectedIndex);
        }
        private void Filtrar(int filtro)
        {
            grdMediaAluno.DataSource = null;

            switch (filtro)
            {
                case (int)Filtro.Aprovado:
                    grdMediaAluno.DataSource = lstBoletim.Where(boletim => boletim.Classificacao == "APROVADO").ToList();
                    break;
                case (int)Filtro.Exame:
                    grdMediaAluno.DataSource = lstBoletim.Where(boletim => boletim.Classificacao == "EXAME").ToList();
                    break;
                case (int)Filtro.Reprovado:
                    grdMediaAluno.DataSource = lstBoletim.Where(boletim => boletim.Classificacao == "REPROVADO").ToList();
                    break;
                default:
                    grdMediaAluno.DataSource = lstBoletim;
                    break;

            }
        }
        private void Cadastrar(string nome, decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
           
                Boletim objBoletim = new Boletim(nome, nota1, nota2, nota3, nota4);
                lstBoletim.Add(objBoletim);

                CarregarLista();
                LimparCampos();

                MessageBox.Show("Aluno inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);       
        }
        private void Alterar(string nome, decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
            Boletim objBoletim = new Boletim();

            lstBoletim[posicaoIndex].Nome = nome;
            lstBoletim[posicaoIndex].Nota1 = nota1;
            lstBoletim[posicaoIndex].Nota2 = nota2;
            lstBoletim[posicaoIndex].Nota3 = nota3;
            lstBoletim[posicaoIndex].Nota4 = nota4;

            lstBoletim[posicaoIndex].Media = objBoletim.CalcularMedia(nota1, nota2, nota3, nota4);
            lstBoletim[posicaoIndex].Classificacao = objBoletim.VerClassificacao(lstBoletim[posicaoIndex].Media);

            CarregarLista();
            LimparCampos();
            ConfigurarEstadoTela(EstadoTela.Novo);

            MessageBox.Show("Aluno alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Excluir()
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             { 
                lstBoletim.RemoveAt(posicaoIndex);
                CarregarLista();
                LimparCampos();
                ConfigurarEstadoTela(EstadoTela.Novo);
            }
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();

            txtNome.Focus();
        }
        private void CarregarLista()
        {
            grdMediaAluno.DataSource = null;
            grdMediaAluno.DataSource = lstBoletim;
        }   
        private bool ValidarCampos()
        {
            bool flag = true;

            if(txtNome.Text.Trim() == string.Empty || txtN1.Text.Trim() == string.Empty || txtN2.Text.Trim() == string.Empty
                || txtN3.Text.Trim() == string.Empty || txtN4.Text.Trim() == string.Empty)
            {
                flag = false;
                MessageBox.Show("Preencha todos os campos corretamente");
            }
            return flag;
        }

      
        private void ConfigurarEstadoTela(EstadoTela tela)
        {
            switch (tela)
            {
                case EstadoTela.Novo:
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    break;

                case EstadoTela.Edicao:
                    btnCadastrar.Enabled = false;
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                    break;

            }
        }
        private void Filtrar(String classificacao)
        {
            grdMediaAluno.DataSource = null;
            grdMediaAluno.DataSource = lstBoletim.Where(boletim => boletim.Classificacao.ToUpper().Contains(classificacao)).ToList();
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisar.Text;
            Filtrar(pesquisa.ToUpper());
        }

        #endregion

        private void btnGerar_Click(object sender, EventArgs e)
        {
            GerarArquivo();

        }
        private void GerarArquivo()
        {
            if(lstBoletim.Count == 0)
            {
                MessageBox.Show("Não exite nenhuma informação cadastrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else 
            {
                //LOCAL ONDE GUARDARA O ARQUIVO COM SEU NOME
                string pathFile = @"C:\\Users\\Lucas\\Desktop\\Curso de Programação\\ArquivoBoletim\boletim.txt";
                
                try
                {
                    //vamos criar um OBJETO do tipo streamWriter
                    using (StreamWriter arquivo = new StreamWriter(pathFile))
                    {
                        arquivo.WriteLine("--------------------------------------------------------------------------------");
                        arquivo.WriteLine("********************************** BOLETINS ************************************");
                        arquivo.WriteLine("--------------------------------------------------------------------------------");

                        foreach (var item in lstBoletim)
                        {
                            arquivo.WriteLine($"Nome: {item.Nome}, Média: {item.Media} - Classificação: {item.Classificacao}");
                        }
                    }
                    MessageBox.Show("Arquivo gerado com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Não foi possível gerar o arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
