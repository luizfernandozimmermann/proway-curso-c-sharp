using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.LacoRepeticao
{
    internal class LacoRepeticaoWhile : Executor
    {
        // Método sem retorno, dica void
        // Método sem parâmetros, dica n tem variável dentro dos ()
        public override void Executar()
        {
            int opcaoDesejada = 0;
            while(opcaoDesejada != 8001)
            {
                Console.WriteLine("\n1 - Exemplo 01" +
                    "\n2 - Exemplo 02" +
                    "\n3 - Exemplo 03" +
                    "\n8001 - Sair");
                opcaoDesejada = Convert.ToInt32(Console.ReadLine());
                if (opcaoDesejada == 1)
                    Exemplo01();
                else if (opcaoDesejada == 2)
                    Exemplo02();
                else if(opcaoDesejada == 3)
                    Exemplo03();
                else if(opcaoDesejada != 8001)
                    Console.WriteLine("Opção inválida");

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                // Link do Miro com os exemplos do prof Francisco https://bit.ly/3nRV19f
            }
        }

        public void Exemplo01()
        {
            int indice = 0;
            while(indice < 10)
            {
                Console.WriteLine("Oie");
                indice = indice + 1;
            }

            Console.WriteLine("Terminou o exemplo de while");
        }

        /// <summary>
        /// Solicitar nome e sobrenome para 3 usuários
        /// </summary>
        public void Exemplo02()
        {
            int indice = 0;
            while (indice < 3)
            {
                // Inputs - entradas
                Console.Write("Nome: ");
                string nome = Console.ReadLine().Trim();
                Console.Write("Sobrenome: ");
                string sobrenome = Console.ReadLine().Trim();
                
                // Processamento
                string nomeCompleto = nome + " " + sobrenome;
                
                // Output
                Console.WriteLine("Nome completo: " + nomeCompleto);

                indice = indice + 1;
            }
        }


        /// <summary>
        /// Exemplo pedir para o usuário a quantidade de notas 
        /// que deseja cadastrar, solicitando-as.
        /// </summary>
        public void Exemplo03()
        {
            Console.Write("Digite a quantidade de notas que deseja registrar: ");
            int quantidadeDesejada = Convert.ToInt32(Console.ReadLine());
            int indice = 0;
            double somaNotas = 0, maiorNota = 0, menorNota = 8001.00;
            //while(indice <= quantidadeDesejada - 1)
            while(indice < quantidadeDesejada)
            {
                Console.Write("Nota: ");
                double nota = Convert.ToDouble(Console.ReadLine());

                somaNotas = somaNotas + nota;

                if(nota > maiorNota)
                {
                    maiorNota = nota;
                }

                if(nota < menorNota)
                {
                    menorNota = nota;
                }

                // Incrementar em 1
                indice = indice + 1;
            }

            double media = somaNotas / quantidadeDesejada;
            // \n é utilizado para quebrar a linha
            Console.WriteLine(
                "Média: " + media + 
                "\nMaior nota: " + maiorNota + 
                "\nMenor nota: " + menorNota);
        }
    }
}