using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.ExemploVetor
{
    internal class ExemploVetor
    {
        public void Executar()
        {
            Exercicio();
        }

        private void Exemplo01() 
        {
            string[] nomes = new string[3];
            double[] precosUnitarios = new double[3];
            int[] quantidades = new int[3];
            double[] totalProdutos = new double[3];

            // Input
            Console.Write("Produto: ");
            nomes[0] = Console.ReadLine().Trim();
            Console.Write("Preço unitário: ");
            precosUnitarios[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantidade: ");
            quantidades[0] = Convert.ToInt32(Console.ReadLine());

            // Processamento
            totalProdutos[0] = precosUnitarios[0] * quantidades[0];
            // Output
            Console.WriteLine("Preço do produto 3: " + totalProdutos[0]);

            // Input
            Console.Write("Produto: ");
            nomes[1] = Console.ReadLine().Trim();
            Console.Write("Preço unitário: ");
            precosUnitarios[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantidade: ");
            quantidades[1] = Convert.ToInt32(Console.ReadLine());

            // Processamento
            totalProdutos[1] = precosUnitarios[1] * quantidades[1];
            // Output
            Console.WriteLine("Preço do produto 3: " + totalProdutos[1]);

            // Input
            Console.Write("Produto: ");
            nomes[2] = Console.ReadLine().Trim();
            Console.Write("Preço unitário: ");
            precosUnitarios[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantidade: ");
            quantidades[2] = Convert.ToInt32(Console.ReadLine());

            // Processamento
            totalProdutos[2] = precosUnitarios[2] * quantidades[2];
            // Output
            Console.WriteLine("Preço do produto 3: " + totalProdutos[2]);
        }

        private void Exercicio()
        {
            string[] nomes = new string[3];
            double[] altura = new double[3];
            double[] peso = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine().Trim();
                Console.Write("Altura em cm: ");
                altura[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Peso em kg: ");
                peso[i] = Convert.ToInt32(Console.ReadLine());

                double imc = peso[i] / (altura[i] * altura[i] / 10000);
                Console.WriteLine($"A pessoa {nomes[i]} possui {imc} de imc");
            }
        }
    }
}
