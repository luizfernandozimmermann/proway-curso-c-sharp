using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Sobrecarga
{
    internal class Calculadora
    {
        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        public int Somar(int numero1, int numero2, int numero3)
        {
            return numero1 + numero2 + numero3;
        }
        public int Somar(int numero1, int numero2, int numero3, int numero4)
        {
            return numero1 + numero2 + numero3 + numero4;
        }
    }
}
