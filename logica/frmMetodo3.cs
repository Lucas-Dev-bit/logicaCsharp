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
    public partial class frmMetodo3: Form
    {
        public frmMetodo3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    double qtd1, qtd2, qtd3, qtd4, qtd5, valor1, valor2, valor3, valor4, valor5,
                        totalItem1, totalItem2, totalItem3,
                        totalItem4, totalItem5, totalGeral;

                    qtd1 = Convert.ToDouble(txtQtd1.Text);
                    qtd2 = Convert.ToDouble(txtQtd2.Text);
                    qtd3 = Convert.ToDouble(txtQtd3.Text);
                    qtd4 = Convert.ToDouble(txtQtd4.Text);
                    qtd5 = Convert.ToDouble(txtQtd5.Text);

                    valor1 = Convert.ToDouble(txtValor1.Text);
                    valor2 = Convert.ToDouble(txtValor2.Text);
                    valor3 = Convert.ToDouble(txtValor3.Text);
                    valor4 = Convert.ToDouble(txtValor4.Text);
                    valor5 = Convert.ToDouble(txtValor5.Text);

                    totalItem1 = TotalPorItem(qtd1, valor1);
                    totalItem2 = TotalPorItem(qtd2, valor2);
                    totalItem3 = TotalPorItem(qtd3, valor3);
                    totalItem4 = TotalPorItem(qtd4, valor4);
                    totalItem5 = TotalPorItem(qtd5, valor5);

                    totalGeral = TotalCompra(totalItem1, totalItem2, totalItem3, totalItem4, totalItem5);


                    MostrarResultado(totalItem1, totalItem2, totalItem3, totalItem4, totalItem5);
                    txtTotalCompra.Text = totalGeral.ToString("c2");
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

            if (txtProduto1.Text.Trim() == string.Empty
                || txtProduto2.Text.Trim() == string.Empty
                || txtProduto3.Text.Trim() == string.Empty
                || txtProduto4.Text.Trim() == string.Empty
                || txtProduto5.Text.Trim() == string.Empty
                || txtQtd1.Text.Trim() == string.Empty
                || txtQtd2.Text.Trim() == string.Empty
                || txtQtd3.Text.Trim() == string.Empty
                || txtQtd4.Text.Trim() == string.Empty
                || txtQtd5.Text.Trim() == string.Empty
                || txtValor1.Text.Trim() == string.Empty
                || txtValor2.Text.Trim() == string.Empty
                || txtValor3.Text.Trim() == string.Empty
                || txtValor4.Text.Trim() == string.Empty
                || txtValor5.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos corretamente", "Erro de NÃO preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            return flag;
        }

        private double TotalPorItem(double qtd, double valor)
        {
            double resultadoFinal;

            resultadoFinal = qtd * valor;

            return resultadoFinal;
        }

        private double TotalCompra(double total1, double total2, double total3, double total4, double total5)
        {
            double valorTotalCompra;

            valorTotalCompra = total1 + total2 + total3 + total4 + total5;

            return valorTotalCompra;
        }

        private void MostrarResultado(double totalItem1, double totalItem2, double totalItem3, double totalItem4, double totalItem5)
        {
            txtTotalItem1.Text = totalItem1.ToString("c2");
            txtTotalItem2.Text = totalItem2.ToString("c2");
            txtTotalItem3.Text = totalItem3.ToString("c2");
            txtTotalItem4.Text = totalItem4.ToString("c2");
            txtTotalItem5.Text = totalItem5.ToString("c2");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProduto1.Clear();
            txtProduto2.Clear();
            txtProduto3.Clear();
            txtProduto4.Clear();
            txtProduto5.Clear();

            txtQtd1.Clear();
            txtQtd2.Clear();
            txtQtd3.Clear();
            txtQtd4.Clear();
            txtQtd5.Clear();

            txtValor1.Clear();
            txtValor2.Clear();
            txtValor3.Clear();
            txtValor4.Clear();
            txtValor5.Clear();

            txtTotalItem1.Clear();
            txtTotalItem2.Clear();
            txtTotalItem3.Clear();
            txtTotalItem4.Clear();
            txtTotalItem5.Clear();

            txtTotalCompra.Clear();

        }
    }
}
