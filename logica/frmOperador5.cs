using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logica
{
    public partial class frmOperador5: Form
    {
        public frmOperador5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txtSalarioAnterior.Text.Trim() == string.Empty || txtSalarioAtual.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher todos os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal s1, s2, a1, a2, aumento1, aumento2, sub1, sub2;
                string classificacao1 = "";
                string classificacao2 = "";
             
                
                try
                {
                    //s1 = salario anterio | s2 = salario atual
                    s1 = Convert.ToDecimal(txtSalarioAnterior.Text);
                    s2 = Convert.ToDecimal(txtSalarioAtual.Text);

                    //a1 = aumento 15% | a2 = aumento 18%
                    a1 = s1 * (1 + 15 / 100m);
                    a2 = s2 * (1 + 18 / 100m);

                    //subtracao valor do aumento - salario anterior
                    sub1 = a1 - s1;
                    sub2 = a2 - s2;

                    //valor com aumento
                    aumento1 = ( 115 / 100 ) * a1;
                    aumento2 = ( 118 / 100 ) * a2;           

                    //mostra o resultado com aumento
                    lbltexto1.Text = "Novo salário com 15% de aumento " + a1.ToString("C");
                    lbltexto2.Text = "Novo salário com 18% de aumento " + a2.ToString("C");

                    //mostra o valor de aumento (isolado)
                    label1.Text = sub1.ToString("C");
                    label2.Text = sub2.ToString("C");

                    // Tratamento classificação 15%
                    if (sub1 < 100)
                    {
                        classificacao1 = "Aumento RUIM!";
                    }
                    else if (sub1 > 101 && sub1 < 200)
                    {
                        classificacao1 = "Aumento RAZOÁVEL!";
                    }
                    else if (sub1 > 201 && sub1 < 300)
                    {
                        classificacao1 = "Aumento BOM!";
                    }
                    else if(sub1 > 301 && sub1 < 400)
                    {
                        classificacao1 = "Aumento ÓTIMO!";
                    }
                    else if(sub1 > 401)
                    {
                        classificacao1 = "Aumento EXCELENTE!";
                    }

                    //Tratamento classificação 18%
                    if (sub2 < 100)
                    {
                        classificacao2 = "Aumento RUIM!";
                    }
                    else if (sub2 > 101 && sub2 < 200)
                    {
                        classificacao2 = "Aumento RAZOÁVEL!";
                    }
                    else if (sub2 >= 201 && sub2 < 300)
                    {
                        classificacao2 = "Aumento BOM!";
                    }
                    else if (sub2 > 301 && sub2 < 400)
                    {
                        classificacao2 = "Aumento ÓTIMO!";
                    }
                    else if(sub2 > 401)
                    {
                        classificacao2 = "Aumento EXCELENTE!";
                    }


                        lblClassificacao1.Text = classificacao1;
                        lblClassificacao2.Text = classificacao2;


                }
                catch
                {
                    MessageBox.Show("Preencher somente número nos salários", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSalarioAnterior.Text = "";
            txtSalarioAtual.Text = "";
            lbltexto1.Text = "";
            lblClassificacao1.Text = "";
            label1.Text = "";
            lbltexto2.Text = "";
            lblClassificacao2.Text = "";
            label2.Text = "";
        }
    }
}
