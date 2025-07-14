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
    public partial class frmVariavelGlobal: Form
    {
        public frmVariavelGlobal()
        {
            InitializeComponent();
        }

        int contador = 0;
        private void btnContar_Click(object sender, EventArgs e)
        {
            Contar();
        }

        private void Contar()
        {
            contador = contador + 1;
            lblContador.Text = contador.ToString();
        }
    }
}
