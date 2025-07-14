using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica.Classes;

namespace logica
{
    public partial class frmPooAtributo1: Form
    {
        public frmPooAtributo1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string nomeSetor, nomeCoordenador, nomeLider;
                int qtdColaboradores;

                nomeSetor = txtNomeSetor.Text;
                nomeCoordenador = txtNomeCoordenador.Text;
                nomeLider = txtNomeLider.Text;
                qtdColaboradores = Convert.ToInt32(txtQtd.Text);

                Mostrar(nomeSetor, nomeCoordenador, nomeLider, qtdColaboradores);
            }
        }
        public bool ValidarCampos()
        {
            bool flag = true;
            if (txtNomeSetor.Text.Trim() == string.Empty
                    || txtNomeCoordenador.Text.Trim() == string.Empty
                    || txtNomeLider.Text.Trim() == string.Empty
                    || txtQtd.Text.Trim() == string.Empty
                    )
            {
                MessageBox.Show("Preencha os campos corretamente", "Erro");
                
            }
            return flag;   
        }       
        public void Mostrar(string nome, string coordenador, string lider, int colaboradores)
        {
            Setor objSetor = new Setor(nome, coordenador, lider, colaboradores);
            MessageBox.Show( 
                $"Coordenador: {objSetor.nomeCoordenador}\n" +
                $"Líder: {objSetor.nomeLider}\n" +
                $"Colaboradores: {objSetor.qtdColaboradores}"
            );
            LimparCampos();
        }
        public void LimparCampos()
        {
            txtNomeSetor.Clear();
            txtNomeCoordenador.Clear();
            txtNomeLider.Clear();
            txtQtd.Clear();
            txtNomeSetor.Focus();
        }
    }
}
