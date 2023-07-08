using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Herancas
{
    public class Conta
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public decimal Saldo { get; set; }
        public DateTime DataAbertura { get; set; }

        public void Depositar(decimal valor)
        {
            Saldo += valor; 
        }

        public virtual string ObterExtrato()
        {
            var extrato = $"Nome: {Cliente}\nSaldo: {Saldo}";

            return extrato;
        }

        public virtual decimal CalcularSaldoTotal()
        {
            return Saldo * 1.05m;
        }
    }
}
