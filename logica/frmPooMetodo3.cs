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
using static System.Net.Mime.MediaTypeNames;

namespace logica
{
    public partial class frmPooMetodo3: Form
    {
        public frmPooMetodo3()
        {
            InitializeComponent();
        }
        List<string> lstNomeCidade = new List<string>();
        List<string> lstExpansao = new List<string>();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarCampos()){
                try
                {
                    AnaliseExpansao objanaliseExpansao = new AnaliseExpansao();
                    bool numeroHabitantes = objanaliseExpansao.verificaHabitantes(Convert.ToInt32(txtNumeroHabitantes.Text));
                    bool renda = objanaliseExpansao.verificaRenda(Convert.ToDouble(txtRendaMedia.Text));

                    string classificacao = objanaliseExpansao.Verificacao(numeroHabitantes, renda);
                    Cadastrar(txtNomeCidade.Text, classificacao);
                    CarregarListas();
                    LimparCampos();
                   
                }
                catch
                {
                    MessageBox.Show("Preencha todos os campos corretamente", "Erro");
                }     
            }
        }

        public void LimparCampos()
        {
            txtNomeCidade.Clear();
            txtNumeroHabitantes.Clear();
            txtRendaMedia.Clear();
            txtNomeCidade.Focus();
        }
             
        public void Cadastrar(string nomeCidade, string classificacao)
        {
            lstNomeCidade.Add(nomeCidade);
            lstExpansao.Add(classificacao);
        }
        public bool ValidarCampos()
        {
            bool flag = true;

            if (txtNomeCidade.Text.Trim() == string.Empty 
                || txtNumeroHabitantes.Text.Trim() == string.Empty
                || txtRendaMedia.Text.Trim() == string.Empty)
            {
                flag = false;
                MessageBox.Show("Preencha todos os campos corretamente", "Erro");
            }
                return flag;
        }
        public void CarregarListas()
        {
             listBoxCidade.DataSource = null;
             listBoxCidade.DataSource = lstNomeCidade;
             listBoxExpansao.DataSource = null;
             listBoxExpansao.DataSource = lstExpansao;
        }
    }
}
