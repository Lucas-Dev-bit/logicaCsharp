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
    public partial class frmTabuada: Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int tabuada = Convert.ToInt32(txtTabuada.Text);
            int irAte = Convert.ToInt32(txtIrAte.Text);

            CalcularTabuada(tabuada, irAte);

            
        }

        private void CalcularTabuada(int tabuada, int irAte)
        {
            listTabuada.Items.Clear();
            for(int i = 1; i <= irAte; i++)
            {
                listTabuada.Items.Add(tabuada + " x " + i + " = " + (tabuada * i));
            }
        }
    }
}
