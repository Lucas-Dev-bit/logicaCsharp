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
using logica.Classes;

namespace logica
{
    public partial class frmXml1 : Form
    {
        public frmXml1()
        {
            InitializeComponent();
        }

        #region EVENTOS CLICK
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                int codigo;
                object combustivel;
                string marca, modelo, anoFabricacao, placa, qtdPortas;
                decimal valorCompra, valorVenda;

                try
                {
                    codigo = Convert.ToInt32(txtCodigo.Text);
                    
                    if (VerificaCodigo(codigo.ToString()))
                    {
                        marca = txtMarca.Text;
                        modelo = txtModelo.Text;
                        anoFabricacao = txtAno.Text;
                        placa = txtPlaca.Text;
                        qtdPortas = txtPortas.Text;
                        combustivel = cbCombustivel.SelectedItem;
                        valorCompra = Convert.ToDecimal(txtValorCompra.Text);
                        valorVenda = Convert.ToDecimal(txtValorVenda.Text);

                        Cadastrar(codigo, marca, modelo, anoFabricacao, placa, qtdPortas, combustivel, valorCompra, valorVenda);
                        LimparCampos();
                        CarregarGrid();
                        Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
                        MessageBox.Show("Registro inserido com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao inserir o registro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
                return;
            
                int codigo;
                object combustivel;
                string marca, modelo, anoFabricacao, placa, qtdPortas;
                decimal valorCompra, valorVenda;

                try
                {
                    codigo = Convert.ToInt32(txtCodigo.Text);
                    marca = txtMarca.Text;
                    modelo = txtModelo.Text;
                    anoFabricacao = txtAno.Text;
                    placa = txtPlaca.Text;
                    qtdPortas = txtPortas.Text;
                    combustivel = cbCombustivel.SelectedItem;
                    valorCompra = Convert.ToDecimal(txtValorCompra.Text);
                    valorVenda = Convert.ToDecimal(txtValorVenda.Text);
                    Alterar(codigo, marca, modelo, anoFabricacao, placa, qtdPortas, combustivel, valorCompra, valorVenda);
                    LimparCampos();
                    CarregarGrid();
                    MessageBox.Show("Registro alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Erro ao alterar a pessoa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja excluir o registro selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               int codigo;
                try
                {
                    codigo = Convert.ToInt32(txtCodigo.Text);
                    Excluir(codigo);
                    LimparCampos();
                    CarregarGrid();
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
            LimparCampos();
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
        }

        private void grdXml1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdXml1.RowCount > 0)
            {
                var objLinhaSelecionada = grdXml1.CurrentRow.DataBoundItem as DataRowView;

                txtCodigo.Enabled = false;

                txtCodigo.Text = objLinhaSelecionada.Row["codigo"].ToString();
                txtMarca.Text = objLinhaSelecionada.Row["marca"].ToString();
                txtModelo.Text = objLinhaSelecionada.Row["modelo"].ToString();
                txtAno.Text = objLinhaSelecionada.Row["anofab"].ToString();
                txtPlaca.Text = objLinhaSelecionada.Row["placa"].ToString();
                txtPortas.Text = objLinhaSelecionada.Row["qtdportas"].ToString();
                cbCombustivel.Text = objLinhaSelecionada.Row["combustivel"].ToString();
                txtValorCompra.Text = objLinhaSelecionada.Row["valorCompra"].ToString();
                txtValorVenda.Text = objLinhaSelecionada.Row["valorVenda"].ToString();

                Util.ConfigurarEstadoTela(Util.EstadoTela.Edicao, btnCadastrar, btnAlterar, btnExcluir);

            }
        }

        #endregion

        #region METODOS

        private void Cadastrar(int cod, string marca, string modelo, string anoFabricacao, string placa,
                                string qtdPortas, object combustivel, decimal valorCompra, decimal valorVenda)
        {
            //OBJ CRIADO
            XmlDocument xml = new XmlDocument();

            if (!File.Exists(Util.pathFileXml1))
            {
                // cria o nó PAI
                XmlElement noExercicio1 = xml.CreateElement("exercicio1");
                xml.AppendChild(noExercicio1);
            }
            else
            {
                xml.Load(Util.pathFileXml1);
            }

            XmlElement noItem = xml.CreateElement("item");

            //CÓDIGO
            XmlElement noCodigo = xml.CreateElement("codigo");
            noCodigo.InnerText = cod.ToString();
            noItem.AppendChild(noCodigo);

            //MARCA
            XmlElement noMarca = xml.CreateElement("marca");
            noMarca.InnerText = marca;
            noItem.AppendChild(noMarca);

            //MODELO
            XmlElement noModelo = xml.CreateElement("modelo");
            noModelo.InnerText = modelo;
            noItem.AppendChild(noModelo);

            //ANO FABRICAÇÃO
            XmlElement noAnoFabricacao = xml.CreateElement("anofab");
            noAnoFabricacao.InnerText = anoFabricacao;
            noItem.AppendChild(noAnoFabricacao);

            //PLACA
            XmlElement noPlaca = xml.CreateElement("placa");
            noPlaca.InnerText = placa;
            noItem.AppendChild(noPlaca);

            //QUANTIDADE DE PORTAS
            XmlElement noPortas = xml.CreateElement("qtdportas");
            noPortas.InnerText = qtdPortas;
            noItem.AppendChild(noPortas);

            //COMPBUSTIVEL
            XmlElement noCombustivel = xml.CreateElement("combustivel");
            noCombustivel.InnerText = combustivel.ToString();
            noItem.AppendChild(noCombustivel);

            //VALOR COMPRA
            XmlElement noValorCompra = xml.CreateElement("valorCompra");
            noValorCompra.InnerText = valorCompra.ToString();
            noItem.AppendChild(noValorCompra);

            //VALOR VENDA
            XmlElement noValorVenda = xml.CreateElement("valorVenda");
            noValorVenda.InnerText = valorVenda.ToString();
            noItem.AppendChild(noValorVenda);

            //
            XmlNode xmlExercicio1 = xml.SelectSingleNode("exercicio1");
            xmlExercicio1.AppendChild(noItem);

            //SALVA O ARQUIVO
            xml.Save(Util.pathFileXml1);
        }
        private void Alterar(int codigo, string marca, string modelo, string anoFabricacao, string placa,
                                string qtdPortas, object combustivel, decimal valorCompra, decimal valorVenda)
        {
            XmlDocument xml = new XmlDocument();
            if (File.Exists(Util.pathFileXml1))
            {
                xml.Load(Util.pathFileXml1);
                XmlNode noInformacao = xml.SelectSingleNode($"//item[codigo='{codigo}']");

                if(noInformacao != null){

                    XmlNode noMarca = noInformacao.SelectSingleNode("marca");
                    noMarca.InnerText = marca;

                    XmlNode noModelo = noInformacao.SelectSingleNode("modelo");
                    noModelo.InnerText = modelo;

                    XmlNode noAnoFabricacao = noInformacao.SelectSingleNode("anofab");
                    noAnoFabricacao.InnerText = anoFabricacao;

                    XmlNode noPlaca = noInformacao.SelectSingleNode("placa");
                    noPlaca.InnerText = placa;

                    XmlNode noPortas = noInformacao.SelectSingleNode("qtdportas");
                    noPortas.InnerText = qtdPortas;

                    XmlNode noCombustivel = noInformacao.SelectSingleNode("combustivel");
                    noCombustivel.InnerText = combustivel.ToString();

                    XmlNode novalorCompra = noInformacao.SelectSingleNode("valorCompra");
                    novalorCompra.InnerText = valorCompra.ToString();

                    XmlNode novalorVenda = noInformacao.SelectSingleNode("valorVenda");
                    novalorVenda.InnerText = valorVenda.ToString();

                    xml.Save(Util.pathFileXml1);

                }
            }
        }
        private void Excluir(int codigo)
        {
            
            //Verifica se o arquivo XML existe.
            //Carrega o conteúdo do XML.
            //Procura um<item> com o < codigo > específico.
            //Se encontrar, remove esse<item>.
            //Salva o XML de volta no arquivo.

            XmlDocument xml = new XmlDocument();

            if (File.Exists(Util.pathFileXml1)) { // verifica

                xml.Load(Util.pathFileXml1); // carrega
                XmlNode noInformacao = xml.SelectSingleNode($"//item[codigo='{codigo}']"); // procura o item especifo

                if (noInformacao != null) { // se encontrar o ITEM, deleta
                    noInformacao.ParentNode.RemoveChild(noInformacao); // remove o nó filho do ITEM pai
                    xml.Save(Util.pathFileXml1);
                }
            }
        }
        private bool VerificaCodigo(string codigo)
        {
            //CRIA O OBJETO
            XmlDocument xml = new XmlDocument();

           
            
            if (File.Exists(Util.pathFileXml1))
                return false;
            
                xml.Load(Util.pathFileXml1);
                XmlNode noCodigo = xml.SelectSingleNode($"//item[codigo='{codigo}']");

                if (noCodigo != null) {

                    MessageBox.Show($" O Código: {codigo} Já exite no banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
                    return false;
                }
                //XmlNode noCodigo = xml.SelectSingleNode($"//item[codigo='{codigo}' and MARCA='{marca}]");

                return true;
           
        }
        private void CarregarGrid()
        {
            try
            {
                grdXml1.DataSource = null;

                if (File.Exists(Util.pathFileXml1)) { 
                
                        //CRIAR DATASET
                    DataSet ds = new DataSet();
                    ds.ReadXml(Util.pathFileXml1);

                    // VERIFICA SE ENCONTROU O CONTEÚDO
                    if (ds.Tables.Count > 0) 
                    {
                        grdXml1.DataSource = ds.Tables[0];

                        grdXml1.Columns["codigo"].HeaderText = "Código";
                        grdXml1.Columns["marca"].HeaderText = "Marca";
                        grdXml1.Columns["modelo"].HeaderText = "Modelo";
                        grdXml1.Columns["anofab"].HeaderText = "Ano Fabricação";
                        grdXml1.Columns["placa"].HeaderText = "Placa";
                        grdXml1.Columns["qtdportas"].HeaderText = "Qtd Portas";
                        grdXml1.Columns["combustivel"].HeaderText = "Combustível";
                        grdXml1.Columns["valorCompra"].HeaderText = "Valor Compra";
                        grdXml1.Columns["valorVenda"].HeaderText = "Valor Venda";
                    }   
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao carregar as informações.", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void frmXml1_Load(object sender, EventArgs e)
        {
            Util.ConfigurarEstadoTela(Util.EstadoTela.Novo, btnCadastrar, btnAlterar, btnExcluir);
            CarregarGrid();
        }
        private bool ValidarCampos()
        {
          bool flag = true;

            if (txtCodigo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo CÓDIGO corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMarca.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo MARCA corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtModelo.Text.Trim() == string.Empty) {
                MessageBox.Show("Preencha o campo MODELO corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtAno.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo ANO FABRICAÇÃO corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtPlaca.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo PLACA corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPortas.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo QUANTIDADE DE PORTAS corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbCombustivel.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha o campo COMBUSTÍVEL corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtValorCompra.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo VALOR DA COMPRA corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtValorVenda.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo VALOR DA VENDA corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return flag;
        }
        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtAno.Clear();
            txtPlaca.Clear();
            txtPortas.Clear();
            cbCombustivel.SelectedIndex = -1;
            txtValorCompra.Clear();
            txtValorVenda.Clear();

            txtCodigo.Focus();
        }
        #endregion
    }
}
