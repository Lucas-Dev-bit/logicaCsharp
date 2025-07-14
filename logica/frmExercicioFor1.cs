using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logica
{
    public partial class frmExercicioFor1: Form
    {
        public frmExercicioFor1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {

            int qtd = Convert.ToInt32(txtQtd.Text);
            Contagem(qtd);
        }

        private void Contagem(int qtd)
        {
            listContagem.Items.Clear();
            for(int i = qtd; i >= 0; i--)
            {
                listContagem.Items.Add(i);
            }
        }
    }
}
