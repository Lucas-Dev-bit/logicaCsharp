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
    public partial class frmLacoFor: Form
    {
        public frmLacoFor()
        {
            InitializeComponent();
        }

        private void btnRepetir_Click(object sender, EventArgs e)
        {
            int qtd = Convert.ToInt32(txtQtd.Text);
            string frase = txtFrase.Text;

            Repetir(qtd, frase);
        }

        private void Repetir(int qtd, string frase)
        {
            for(int i = 0; i < qtd; i++)
            {
                MessageBox.Show(frase);
            }
        }
    }
}
