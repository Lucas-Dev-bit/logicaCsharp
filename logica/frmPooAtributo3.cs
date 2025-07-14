using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica.Classes;


namespace logica
{
    public partial class frmPooAtributo3 : Form
    {
        public frmPooAtributo3()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            bool flag = true;
            if (txtPassageiro.Text.Trim() == string.Empty
                || txtDestino.Text.Trim() == string.Empty
                
                || txtValor.Text.Trim() == string.Empty)
            {
                flag = false;
                MessageBox.Show("Preencha os campos corretamente", "Erro");
            }

            return flag;
        }







        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                string nomePassageiro, destinoViagem;
                DateTime data; 
                decimal valor;

                nomePassageiro = txtPassageiro.Text;
                destinoViagem = txtDestino.Text;
                data = dtpData.Value;

                valor = Convert.ToDecimal(txtValor.Text);

                Mostrar(destinoViagem, nomePassageiro, valor, data);
            }

        }

        private void Mostrar(string destino, string nomePassageiro, decimal valor, DateTime data)
        {
            Viagem objViagem = new Viagem(destino);

            objViagem.NomePassageiro = nomePassageiro;
            objViagem.Data = data;
            objViagem.Valor = valor;


            MessageBox.Show($"Passageiro: {nomePassageiro} \n Destino: {objViagem.DestinoViagem} \n" +
                    $"Data: {data} \n Valor: {valor} ");
        }

        private void LimparCampos()
        {
           
            txtDestino.Clear();
            txtPassageiro.Clear();
            txtValor.Clear();
            txtPassageiro.Focus();
        }
        private void Cancelar()
        {
        
            txtDestino.Clear();
            txtPassageiro.Clear();
            txtValor.Clear();
        }
    }
}
