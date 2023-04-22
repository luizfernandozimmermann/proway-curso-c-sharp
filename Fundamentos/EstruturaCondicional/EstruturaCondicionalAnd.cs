using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstruturaCondicional
{
    internal class EstruturaCondicionalAnd
    {
        public void Executar()
        {
            double peso = 80;
            double altura = 1.76;
            double imc = peso / Math.Pow(altura, 2);
            bool a = true || false;
            string textoIMC = "";
            if (imc < 18.5)
            {
                textoIMC = "Abaixo do peso";
            }
            else if (imc < 25)
            {
                textoIMC = "Peso ideal";
            }
            else if (imc < 30)
            {
                textoIMC = "Levemente acima do peso";
            }
            else if (imc < 35)
            {
                textoIMC = "Obesidade I";
            }
            else if (imc <= 40)
            {
                textoIMC = "Obesidade II";
            }
            else
            {
                textoIMC = "Obesidade III";
            }
            Console.WriteLine(textoIMC);
        }
    }
}
