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
    public partial class frmExercicioEmAulaListGenerics: Form
    {
        public frmExercicioEmAulaListGenerics()
        {
            InitializeComponent();
        }

        List<string> lstPratos = new List<string>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string prato = Convert.ToString(txtPrato.Text);
            

            AdicionarPratos(prato);
            CarregarPratos();
            limparCampos();
        }

        private void AdicionarPratos(string nome)
        {
            lstPratos.Add(nome);
        }

        private void limparCampos()
        {
            txtPrato.Clear();
           

        }

        private void CarregarPratos()
        {
            listBoxPratos.DataSource = null;
            listBoxPratos.DataSource = lstPratos;
        }
    }
}
