using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OrientacaoObjetos
{
    internal class ListaColaboradores
    {
        public void CalcularFolhasPagamentos()
        {
            FolhaPagamento matheusComTh = new FolhaPagamento();
            matheusComTh.QuantidadeHoras = 220;
            matheusComTh.ValorHora = 50;
            matheusComTh.NomeColaborador = "Matheus";
            double salarioMatheus = matheusComTh.CalcularSalarioBruto();

            FolhaPagamento francisco = new FolhaPagamento();
            francisco.QuantidadeHoras = 220;
            francisco.ValorHora = 15;
            francisco.NomeColaborador = "Francisco";
            double salarioFrancisco = francisco.CalcularSalarioBruto();

            Console.WriteLine($@"");
        }
    }
}
