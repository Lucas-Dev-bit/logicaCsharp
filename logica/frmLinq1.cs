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
    public partial class frmLinq1 : Form
    {
        public frmLinq1()
        {
            InitializeComponent();
        }

        List<int> lstNumeroAdidas = new List<int>();
        List<int> lstNumeroNike = new List<int>();
        private enum Marca
        {
            Adidas,
            Nike
        }
        private enum Filtro
        {
            Acima,
            Igual,
            Abaixo
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int numero;
            try
            {
                numero = Convert.ToInt32(txtNumero.Text);

                switch (cbMarca.SelectedIndex)
                {
                    case 0:
                        AdicionarMarca(Marca.Adidas, numero);
                        CarregarMarca(Marca.Adidas);
                        LimparCampos();

                        break;
                    case 1:
                        AdicionarMarca(Marca.Nike, numero);
                        CarregarMarca(Marca.Nike);
                        LimparCampos();
                        break;

                }
            }
            catch
            {
                MessageBox.Show("Informar o número");
            }


        }
        private void AdicionarMarca(Marca filtro, int numero)
        {
            switch (filtro)
            {
                case Marca.Adidas:
                    lstNumeroAdidas.Add(numero);
                    break;
                case Marca.Nike:
                    lstNumeroNike.Add(numero);
                    break;

            }
        }
        private void CarregarMarca(Marca filtro)
        {
            switch (filtro)
            {
                case Marca.Adidas:
                    listBoxAdidas.DataSource = null;
                    listBoxAdidas.DataSource = lstNumeroAdidas;
                    break;
                case Marca.Nike:
                    listBoxNike.DataSource = null;
                    listBoxNike.DataSource = lstNumeroNike;
                    break;

            }
        }
        private void LimparCampos()
        {
            txtNumero.Clear();
            txtNumero.Focus();
          
        }
        private void btnLinqConsulta_Click(object sender, EventArgs e)
        {
            int numero;
            int FiltroMarca = cbFiltroMarca.SelectedIndex;
            int FiltroTamanho = cbFiltroTamanho.SelectedIndex;
            try
            {
                numero = Convert.ToInt32(txtNumeroReferencia.Text);
                switch (FiltroMarca)
                {
                    case 0://ADIDAS
                        switch (FiltroTamanho)
                        {
                            case 0:
                                MostrarSintaxConsulta(numero, Marca.Adidas, Filtro.Acima);
                                break;
                            case 1:
                                MostrarSintaxConsulta(numero, Marca.Adidas, Filtro.Igual);
                                break;
                            case 2:
                                MostrarSintaxConsulta(numero, Marca.Adidas, Filtro.Abaixo);
                                break;
                        }
                        break;


                    case 1: //NIKE
                        switch (FiltroTamanho)
                        {
                            case 0:
                                MostrarSintaxConsulta(numero, Marca.Nike, Filtro.Acima);
                                break;
                            case 1:
                                MostrarSintaxConsulta(numero, Marca.Nike, Filtro.Igual);
                                break;
                            case 2:
                                MostrarSintaxConsulta(numero, Marca.Nike, Filtro.Abaixo);
                                break;
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Preencher todos os campos corretamente", "erro");
            }
        }
        private void btnLinqMetodo_Click(object sender, EventArgs e)
        {
            int numero; 
            int FiltroMarca = cbFiltroMarca.SelectedIndex;
            int FiltroTamanho = cbFiltroTamanho.SelectedIndex;
            try
            {
                numero = Convert.ToInt32(txtNumeroReferencia.Text);
                switch (FiltroMarca)
                {
                    case 0://ADIDAS
                        switch (FiltroTamanho)
                        {
                            case 0:
                                MostrarSintaxMetodo(numero, Marca.Adidas, Filtro.Acima);
                                break;
                            case 1:
                                MostrarSintaxMetodo(numero, Marca.Adidas, Filtro.Igual);
                                break;
                            case 2:
                                MostrarSintaxMetodo(numero, Marca.Adidas, Filtro.Abaixo);
                                break;
                        }                
                     break;

                    case 1://NIKE
                        switch (FiltroTamanho)
                        {
                            case 0:
                                MostrarSintaxMetodo(numero, Marca.Nike, Filtro.Acima);
                                break;
                            case 1:
                                MostrarSintaxMetodo(numero, Marca.Nike, Filtro.Igual);
                                break;
                            case 2:
                                MostrarSintaxMetodo(numero, Marca.Nike, Filtro.Abaixo);
                                break;
                        }

                    break;
                }
                
            }
            catch
            {
                MessageBox.Show("teste de erro");
            }
           

        }
        private void MostrarSintaxConsulta(double numero, Marca marca, Filtro comparacao)
        {
            int filtroMarca = cbFiltroMarca.SelectedIndex;
            int filtroComparacao = cbFiltroTamanho.SelectedIndex;

            try
            {
                switch (filtroMarca)
                {
                    case 0:
                        switch (filtroComparacao)
                        {
                            case 0:
                                PesquisarSintaxConsultaAdidas(Filtro.Acima, numero);
                                break;
                            case 1:
                                PesquisarSintaxConsultaAdidas(Filtro.Igual, numero);
                                break;
                            case 2:
                                PesquisarSintaxConsultaAdidas(Filtro.Abaixo, numero);
                                break;
                            
                        }
                        break;

                    case 1:
                        switch (filtroComparacao)
                        {
                            case 0:
                                PesquisarSintaxConsultaNike(Filtro.Acima, numero);
                                break;
                            case 1:
                                PesquisarSintaxConsultaNike(Filtro.Igual, numero);
                                break;
                            case 2:
                                PesquisarSintaxConsultaNike(Filtro.Abaixo, numero);
                                break;
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Preencher todos os campos", "erro");
            }

        }
        private void MostrarSintaxMetodo(double numero, Marca Marca, Filtro Comparacao)
        {
            //double numero;
            int filtroMarca = cbFiltroMarca.SelectedIndex;
            int filtroComparacao = cbFiltroTamanho.SelectedIndex;

            try
            {
                //numero = Convert.ToDouble(txtNumeroReferencia.Text);

                switch (filtroMarca)
                {
                    case 0:
                        switch (filtroComparacao)
                        {
                            case 0:
                                PesquisarSintaxMetodoAdidas(Filtro.Acima, numero);
                                break;

                            case 1:
                                PesquisarSintaxMetodoAdidas(Filtro.Igual, numero);
                                break;

                            case 2:
                                PesquisarSintaxMetodoAdidas(Filtro.Abaixo, numero);
                                break;

                        }
                        break;
                    case 1:
                        switch (filtroComparacao)
                        {
                            case 0:
                                PesquisarSintaxMetodoNike(Filtro.Acima, numero);
                                break;
                            case 1:
                                PesquisarSintaxMetodoNike(Filtro.Igual, numero);
                                break;
                            case 2:
                                PesquisarSintaxMetodoNike(Filtro.Abaixo, numero);
                                break;
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Preencher os campos corretamente", "erro");
            }
        }
        private void PesquisarSintaxMetodoAdidas(Filtro filtro, double numero)
        {
            listBoxAdidas.DataSource = null;

            switch (filtro)
            {
                case Filtro.Acima:
                    listBoxAdidas.DataSource = lstNumeroAdidas.Where(item => item > numero).ToList();
                    break;

                case Filtro.Igual:
                    listBoxAdidas.DataSource = lstNumeroAdidas.Where(item => item == numero).ToList();
                    break;

                case Filtro.Abaixo:
                    listBoxAdidas.DataSource = lstNumeroAdidas.Where(item => item < numero).ToList();
                    break;
            }
        }
        private void PesquisarSintaxMetodoNike(Filtro filtro, double numero)
        {
            listBoxNike.DataSource = null;

            switch (filtro)
            {
                case Filtro.Acima:
                    listBoxNike.DataSource = lstNumeroNike.Where(item => item > numero).ToList();
                    break;

                case Filtro.Igual:
                    listBoxNike.DataSource = lstNumeroNike.Where(item => item == numero).ToList();
                    break;

                case Filtro.Abaixo:
                    listBoxNike.DataSource = lstNumeroNike.Where(item => item < numero).ToList();
                    break;
            }
        }
        private void PesquisarSintaxConsultaAdidas(Filtro filtro, double numero)
        {
            listBoxAdidas.DataSource = null;

            switch (filtro)
            {
                case Filtro.Acima:
                    listBoxAdidas.DataSource = (from item in lstNumeroAdidas
                                                where item > numero
                                                select item).ToList();
                    break;
                case Filtro.Igual:
                    listBoxAdidas.DataSource = (from item in lstNumeroAdidas
                                                where item == numero
                                                select item).ToList();
                    break;
                case Filtro.Abaixo:
                    listBoxAdidas.DataSource = (from item in lstNumeroAdidas
                                                where item < numero
                                                select item).ToList();
                    break;
            }
        }
        private void PesquisarSintaxConsultaNike(Filtro filtro, double numero)
        {
            listBoxNike.DataSource = null;

            switch (filtro)
            {
                case Filtro.Acima:
                    listBoxNike.DataSource = (from item in lstNumeroNike
                                              where item > numero
                                              select item).ToList();
                    break;
                case Filtro.Igual:
                    listBoxNike.DataSource = (from item in lstNumeroNike
                                              where item == numero
                                              select item).ToList();
                    break;
                case Filtro.Abaixo:
                    listBoxNike.DataSource = (from item in lstNumeroNike
                                              where item < numero
                                              select item).ToList();
                    break;

            }
        }
    }
}
