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
    public partial class frmListaExemplo1: Form
    {
        public frmListaExemplo1()
        {
            InitializeComponent();
        }

        List<int> lstNumeros = new List<int>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            AdicionarNumero(numero);
            CarregarLista();
            txtNumero.Clear();
            
        }

        private void AdicionarNumero(int numero)
        {
            lstNumeros.Add(numero);
        }
        private void CarregarLista()
        {
            listNumeros.DataSource = null;
            listNumeros.DataSource = lstNumeros;
        }

        private void MostarListaPares() //LINQ - EXEMPLO COM SINTAXE DE CONSULTA
        {
            var resultado = from numero in lstNumeros
                            where numero % 2 == 0
                            select numero;
            listNumeros.DataSource = null;
            listNumeros.DataSource = resultado.ToList();
        }

        private void MostrarListaParesLambda() //LINQ - EXEMPLO COM SINTAXE DE MÉTODO
        {
            var resultado = lstNumeros.Where(numero => numero % 2 == 0);
            listNumeros.DataSource = null;
            listNumeros.DataSource = resultado.ToList();
                            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            lstNumeros.Remove(numero);
            CarregarLista();
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(txtRemoveAt.Text);
            lstNumeros.RemoveAt(index);
            CarregarLista();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lstNumeros.Sort();
            CarregarLista();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            lstNumeros.Sort();
            lstNumeros.Reverse();
            CarregarLista();
        }

        private void btnLinqConsulta_Click(object sender, EventArgs e)
        {
            MostarListaPares();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarListaParesLambda();
        }

        private void btnSemFiltro_Click(object sender, EventArgs e)
        {
            CarregarLista();
        }
    }
}
