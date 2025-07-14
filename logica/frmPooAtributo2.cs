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
    public partial class frmPooAtributo2: Form
    {
        public frmPooAtributo2()
        {
            InitializeComponent();
        }

        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
          
                string escola, diretor;
                int professores, alunos;


                escola = txtNomeEscola.Text;
                diretor = txtNomeDiretor.Text;
                professores = Convert.ToInt32(txtQtdProfessores.Text);
                alunos = Convert.ToInt32(txtQtdAlunos.Text);

                Mostrar(escola, diretor, professores, alunos);
            }
            
        }
        public bool ValidarCampos()
        {
            bool flag = true;

            if(txtNomeEscola.Text.Trim() == string.Empty
                || txtNomeDiretor.Text.Trim() == string.Empty
                || txtQtdProfessores.Text.Trim() == string.Empty
                || txtQtdAlunos.Text.Trim() == string.Empty)
            {
                flag = false;
                MessageBox.Show("Preencha todos os campos corretamente", "Erro");
            }

            return flag;
        }

        public void Mostrar(string escola, string diretor, int professores, int alunos)
        {
            Escola objEscola = new Escola(professores, alunos);

            objEscola.NomeDiretor = diretor;
            objEscola.NomeEscola = escola;

            MessageBox.Show($" Escola: {objEscola.NomeEscola} \n Diretor: {objEscola.NomeDiretor} " +
                $"\n Professores: {objEscola.QtdProfessores} \n Alunos: {objEscola.QtdAlunos}");
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtNomeEscola.Clear();
            txtNomeDiretor.Clear();
            txtQtdProfessores.Clear();
            txtQtdAlunos.Clear();
            txtNomeEscola.Focus();
        }
        public void Cancelar()
        {
            txtNomeEscola.Clear();
            txtNomeDiretor.Clear();
            txtQtdProfessores.Clear();
            txtQtdAlunos.Clear();
        }
    }
}
