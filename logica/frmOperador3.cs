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
    public partial class frmOperador3: Form
    {
        public frmOperador3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try {
                if (txtSalario.Text.Trim() == string.Empty || txtAumento.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Preencha todos os campoes corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToDecimal(txtSalario.Text) <= 0 || Convert.ToDecimal(txtAumento.Text) <= 0)
                {
                    MessageBox.Show("Os valores não podem ser negativos ou 0");
                
                }

                else
                {
                    decimal salario, aumento, novoSalario, salarioReal;


                    salario = Convert.ToDecimal(txtSalario.Text);
                    aumento = Convert.ToDecimal(txtAumento.Text);
                    aumento = aumento / 100;
                    novoSalario = salario * aumento;
                    salarioReal = salario + novoSalario;

                    if (novoSalario < 101)
                    {
                        MessageBox.Show("Aumento Nível 1", "Menssagem");
                    }
                    else if (novoSalario > 101 && novoSalario < 201)
                    {
                        MessageBox.Show("Aumento Nível 2", "Menssagem");
                    }
                    else if (novoSalario >= 201 && novoSalario < 301)
                    {
                        MessageBox.Show("Aumento Nível 3", "Menssagem");
                    }
                    else if (novoSalario >= 301 && novoSalario <= 400)
                    {
                        MessageBox.Show("Aumento Nível 4", "Menssagem");
                    }
                    else
                    {
                        MessageBox.Show("Acima de 400", "Menssagem");
                    }

                    txtNovoSalario.Text = Convert.ToString(salarioReal);
                }
               } 
                catch
                {
                txtSalario.Focus();
                txtSalario.Clear();
                txtAumento.Clear();
                MessageBox.Show("Preencha todos os campoes corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            }
        }
    }

