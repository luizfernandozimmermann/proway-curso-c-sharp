using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OrientacaoObjetos
{
    internal class ListaColaboradores : Executor
    {
        public override void Executar()
        {
            // Objeto jose intancia da classe FolhaPagamento
            FolhaPagamento jose = new FolhaPagamento();
            jose.NomeColaborador = "José";
            jose.QuantidadeHoras = 160;
            jose.ValorHora = 60.00;
            double salarioJose = jose.CalcularSalarioBruto();
            double inssJose = jose.CalcularInss();

            FolhaPagamento matheusComTh = new FolhaPagamento();
            matheusComTh.QuantidadeHoras = 220;
            matheusComTh.ValorHora = 50;
            matheusComTh.NomeColaborador = "Matheus";
            double salarioMatheus = matheusComTh.CalcularSalarioBruto();
            double inssMatheus = matheusComTh.CalcularInss();

            FolhaPagamento francisco = new FolhaPagamento();
            francisco.QuantidadeHoras = 220;
            francisco.ValorHora = 15.00;
            francisco.NomeColaborador = "Francisco";
            double salarioFrancisco = francisco.CalcularSalarioBruto();
            double inssFrancisco = francisco.CalcularInss();

            Console.WriteLine($@"Folha Pagamento {francisco.NomeColaborador}
Salário Líquido: {salarioFrancisco}
ISSN: {inssFrancisco}

Folha Pagamento {matheusComTh.NomeColaborador}
Salário Líquido: {salarioMatheus}
ISSN: {inssMatheus}

Folha Pagamento {jose.NomeColaborador}
Salário Líquido: {salarioJose}
ISSN: {inssJose}");
        }
    }
}
