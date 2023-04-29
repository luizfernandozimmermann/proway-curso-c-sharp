using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.LacoRepeticao
{
    internal class LacoRepeticaoFor
    {
        public void Executar()
        {
            ExemploRelogio();
        }

        /// <summary>
        /// 
        /// </summary>
        private void Exemplo01 ()
        {
            for (int indice = 0; indice < 5; indice++)
            {
                Console.WriteLine("Oie");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void Exemplo02()
        {
            for (int indice = 10; indice > 0; indice--)
            {
                Console.WriteLine(indice);
            }
            DateTime dataHoraAtual = DateTime.Now;
            int ano = dataHoraAtual.Year + 1;
            Console.WriteLine($"Feliz ano novo {ano}!!!");
        }

        private void Exemplo03()
        { 
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Digite o nome do aluno: ");
                string nome = Console.ReadLine();

                Console.Write("Digite a nota 1: ");
                double nota1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a nota 2: ");
                double nota2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a nota 3: ");
                double nota3 = Convert.ToDouble(Console.ReadLine());

                double media = (nota1 + nota2 + nota3) / 3;
                Console.WriteLine($"Média do aluno {nome}: {media}");
            }
        }

        private void ExemploRelogio()
        {
            for (int hora = 0; hora < 24; hora++)
            {
                for (int minuto = 0; minuto < 60; minuto++)
                {
                    for (int segundo = 0; segundo < 60; segundo++)
                    {
                        Console.WriteLine($"{hora}:{minuto}:{segundo}");
                    }
                }
            }
        }
    }
}
