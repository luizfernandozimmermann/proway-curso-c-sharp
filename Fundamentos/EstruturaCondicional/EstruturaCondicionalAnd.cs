using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstruturaCondicional
{
    internal class EstruturaCondicionalAnd : Executor
    {
        public override void Executar()
        {
            //double imc = peso / altura * altura;
            double peso = 128.00; double altura = 1.70;
            double imc = peso / Math.Pow(altura, 2); string textoImc = "";
            // Tabela verdade E
            // V e V => V
            // V e F => F
            // F e V => F
            // F e F => F
            if (imc < 18.5)
            {
                textoImc = "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc < 25.00 && imc != 20)
            {
                textoImc = "Peso ideal";
            }
            else if (imc >= 25.00 && imc < 30)
            {
                textoImc = "Levemente acima do peso";
            }
            else if (imc >= 30 && imc < 35)
            {
                textoImc = "Obesidade I";
            }
            else if (imc >= 35 && imc <= 40)
            {
                textoImc = "Obesidade II";
            }
            else
            {
                textoImc = "Obesidade III";
            }
            Console.WriteLine("IMC: " + textoImc);
        }
    }
}
