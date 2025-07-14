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
    public partial class frmPooAtributo: Form
    {
        public frmPooAtributo()
        {
            InitializeComponent();
        }
         
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Aluno objAluno = new Aluno(txtNome.Text, txtTelefone.Text);
             

            MessageBox.Show($"Nome: { objAluno.Nome} \nseu telefone: {objAluno.Telefone}  ");
        }
    }
}
