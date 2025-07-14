using logica.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace logica
{
    public partial class frmXMLCRUD: Form
    {
        public frmXMLCRUD()
        {
            InitializeComponent();
        }

        #region EVENTOS CLICK
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string nome, rua, bairro, codigo;
                try
                {
                    codigo = txtCodigo.Text;

                    if (VerificarCodigo(codigo))
                    {
                        nome = txtNome.Text;
                        rua = txtRua.Text;
                        bairro = txtBairro.Text;

                        Cadastrar(codigo, nome, rua, bairro);
                        LimparCampos();
                        Consultar();
                        Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
                        MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("O código já existe!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        LimparCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar o aluno" + ex ,"ERRO" );
                }
            }
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string codigo, nome, rua, bairro;
                try
                {
                    

                    codigo = txtCodigo.Text;
                    nome = txtNome.Text;
                    rua = txtRua.Text;
                    bairro = txtBairro.Text;

                    Alterar(codigo, nome, rua, bairro);
                    LimparCampos();
                    Consultar();
                    Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
                    MessageBox.Show("Registro alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Erro ao alterar a pessoa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseje excluir o registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string codigo;
                try
                {
                    codigo = txtCodigo.Text;
                    Excluir(codigo);
                    LimparCampos();
                    Consultar();
                    Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
                    MessageBox.Show("Registro excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao Excluir o registro.", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
            LimparCampos();
        }

        private void grdPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdPessoa.RowCount > 0)
            {
                var objLinhaClicada = (DataRowView)grdPessoa.CurrentRow.DataBoundItem;

                txtCodigo.Text = objLinhaClicada.Row["codigo"].ToString();
                txtNome.Text = objLinhaClicada.Row["nome"].ToString();
                txtRua.Text = objLinhaClicada.Row["rua"].ToString();
                txtBairro.Text = objLinhaClicada.Row["bairro"].ToString();
                txtCodigo.Enabled =false; 
                Util.ConfigurarEstadoTela(Util.EstadoTela.Edicao, btnCadastrar, btnAlterar, btnExcluir);

            }
        }

        #endregion

        #region METODOS
        private bool ValidarCampos()
        {
            bool flag = true;
           if(txtCodigo.Text.Trim() == string.Empty || txtNome.Text.Trim() == string.Empty || txtRua.Text.Trim() == string.Empty || txtBairro.Text.Trim() == string.Empty)
            {
                flag = false;
                MessageBox.Show("Preencha todos os campos corretamente!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return flag;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtCodigo.Clear();
            txtCodigo.Enabled = true;
            txtCodigo.Focus();
        }
        private void Excluir(string codigo)
        {
            XmlDocument xml = new XmlDocument();
            if (File.Exists(Util.pathFileXml))
            {
                xml.Load(Util.pathFileXml);
                XmlNode noInformacao = xml.SelectSingleNode($"//item[codigo='{codigo}']");

                if(noInformacao != null)
                {
                    noInformacao.ParentNode.RemoveChild(noInformacao);
                    xml.Save(Util.pathFileXml);
                }
            }
        }
        private void Alterar(string codigo, string nome, string rua, string bairro)
        {
            XmlDocument xml = new XmlDocument();

            if (File.Exists(Util.pathFileXml))
            {
                xml.Load(Util.pathFileXml);
                XmlNode noInformacao = xml.SelectSingleNode($"//item[codigo='{codigo}']");

                if(noInformacao != null)
                {
                    XmlNode noNome = noInformacao.SelectSingleNode("nome");
                    noNome.InnerText = nome;

                    XmlNode noRua = noInformacao.SelectSingleNode("rua");
                    noRua.InnerText = rua;

                    XmlNode noBairro = noInformacao.SelectSingleNode("bairro");
                    noBairro.InnerText = bairro;

                    xml.Save(Util.pathFileXml);

                }
            }
        }

        private bool VerificarCodigo(string codigo)
        {
            XmlDocument xml = new XmlDocument();

            if (File.Exists(Util.pathFileXml))
            {
                xml.Load(Util.pathFileXml);

                XmlNode noCodigo = xml.SelectSingleNode($"//item[codigo='{codigo}']");

                return noCodigo != null ? false : true;

            }
            return true;
        }

        private void Consultar()
        {
            // primeiro precisamos fazer a verificação se exite o arquivo, na pasta
            try
            {
                grdPessoa.DataSource = null;

                if (File.Exists(Util.pathFileXml))
                {
                    //criar o DATA SET
                    DataSet ds = new DataSet();
                    //Carrega o conteúdo do meu arquivo txt
                    ds.ReadXml(Util.pathFileXml);

                    //verifica se encontrou o conteúdo
                    if(ds.Tables.Count > 0)
                    {
                        grdPessoa.DataSource = ds.Tables[0];

                        grdPessoa.Columns["codigo"].HeaderText = "CÓDIGO";
                        grdPessoa.Columns["nome"].HeaderText = "NOME";
                        grdPessoa.Columns["rua"].HeaderText = "RUA";
                        grdPessoa.Columns["bairro"].HeaderText = "BAIRRO";
                    }


                }

            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao carregar as informações.", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Cadastrar(string codigo, string nome, string rua, string bairro)
        {
            //criamos o OBJETO que vai manipular o arquivo
            XmlDocument xml = new XmlDocument();

            //caminho da pasta para salvar o arquivo XML
            

            //verifica se o arquivo não existe
            if (!File.Exists(Util.pathFileXml))
            {
                XmlElement noPessoa = xml.CreateElement("pessoa");
                xml.AppendChild(noPessoa);
            }
            else
            {
                xml.Load(Util.pathFileXml);
            }

            //Cria o nó ITEM
            XmlElement noItem = xml.CreateElement("item");


            XmlElement noCodigo = xml.CreateElement("codigo");
            noCodigo.InnerText = codigo;
            noItem.AppendChild(noCodigo);

            //Cria o nó NOME
            XmlElement noNome = xml.CreateElement("nome");
            //Armazena a INFORMAÇÃO
            noNome.InnerText = nome;
            // Adiciona no nó PAI
            noItem.AppendChild(noNome);

            XmlElement noRua = xml.CreateElement("rua");
            noRua.InnerText = rua;
            noItem.AppendChild(noRua);

            XmlElement noBairro = xml.CreateElement("bairro");
            noBairro.InnerText = bairro;
            noItem.AppendChild(noBairro);

            //selecionar o nó PESSOA, precisamos vincular o noItem ao no pessoa, para isso vamos usar o XMLNODE
            XmlNode xmlPessoa = xml.SelectSingleNode("pessoa");
            xmlPessoa.AppendChild(noItem);

            //salvar o arquivo
            xml.Save(Util.pathFileXml);
        }
        #endregion

        private void frmXMLCRUD_Load(object sender, EventArgs e)
        {
            Consultar();
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
        }
    }
}
