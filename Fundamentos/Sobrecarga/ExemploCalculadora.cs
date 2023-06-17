using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fundamentos.Sobrecarga
{
    internal class ExemploCalculadora : Executor
    {
        public override void Executar()
        {
            var hp = new Calculadora();

            Console.WriteLine("Soma: " + hp.Somar(30, 10));
            Console.WriteLine("Soma: " + hp.Somar(30, 10, 20));
            Console.WriteLine("Soma: " + hp.Somar(30, 10, 20, 15));
        }
    }
}
