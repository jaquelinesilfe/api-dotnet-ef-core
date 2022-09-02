using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev_Week.src.Models
{
    public class Person
    {
        public Person()
        {
            this.Nome = "template";
            this.Idade = 0;
            this.Cpf = "0000000";
            this.Ativado = true;
            this.contracts = new List<Contract>();
        }
        public Person(string Nome, int Idade, string Cpf)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Cpf = Cpf;
            this.Ativado = true;
            this.contracts = new List<Contract>();

        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public bool Ativado { get; set; }
        public List<Contract> contracts { get; set; }

    }


}