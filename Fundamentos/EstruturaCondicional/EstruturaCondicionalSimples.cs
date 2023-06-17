using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstruturaCondicional
{
    internal class EstruturaCondicionalSimples : Executor
    {
        public override void Executar()
        {
            int idade = 10;
            if (idade < 18)
            {
                Console.WriteLine("Menor de idade");
            }
            else
            {
                Console.WriteLine("Maior de idade");
            }

            // python
            //if idade < 18:
            //    print("Menor de idade")
            //else:
            //    print("Maior de idade");
            // Java
            //if(idade < 18) {
            //    System.out.println("Menor de idade");
            //} else {            //    System.out.println("Maior de idade");
            //}


            Console.Write("Informe a quanitdade de anos que trabalha na empresa: ");
            int quantidadeAnos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o salário");
            double salario = Convert.ToDouble(Console.ReadLine());
            // até 5 anos 3% de aumento
            // até 10 anos 8% de aumento
            // acima 10 anos 20% de aumento

            double aumento = 0;
            if (quantidadeAnos <= 5)
            {
                aumento = salario * 0.03; // 3% de aumento
            }
            else if (quantidadeAnos <= 10)
            {
                aumento = salario * 0.08; // 8% de aumento
            }
            else
            {
                aumento = salario * 0.20; // 20% de aumento
            }
            double salarioNovo = salario + aumento;
            Console.WriteLine("Novo salário: " + salarioNovo);

        }
    }
}
