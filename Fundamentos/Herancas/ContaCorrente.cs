namespace Fundamentos.Herancas
{
    // ContaCorrente herda as propriedades/métodos da classe Conta
    public class ContaCorrente : Conta
    {
        public decimal SaldoChequeEspecial { get; set; }

        // Override: uma sobreescrita do método ObterExtrato, ou seja, mudamos o comportamento
        // do método da classe Pai
        public override string ObterExtrato()
        {
            // Obtém o extrato da classe pai Conta
            // base é utilizado para chamar métodos da classe pai, avô
            var extratoPai = base.ObterExtrato();
            var extratoFilho = $"Saldo cheque especial: {SaldoChequeEspecial}";

            // Retorna o extrato da classe pai Conta + extrato da ContaCorrente
            return $"{extratoPai}\n{extratoFilho}";
        }
    }
}