using logica.Properties;
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
    public partial class frmOperador4: Form
    {
        public frmOperador4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            pbImagem.Image = null;

            if(txtAltura.Text.Trim() == string.Empty || txtPeso.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal altura, peso, imc;
                string Classificacao = "";

                altura = Convert.ToDecimal(txtAltura.Text);
                peso = Convert.ToDecimal(txtPeso.Text);
                

                imc = peso / (altura * altura);

                try
                {
                    if (imc <= 20)
                    {
                        Classificacao = "MAGRO";
                        pbImagem.Image = Resources.magro;
                        
                        
                    }
                    else if (imc >= 21 && imc < 26)
                    {
                        Classificacao = "PESO IDEAL";
                        pbImagem.Image = Resources.pesoIdeal;
                    }
                    else if (imc >= 26 && imc <= 30)
                    {
                        Classificacao = "OBESO";
                        pbImagem.Image = Resources.obeso;
                        
                    }
                    else if (imc > 30)
                    {
                        Classificacao = "MUITO OBESO";

                        pbImagem.Image = Resources.muitoObeso;
                    }

                    lblResultado1.Text = Convert.ToString(imc);
                    lblClassificacao1.Text = Classificacao;

                }
                catch
                {
                    MessageBox.Show("Preencha todos os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
