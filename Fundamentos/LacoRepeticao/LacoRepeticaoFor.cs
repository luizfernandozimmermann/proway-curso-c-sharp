using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.LacoRepeticao
{
    internal class LacoRepeticaoFor : Executor
    {
        // Método público sem retorno e sem parâmetros
        public override void Executar()
        {
            //Exemplo01();
            ExemploRelogio();
        }

        // Método privado sem retorno e sem parâmetros
        private void Exemplo01()
        {
            //int indice = 0;
            //while(indice < 5)
            //{
            //    Console.WriteLine("Oie");
            //    // Incrementando a variável indice
            //    indice = indice + 1;
            //}

            // for(declaração da variável; condição para execução do for; incremento)
            for (int indice = 0; indice < 5; indice = indice + 1)
            {
                Console.WriteLine("Oie");
            }
        }

        // Método privado sem retorno e sem parâmetros
        private void Exemplo02()
        {
            for (int indice = 10; indice > 0; indice = indice - 1)
            {
                Console.WriteLine(indice);
            }

            // DateTime é utilizado para trabalhar com data e hora
            // DateTime.Now pega a data e hora atual do Sistema Operacional
            // .AddYears(1) Adiciona um ano na data e hora
            DateTime dataHoraAtual = DateTime.Now.AddYears(1);

            int ano = dataHoraAtual.Year;
            Console.WriteLine("Feliz ano novo " + ano + "!!!!");
        }

        private void Exemplo03()
        {
            // Solicitar os dados para 4 alunos
            // Solicitar nota1, nota2, nota3
            // Calcular a média
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

                // Processamento
                double media = (nota1 + nota2 + nota3) / 3;

                // Output
                Console.WriteLine("Média: " + media);
            }
            // i = i + 1; Incrementar a variável i em 1
            // i += 1; Incrementar a variável i em 1, forma simplificada
            // i++; Incrementar a variável i em 1, forma simplificada
        }

        private void ExemploRelogio()
        {
            // 00:00:00
            // 00:00:01
            // 00:00:59
            // 00:01:00
            // 00:59:59
            // 01:00:00
            // 23:59:59
            // 00:00:00
            for (int hora = 0; hora < 24; hora += 1)
            {
                for (int minuto = 0; minuto <= 59; minuto = minuto + 1)
                {
                    for (int segundo = 0; segundo < 60; segundo++)
                    {
                        Console.Clear();
                        Console.WriteLine(hora + ":" + minuto + ":" + segundo);
                        // Delay de 1s
                        Thread.Sleep(1000);
                    }
                }
            }
        }
    }
}
