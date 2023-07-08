using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OrientacaoObjetos
{
    internal class ListaColaboradoresIterativa : Executor
    {
        public override void Executar()
        {
            FolhaPagamento folhaPagamento = new FolhaPagamento();
            Console.Write("Nome: ");
            folhaPagamento.NomeColaborador = Console.ReadLine().Trim();
            Console.Write("Quantidade de horas: ");
            folhaPagamento.QuantidadeHoras = Convert.ToInt32(Console.ReadLine());
            Console.Write("Valor hora: ");
            folhaPagamento.ValorHora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($@"Folha de pagamento {folhaPagamento.NomeColaborador}
Salário Bruto: {folhaPagamento.CalcularSalarioBruto()}
INSS: {folhaPagamento.CalcularInss()}");
        }
    }
}
