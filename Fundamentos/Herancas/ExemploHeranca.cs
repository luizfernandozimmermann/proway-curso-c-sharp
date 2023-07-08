using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Herancas
{
    internal class ExemploHeranca : Executor
    {
        public override void Executar()
        {
            var contaFrancisco = new ContaPoupanca();
            contaFrancisco.Cliente = "Francisco";
            contaFrancisco.Saldo = 1_000_000.00m;
            contaFrancisco.Codigo = 1;
            contaFrancisco.Depositar(10.00m);

            var contaMatheus = new ContaPoupanca();
            contaMatheus.Cliente = "Mathues";
            contaMatheus.Saldo = 25_569.71m;
            contaMatheus.Codigo = 2;
            contaMatheus.Depositar(500);
            contaMatheus.Depositar(250.00m);

            var contaPedro = new ContaCorrente();
            contaPedro.Cliente = "Pedro";
            contaPedro.Saldo = 43_210.30m;
            contaPedro.Codigo = 3;
            contaPedro.SaldoChequeEspecial = 1500.00m;
            contaPedro.Depositar(350.28m);

            Console.WriteLine(contaFrancisco.ObterExtrato());
            Console.WriteLine(contaMatheus.ObterExtrato());
            Console.WriteLine(contaPedro.ObterExtrato());

        }
    }
}
