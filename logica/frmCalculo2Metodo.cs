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
    public partial class frmCalculo2Metodo: Form
    {
        public frmCalculo2Metodo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                double ganho1, ganho2, ganho3, ganho4, ganho5, ganho6, 
                       ganho7, ganho8, ganho9, ganho10, ganho11, ganho12,
                       gasto1, gasto2, gasto3, totalGanhos, totalGastos, somaTotalLucros, somaMes1, somaMes2, somaMes3;

                try
                {
                    ganho1 = Convert.ToDouble(txtGanhosJan.Text);
                    ganho2 = Convert.ToDouble(txtGanhosFev.Text);
                    ganho3 = Convert.ToDouble(txtGanhosMar.Text);
                    ganho4 = Convert.ToDouble(txtGanhosAbr.Text);
                    ganho5 = Convert.ToDouble(txtGanhosMai.Text);
                    ganho6 = Convert.ToDouble(txtGanhosJun.Text);
                    ganho7 = Convert.ToDouble(txtGanhosJul.Text);
                    ganho8 = Convert.ToDouble(txtGanhosAgo.Text);
                    ganho9 = Convert.ToDouble(txtGanhosSet.Text);
                    ganho10 = Convert.ToDouble(txtGanhosOut.Text);
                    ganho11 = Convert.ToDouble(txtGanhosNov.Text);
                    ganho12 = Convert.ToDouble(txtGanhosDez.Text);


                    gasto1 = Convert.ToDouble(txtGastosJaneiro.Text);
                    gasto2 = Convert.ToDouble(txtGastosFev.Text);
                    gasto3 = Convert.ToDouble(txtGastosMar.Text);

                    somaMes1 = ganho1 - gasto1;
                    somaMes2 = ganho2 - gasto2;
                    somaMes3 = ganho3 - gasto3;

                    totalGanhos = ganhosAno(ganho1, ganho2, ganho3, ganho4, ganho5, ganho6, ganho7, ganho8, ganho9, ganho10, ganho11, ganho12);
                    totalGastos = gastosAno(gasto1, gasto2, gasto3);

                    somaTotalLucros = SomaTotalLucros(totalGanhos, totalGastos);

                    mostrarResultado(totalGanhos, totalGastos, somaTotalLucros);

                    txtLucroJan.Text = Convert.ToString(somaMes1);
                    txtLucroFev.Text = Convert.ToString(somaMes2);
                    txtLucroMar.Text = Convert.ToString(somaMes3);

                }
                catch
                {   
                    MessageBox.Show("Preencher todos os campos");
                }
            }
        }

        private bool ValidarCampos()
        {
            bool flag = true;

            if(txtGanhosJan.Text.Trim() == string.Empty
                || txtGanhosFev.Text.Trim() == string.Empty
                || txtGanhosMar.Text.Trim() == string.Empty
                || txtGanhosAbr.Text.Trim() == string.Empty
                || txtGanhosMai.Text.Trim() == string.Empty
                || txtGanhosJun.Text.Trim() == string.Empty
                || txtGanhosJul.Text.Trim() == string.Empty
                || txtGanhosAgo.Text.Trim() == string.Empty
                || txtGanhosSet.Text.Trim() == string.Empty
                || txtGanhosOut.Text.Trim() == string.Empty
                || txtGanhosNov.Text.Trim() == string.Empty
                || txtGanhosDez.Text.Trim() == string.Empty
                || txtGastosJaneiro.Text.Trim() == string.Empty
                || txtGastosFev.Text.Trim() == string.Empty
                || txtGastosMar.Text.Trim() == string.Empty
                || txtGastosAbr.Text.Trim() == string.Empty
                || txtGastosMai.Text.Trim() == string.Empty
                || txtGastosJun.Text.Trim() == string.Empty
                || txtGastosJul.Text.Trim() == string.Empty
                || txtGastosAgo.Text.Trim() == string.Empty
                || txtGastosSet.Text.Trim() == string.Empty
                || txtGastosOut.Text.Trim() == string.Empty
                || txtGastosNov.Text.Trim() == string.Empty
                || txtGastosDez.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencher todos os campos", "Erro");
                flag = false;
            }

            return flag;

        }

       
        private double ganhosAno(double ganho1, double ganho2, double ganho3, double ganho4, double ganho5, 
            double ganho6, double ganho7, double ganho8, double ganho9, double ganho10, double ganho11, double ganho12)

        {
            double resultadoFinal;

            resultadoFinal = ganho1 + ganho2 + ganho3 + ganho4 + ganho5 + ganho6 + ganho7 + ganho8 + ganho9 + ganho10 + ganho11 + ganho12;

            return resultadoFinal;
        }

        private double gastosAno(double gasto1, double gasto2, double gasto3)
        {
            double resultadoFinal;

            resultadoFinal = gasto1 + gasto2 + gasto3;

            return resultadoFinal;
        }

        private double SomaTotalLucros(double GanhosAno, double GastosAno)
        {
            double resultadoFinalLucro;

            resultadoFinalLucro = GanhosAno - GastosAno;

            return resultadoFinalLucro;
        }

        private void mostrarResultado(double valorGanhosAno, double valorGastosAno, double valorLucroAno)
        {
            txtTotalGanhos.Text = valorGanhosAno.ToString("c");
            txtTotalGastos.Text = valorGastosAno.ToString("c");
            txtTotalLucro.Text = valorLucroAno.ToString("c");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtGanhosJan.Clear();
            txtGanhosFev.Clear();
            txtGanhosMar.Clear();
            txtGanhosAbr.Clear();
            txtGanhosMai.Clear();
            txtGanhosJun.Clear();
            txtGanhosJul.Clear();
            txtGanhosAgo.Clear();
            txtGanhosSet.Clear();
            txtGanhosOut.Clear();
            txtGanhosNov.Clear();
            txtGanhosDez.Clear();
            txtGastosJaneiro.Clear();
            txtGastosFev.Clear();
            txtGastosMar.Clear();
            txtGastosAbr.Clear();
            txtGastosMai.Clear();
            txtGastosJun.Clear();
            txtGastosJul.Clear();
            txtGastosAgo.Clear();
            txtGastosSet.Clear();
            txtGastosOut.Clear();
            txtGastosNov.Clear();
            txtGastosDez.Clear();
            txtTotalGanhos.Clear();
            txtTotalGastos.Clear();
            txtTotalLucro.Clear();
            txtLucroJan.Clear();
            txtLucroFev.Clear();
            txtLucroMar.Clear();
            txtLucroAbr.Clear();
            txtLucroMai.Clear();
            txtLucroJun.Clear();
            txtLucroJul.Clear();
            txtLucroAgo.Clear();
            txtLucroSet.Clear();
            txtLucroOut.Clear();
            txtLucroNov.Clear();
            txtLucroDez.Clear();
        }
    }
}
