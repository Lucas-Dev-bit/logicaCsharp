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
    public partial class frmCalculo2: Form
    {
        public frmCalculo2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txtGanhosJan.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Prencha o campo Ganhos do mês de Janeiro", "Falha!");
                txtGanhosJan.Clear();
                txtGanhosJan.Focus();
            }
            else if(txtGastosJaneiro.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Prencha o campo Gastos do mês de Janeiro", "Falha!");
                txtGastosJaneiro.Focus();
                txtGastosJaneiro.Clear();
            }
            else if(txtGanhosFev.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo Ganhos do mês de Fevereiro", "Falha!");
                txtGanhosFev.Focus();
                txtGanhosFev.Clear();
            }
            else if(txtGastosFev.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Prencha o campo Gastos do mês de Fevereiro", "Falha!");
                txtGastosFev.Focus();
                txtGastosFev.Clear();
            }
            else if(txtGanhosMar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo Ganhos do mês de Março", "Falha!");
                txtGanhosMar.Focus();
                txtGanhosMar.Clear();
            }
            else if(txtGastosMar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo Gastos do mês de Março", "Falha!");
                txtGastosMar.Focus();
                txtGastosMar.Clear();
            }
            else
            {
                double ganJan, gasJan, ganFev, gasFev, ganMar, gasMar, sub1, sub2, sub3, somaGanhos, somaGastos, somaLucros;

                try
                {
                    ganJan = Convert.ToDouble(txtGanhosJan.Text);
                    gasJan = Convert.ToDouble(txtGastosJaneiro.Text);
                    ganFev = Convert.ToDouble(txtGanhosFev.Text);
                    gasFev = Convert.ToDouble(txtGastosFev.Text);
                    ganMar = Convert.ToDouble(txtGanhosMar.Text);
                    gasMar = Convert.ToDouble(txtGastosMar.Text);


                    //Subtração
                    sub1 = ganJan - gasJan;
                    sub2 = ganFev - gasFev;
                    sub3 = ganMar - gasMar;

                    //RESULTADO LUCROS
                    txtLucroJan.Text = Convert.ToString(sub1);
                    txtLucroFev.Text = Convert.ToString(sub2);
                    txtLucroMar.Text = Convert.ToString(sub3);

                    //SOMA DOS LUCROS
                    somaLucros = sub1 + sub2 + sub3;
                    txtTotalLucro.Text = Convert.ToString(somaLucros);

                    //SOMA DOS GANHOS
                    somaGanhos = ganJan + ganFev + ganMar;
                    txtTotalGanhos.Text = Convert.ToString(somaGanhos);

                    //SOMA DOS GASTOS
                    somaGastos = gasJan + gasFev + gasMar;
                    txtTotalGastos.Text = Convert.ToString(somaGastos);
                }
                catch
                {
                    MessageBox.Show("Preencha somente Números nos campos", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
