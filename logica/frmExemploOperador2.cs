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
    public partial class frmExemploOperador2: Form
    {
        public frmExemploOperador2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNota1.Text.Trim() == string.Empty
                || txtNota2.Text.Trim() == string.Empty
                || txtNota3.Text.Trim() == string.Empty
                || txtNota4.Text.Trim() == string.Empty)
            {
                MessageBox.Show("preencha todas as Notas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal nota1, nota2, nota3, nota4, media;
                string classificacao = "";

                try
                {
                    nota1 = Convert.ToDecimal(txtNota1.Text);
                    nota2 = Convert.ToDecimal(txtNota2.Text);
                    nota3 = Convert.ToDecimal(txtNota3.Text);
                    nota4 = Convert.ToDecimal(txtNota4.Text);

                    if (nota1 > 100 || nota1 < 0)
                    {
                        MessageBox.Show("Digitar a Nota 1 corretamente!", "Erro");
                    }
                    else if (nota2 > 100 || nota2 < 0)
                    {
                        MessageBox.Show("Digitar a Nota 2 corretamente!", "Erro");
                    }
                    else if (nota3 > 100 || nota3 < 0)
                    {
                        MessageBox.Show("Digitar a Nota 3 corretamente!", "Erro");
                    }
                    else if (nota4 > 100 || nota4 < 0)
                    {
                        MessageBox.Show("Digitar a Nota 4 corretamente!", "Erro");
                    }
                    else
                    {

                        media = (nota1 + nota2 + nota3 + nota4) / 4;

                        //verificar a classificação
                        if (media >= 0 && media < 40)
                        {
                            classificacao = "REPROVADO";
                            lblResultadoClassificacao.ForeColor = Color.Red;
                        }
                        else if (media >= 40 && media < 60)
                        {
                            classificacao = "EXAME";
                            lblResultadoClassificacao.ForeColor = Color.Orange;
                        }
                        else if (media >= 60)
                        {
                            classificacao = "APROVADO";
                            lblResultadoClassificacao.ForeColor = Color.Blue;
                        }

                        lblResultadoMedia.Text = Convert.ToString(media);
                        lblResultadoClassificacao.Text = classificacao;

                    }
                }
                catch
                {
                    MessageBox.Show("Digitar corretamente as Notas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
