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
    public partial class frmOperador6: Form
    {
        public frmOperador6()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txtVelocidade.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo Velocidade corretamente", "Error menssage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                decimal tolerancia, tolerancia1, velocidade;
                string classificacao = "";

                try
                {
                    velocidade = Convert.ToDecimal(txtVelocidade.Text);
                    //tolerancia = velocidade * (1 + 2 / 100m);

                    tolerancia1 = (velocidade * 2 ) / 100;

                    tolerancia = velocidade + tolerancia1;

                    if(tolerancia < 51)
                    {
                        classificacao = "Sem Multa";
                    }
                    else if(tolerancia >= 51 && tolerancia <= 60)
                    {
                        classificacao = "3 pontos";
                    }
                    else if(tolerancia >= 61 && tolerancia <= 70)
                    {
                        classificacao = "5 pontos";
                    }
                    else if(tolerancia >= 71 && tolerancia <= 80)
                    {
                        classificacao = "10 pontos";
                    }
                    else if(tolerancia >= 81 && tolerancia <= 90)
                    {
                        classificacao = "15 pontos";
                    }
                    else if(tolerancia >= 91 && tolerancia <= 100)
                    {
                        classificacao = "18 pontos";
                    }
                    else if (tolerancia > 101)
                    {
                        classificacao = "20 pontos e suspenção da carteira";
                    }

                    lblClassificacao.Text = "A velocidade do carro foi de: " + tolerancia + " Multa de: " + classificacao;
                         
                }

                catch
                {
                    MessageBox.Show("Preencher somente números na velocidade", "Error menssage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
