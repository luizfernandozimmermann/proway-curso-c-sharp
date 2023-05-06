using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OrientacaoObjetos
{
    internal class ListaColaboradoresIterativa
    {
        public void CalcularFolhasPagamento()
        {
            FolhaPagamento folhaPagamento = new FolhaPagamento();
            Console.Write("Nome: ");
            folhaPagamento.NomeColaborador = Console.ReadLine().Trim();

            Console.Write("Quantidade horas: ");
            folhaPagamento.QuantidadeHoras = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor hora: ");
            folhaPagamento.ValorHora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($@"Folha pagamento {folhaPagamento.NomeColaborador}
Salário bruto: {folhaPagamento.CalcularSalarioBruto()}
Valor hora: {folhaPagamento.ValorHora}");
        }
    }
}
