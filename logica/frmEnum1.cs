using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logica
{
    public partial class frmEnum1 : Form
    {
        public frmEnum1()
        {
            InitializeComponent();
        }
        private enum Cores
        {
            Verde,
            Amarela,
            Vermelha 
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(ValidarCampos())
            {
                int tempoAdd = Convert.ToInt32(txtMinutos.Text.Trim());
                int corSelecionada = cbCores.SelectedIndex;
                double tempoFinal;


                switch (corSelecionada)
                {
                    case 0:
                        tempoFinal = CalcularTempoTotal(Cores.Verde, tempoAdd);  
                        exibir(tempoFinal);
                        break;
                    case 1:
                        tempoFinal = CalcularTempoTotal(Cores.Amarela, tempoAdd);
                        exibir(tempoFinal);
                        break;
                    case 2:
                        tempoFinal = CalcularTempoTotal(Cores.Vermelha, tempoAdd);
                        exibir(tempoFinal);
                        break;

                }
                

            }
        }
        private void exibir(double tempoFinal)
        {
            MessageBox.Show("Tempo: " + tempoFinal);
        }
        private bool ValidarCampos()
        {
            bool flag = true;
            //string msg = string.Empty;

            if (cbCores.Text.Trim() == "")
            {
                MessageBox.Show("Selecione uma cor", "Erro");
            }
            else if (txtMinutos.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo minuto", "Erro"); 
            }
            return flag;
        }

        private int CalcularTempoTotal(Cores cor, double tempoInicio)
        {
            int tempoAdd = 0;
            switch (cor) 
            {
                case Cores.Verde:
                    tempoAdd = 12 + (int)tempoInicio;
                    break;
                case Cores.Amarela:
                    tempoAdd = 16 + (int)tempoInicio;
                    break;
                case Cores.Vermelha:
                    tempoAdd = 42 + (int)tempoInicio; 
                    break;
            }

            return tempoAdd;

        }

     


    }
}
