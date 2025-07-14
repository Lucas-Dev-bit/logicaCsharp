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
    public partial class frmMetodoMediaAritmetica: Form
    {
        public frmMetodoMediaAritmetica()
        {
            InitializeComponent();
        }

        #region Eventos

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                decimal nota1, nota2, nota3, nota4, media;
                string classificacao = "";

                try
                {
                    nota1 = Convert.ToDecimal(txtNota1.Text);
                    nota2 = Convert.ToDecimal(txtNota2.Text);
                    nota3 = Convert.ToDecimal(txtNota3.Text);
                    nota4 = Convert.ToDecimal(txtNota4.Text);

                    if( VerificarDigitoNotas(nota1, nota2, nota3, nota4))
                    {
                        media = CalcularMedia(nota1, nota2, nota3, nota4);
                        classificacao = VerificarClassificacao(media);
                        MostrarResultado(media, classificacao);
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Digitar corretamente as notas.", "Erro");
                }
            }
        }
        #endregion


        #region Métodos Privados

        /// <summary>
        /// Verifica a margem da notra digitada entre 0 e 10
        /// </summary>
        /// <param name="nota1">Nota 1 do aluno</param>
        /// <param name="nota2">Nota 2 do aluno</param>
        /// <param name="nota3">Nota 3 do aluno</param>
        /// <param name="nota4">Nota 4 do aluno</param>
        /// <returns>Retorna falso quando estiver irregular</returns>
        private bool VerificarDigitoNotas(decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
            bool flag = true;
            
            if (nota1 > 100 || nota1 < 0)
            {
                MessageBox.Show("Digitar a Nota 1 corretamente!", "Erro");
                flag = false;
            }
            else if (nota2 > 100 || nota2 < 0)
            {
                MessageBox.Show("Digitar a Nota 2 corretamente!", "Erro");
                flag = false;
            }
            else if (nota3 > 100 || nota3 < 0)
            {
                MessageBox.Show("Digitar a Nota 3 corretamente!", "Erro");
                flag = false;
            }
            else if (nota4 > 100 || nota4 < 0)
            {
                MessageBox.Show("Digitar a Nota 4 corretamente!", "Erro");
                flag = false;
            }

            return flag;

        }


        /// <summary>
        /// Verifica os campos
        /// </summary>
        /// <returns>Retorna falso quando estiver irregular</returns>
        private bool ValidarCampos()
        {
            bool flag = true;

            if(txtNota1.Text.Trim() == string.Empty 
              || txtNota2.Text.Trim() == string.Empty 
              || txtNota3.Text.Trim() == string.Empty
              || txtNota4.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher todas as notas.", "Erro menssagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }

            return flag;

        }

        /// <summary>
        /// Calcula a media do aluno
        /// </summary>
        /// <param name="nota1">Nota 1 do aluno</param>
        /// <param name="nota2">Nota 2 do aluno</param>
        /// <param name="nota3">Nota 3 do aluno</param>
        /// <param name="nota4">Nota 4 do aluno</param>
        /// <returns>Retorna a média do aluno</returns>
        private decimal CalcularMedia(decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
            decimal media;

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            return media;
        }
   
        /// <summary>
        /// Verifica a classificação do aluno
        /// </summary>
        /// <param name="media">Verifica a classificação do aluno</param>
        /// <returns></returns>
        private String VerificarClassificacao(decimal media)
        {
            string classificacao = "";

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

            return classificacao;
        }
    
        /// <summary>
        /// Mostra o resultado final nas labels
        /// </summary>
        /// <param name="media">Valor da média do aluno</param>
        /// <param name="classificacao">Valor da classificação do aluno</param>
        private void MostrarResultado(decimal media, string classificacao)
        {
            lblResultadoClassificacao.Text = classificacao;
            lblResultadoMedia.Text = media.ToString();
        }

        #endregion
    }
}
