using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.Classes
{
    class Matricula
    {
        public Matricula(string nome, string endereco, string numero, string bairro,
            string cep, string cidade, string telefone, string profissao, string estadoCivil,
            DateTime dataNascimento, string email, string emailCobranca, string cpf, string rg) 
        {
            NomeCompleto = nome.ToUpper();
            Endereco = endereco.ToUpper();
            Numero = numero;
            Bairro = bairro;
            Cep = cep.Replace(".", "").Replace(",", "").Replace("-", "");
            Cidade = cidade;
            Telefone = telefone;
            Profissao = profissao;
            EstadoCivil = estadoCivil;
            DataNascimento = dataNascimento;
            Email = email;
            EmailCobranca = emailCobranca;
            Cpf = cpf.Replace(".", "").Replace(",", "").Replace("-", "");
            Rg = rg.Replace(".", "").Replace(",", "").Replace("-", "");
        }

        public Matricula()
        {

        }

        public string NomeCompleto { set; get; }
        public string Endereco { set; get; }
        public string Numero { set; get; }
        public string Bairro { set; get; }
        public string Cep { set; get; }
        public string Cidade { set; get; }
        public string Telefone { set; get; }
        public string Profissao { set; get; }
        public string EstadoCivil { set; get; }
        public DateTime DataNascimento { set; get; }
        public string Email { set; get; }
        public string EmailCobranca { set; get; }
        public string Cpf{ set; get; }
        public string Rg { set; get; }
    }
}
