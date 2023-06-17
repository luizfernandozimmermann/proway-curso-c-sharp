namespace Fundamentos.Herancas
{
    internal class ContaCorrente : Conta
    {
        public decimal SaldoChequeEspecial { get; set; }

        public override string ObterExtrato()
        {
            var extrato = $"{base.ObterExtrato()}\nSaldo cheque especial: {SaldoChequeEspecial}";
            
            return extrato;
        }

        public override decimal CalcularSaldoTotal()
        {
            return Saldo + SaldoChequeEspecial;
        }
    }
}