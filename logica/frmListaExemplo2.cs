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
    public partial class frmListaExemplo2: Form
    {
        public frmListaExemplo2()
        {
            InitializeComponent();
        }

        List<int> lstPares = new List<int>();
        List<int> lstImpares = new List<int>();

        private void VerificarAdd(int numero)
        {
            if(numero % 2 == 0)
            {
                AddPares(numero);
                CarregarListaPares();
            }
            else
            {
                AddImpares(numero);
                CarregarListaImpares();
            }
        }

        private void CarregarListaPares()
        {
            listPares.DataSource = null;
            listPares.DataSource = lstPares;
        }

        private void CarregarListaImpares()
        {
            listImpares.DataSource = null;
            listImpares.DataSource = lstImpares;
        }

        private void AddPares(int numero)
        {
            lstPares.Add(numero);
        }

        private void AddImpares(int numero)
        {
            lstImpares.Add(numero);
        }

        private void LimparCampo()
        {
            txtNumero.Clear();
            txtNumero.Focus();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);

            VerificarAdd(numero);
            LimparCampo();
        }
    }
}
