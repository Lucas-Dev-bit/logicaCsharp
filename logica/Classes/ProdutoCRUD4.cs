using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace logica.Classes
{
    public class ProdutoCRUD4
    {
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUn { get; set; }
        public string Cliente { get; set; }
        public TipoCliente ClienteIndex { get; set; }
        public decimal DescontoTotal { get; set; }
        public decimal ValorFinal { get; set; }

        public enum TipoCliente{
            PessoaFisica = 0,
            PessoaJuridica = 1,
            Funcionario = 2
        }

        public void CalculoDesconto()
        {
            decimal valor = Quantidade * PrecoUn;

            switch (ClienteIndex)
            {
                case TipoCliente.PessoaFisica:
                    DescontoTotal = valor * 0.05m;
                    Cliente = "PESSOA FISICA";
                    break;
                    
                case TipoCliente.PessoaJuridica:
                    DescontoTotal = valor * 0.10m;
                    Cliente = "PESSOA JURIDICA";
                    break;

                case TipoCliente.Funcionario:
                    DescontoTotal = valor * 0.20m;
                    Cliente = "FUNCIONARIO";
                    break;
            }
            ValorFinal = valor - DescontoTotal;
        }

        public ProdutoCRUD4(string nome, int qtd, decimal precoUn, TipoCliente clienteIndex)
        {
            this.NomeProduto = nome;
            this.Quantidade = qtd;
            this.PrecoUn = precoUn;
            this.ClienteIndex = clienteIndex;
            CalculoDesconto();
        }
        public ProdutoCRUD4() { }
    }
}
