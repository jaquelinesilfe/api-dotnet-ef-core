using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev_Week.src.Models
{
    public class Contract
    {
        public Contract()
        {
            this.DataCriacao = DateTime.Now;
            this.TokenId = "00000000";
            this.Valor = 0;
            this.Pago = false;
        }

        public Contract (string TokenId, double Valor) {
            this.DataCriacao = DateTime.Now;
            this.TokenId = TokenId;
            this.Valor = Valor;
            this.Pago = false;
        }

        public int Id { get; set; }

        public DateTime DataCriacao { get; set; }
        public string TokenId { get; set; }
        public double Valor { get; set; }

        public bool Pago { get; set; } 

        public int PessoaId { get; set; }
    }
}