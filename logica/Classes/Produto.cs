using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.Classes
{
    public class Produto
    {
        public enum Categoria
        {
            ELETRONICOS = 0,
            ALIMENTOS = 1,
            VESTUARIO = 2
            ///por boas praticas, já deixa atribuido um valor.
        }

        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public string CategoriaProduto { get; set; } // para exibir na datagridViwe
        public Categoria CategoriaValor { get; set; } // valor do ENUM, quando selecionado na comboBox
        public double ImpostoTotal { get; set; }
         
    
        public Produto(string nomeProduto, int qtd, Categoria categoria, double valorUn)
        {
            this.NomeProduto = nomeProduto;
            this.Quantidade = qtd;
            this.Valor = valorUn;
            this.CategoriaValor = categoria;
            CalculoImposto();

        }
        private void CalculoImposto() // 
        {
            switch (CategoriaValor)
            {

                case Categoria.ALIMENTOS:
                    ImpostoTotal = Quantidade * Valor * (5 / 100.0);
                    CategoriaProduto = "ALIMENTOS";
                    break;
                case Categoria.ELETRONICOS:
                    this.ImpostoTotal = this.Quantidade * this.Valor * (15 / 100.0);
                    CategoriaProduto = "ELETRONICOS";
                    break;
                case Categoria.VESTUARIO:
                    this.ImpostoTotal = this.Quantidade * this.Valor * (10 / 100.0);
                    CategoriaProduto = "VESTUARIO";
                    break;
            }
        }

    }
}
