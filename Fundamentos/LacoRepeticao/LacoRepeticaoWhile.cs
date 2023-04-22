using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.LacoRepeticao
{
    internal class LacoRepeticaoWhile
    {
        public void Executar()
        {
            string opcaoDesejada = "0";

            while (opcaoDesejada != "8001")
            {
                Console.WriteLine("1 - Exemplo01\n2 - Exemplo02\n3 - Exemplo03\n8001 - Sair");

                Console.Write("Opção: ");

                opcaoDesejada = Console.ReadLine();
                if (opcaoDesejada == "1")
                    Exemplo01();
                else if (opcaoDesejada == "2")
                    Exemplo02();
                else if (opcaoDesejada == "3")
                    Exemplo03();
                else if (opcaoDesejada != "8001")
                    Console.WriteLine("Opção inválida");
                
                Console.WriteLine("Aperte qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void Exemplo01()
        {
            int indice = 0;
            while (indice < 10)
            {
                indice++;
                Console.WriteLine("Oie");
            }
            Console.WriteLine("Poggers..");
        }

        /// <summary>
        /// Solicitar nome e sobrenome para 3 usuários
        /// </summary>
        public void Exemplo02()
        {
            int indice = 0;
            while (indice < 3)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine().Trim();
                Console.Write("Sobrenome: ");
                string sobrenome = Console.ReadLine().Trim();

                string nomeCompleto = nome + " " + sobrenome;

                Console.WriteLine("Nome completo: " + nomeCompleto);

                indice++;
            }
        }

        /// <summary>
        /// Exemplo pedir para o usuário a quantidade de notas que
        /// que deseja cadastrar, solicitando-as.
        /// </summary>
        public void Exemplo03()
        {
            Console.Write("Quantidade de notas a registrar: ");
            int quantidadeDesejada = Convert.ToInt32(Console.ReadLine());

            int indice = 0;
            double somaNotas = 0, maiorNota = 0, menorNota = 8001;
            while (indice < quantidadeDesejada)
            {
                Console.Write("Nota: ");
                double nota = Convert.ToDouble(Console.ReadLine());

                somaNotas += nota;

                if (nota > maiorNota)
                {
                    maiorNota = nota;
                }
                if (nota < menorNota)
                {
                    menorNota = nota;
                }

                indice++;
            }
            double mediaNotas = somaNotas / quantidadeDesejada;
            Console.WriteLine("Média: " + mediaNotas
                            + "\nMaior nota: " + maiorNota
                            + "\nMenor nota: " + menorNota);
        }
    }
}
