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
    public partial class frmQuestionario: Form
    {
        public frmQuestionario()
        {
            InitializeComponent();
        }

        #region VARIAVEIS GLOBAIS

        int contarAcertos = 0;
        int contarErros = 0;

        #endregion

        #region ENUM
        private enum Classificacao
        {
            Excelente = 3,
            Bom = 2,
            Ruim = 1,
            Pessimo = 0
        }

        private enum Resposta
        {
            Acerto,
            Erro
        }

        private enum Questionario
        {
            Pergunta1,
            Pergunta2,
            Pergunta3
        }
        #endregion

        #region METODOS PRIVADOS

        private void Pontuar(Resposta resposta)
        {
            switch (resposta)
            {
                case Resposta.Acerto:
                    ContarAcertos();
                    break;
                case Resposta.Erro:
                    ContarErros();
                    break;
            }
        }
        private void MostrarResultadoFinal(int pontuacaoFinal, string classificacao)
        {
            MessageBox.Show("Sua pontuação foi: " + pontuacaoFinal + "\nSua Classificação foi: " + classificacao);
        }
        private string VerificarClassificacao(int pontuacaoFinal)
        {
            string classificacao = "";

            switch (pontuacaoFinal)
            {
                
                case (int)Classificacao.Excelente:
                    classificacao = "Excelente";
                    break;

                case (int)Classificacao.Bom:
                    classificacao = "Bom";
                    break;

                case (int)Classificacao.Ruim:
                    classificacao = "Ruim";
                    break;
                default:
                    classificacao = "Péssimo";
                    break;

            }
            return classificacao;
        }
        private int ContabilizarResultado()
        {
            int resultado;

            resultado = contarAcertos - contarErros;

            return resultado;
        }
        private bool VerificarMarcacoes(Questionario pergunta)
        {
          bool flag = true;

            switch (pergunta)
            {
                case Questionario.Pergunta1:
                    if(!rb1_1.Checked && !rb1_2.Checked && !rb1_3.Checked)
                    {
                        
                        flag = false;
                    }
                    break;

                case Questionario.Pergunta2:
                    if(!rb2_1.Checked && !rb2_2.Checked && !rb2_3.Checked)
                    {
                        flag = false;
                    }
                    break;

                case Questionario.Pergunta3:
                    if(!rb3_1.Checked && !rb3_2.Checked && !rb3_3.Checked)
                    {
                        flag = false;
                    }
                    break;
            }

            if (!flag)
            {
                MessageBox.Show("é necessário selecionar uma resposta");
            }

            return flag;
        }
        private void VerificarPergunta(Questionario pergunta)
        {
            switch (pergunta)
            {
                case Questionario.Pergunta1:
                    if (rb1_3.Checked)
                    {
                        Pontuar(Resposta.Acerto);
                        IrParaPergunta(Questionario.Pergunta2);
                    }
                    else
                    {
                        Pontuar(Resposta.Erro);

                    }
                    break;

                case Questionario.Pergunta2:
                    if (rb2_3.Checked)
                    {
                        Pontuar(Resposta.Acerto);
                        IrParaPergunta(Questionario.Pergunta3);
                    }
                    else
                    {
                        Pontuar(Resposta.Erro);
                    }
                    break;

                case Questionario.Pergunta3:
                    if (rb3_1.Checked)
                    {
                        int pontuacaoFinal;
                        string classificacao;
                        Pontuar(Resposta.Acerto);
                        pontuacaoFinal = ContabilizarResultado();
                        classificacao = VerificarClassificacao(pontuacaoFinal);
                        MostrarResultadoFinal(pontuacaoFinal, classificacao);
                        contarAcertos = 0;
                        contarErros = 0;
                        lblAcertos.Text = "0";
                        lblErros.Text = "0";
                        
                        IrParaPergunta(Questionario.Pergunta1);
                      
                    }
                    else
                    {
                        Pontuar(Resposta.Erro);
                    }
                    break;
            }
        }
        private void ContarAcertos()
        {
            contarAcertos++;
            lblAcertos.Text = contarAcertos.ToString();
        }
        private void ContarErros()
        {
            contarErros++;
            lblErros.Text = contarErros.ToString();
        }
        private void IrParaPergunta(Questionario pergunta)
        {
            switch(pergunta)
            {
                case Questionario.Pergunta1:
                    gbPergunta1.Visible = true;
                    gbPergunta2.Visible = false;
                    gbPergunta3.Visible = false;
                    break;

                case Questionario.Pergunta2:
                    gbPergunta1.Visible = false;
                    gbPergunta2.Visible = true;
                    gbPergunta3.Visible = false;
                    break;

                case Questionario.Pergunta3:
                    gbPergunta1.Visible = false;
                    gbPergunta2.Visible = false;
                    gbPergunta3.Visible = true;
                    break;

            }
        }

        #endregion

        #region EVENTOS

        private void frmQuestionario_Load(object sender, EventArgs e)
        {
            IrParaPergunta(Questionario.Pergunta1);
        }

        private void btnResponder1_Click(object sender, EventArgs e)
        {
           if(VerificarMarcacoes(Questionario.Pergunta1)){
                VerificarPergunta(Questionario.Pergunta1);
            }
        }

        private void btnResponder2_Click(object sender, EventArgs e)
        {
            if (VerificarMarcacoes(Questionario.Pergunta2))
            {
                VerificarPergunta(Questionario.Pergunta2);
            }
        }

        private void btnResponder3_Click(object sender, EventArgs e)
        {
            if (VerificarMarcacoes(Questionario.Pergunta3))
            {
                VerificarPergunta(Questionario.Pergunta3);
            }
        }

        #endregion
    }
}
