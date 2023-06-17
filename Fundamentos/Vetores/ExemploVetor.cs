using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Vetores
{
    internal class ExemploVetor : Executor
    {
        public override void Executar()
        {
            ExemploProdutos();
        }

        private void ExemplosNomes()
        {
            string[] nomes = new string[3];
            nomes[0] = "Lucas";
            nomes[1] = "Ana";
            nomes[2] = "Fabrííiicío";

            // Trocando o valor contido na primeira posição do vetor de nomes
            // Concatenando o sobrenome da Silva na primeira posição
            nomes[0] = nomes[0] + " da Silva";


            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);
        }

        private void ExemploNumeros()
        {
            int[] numeros = new int[6];
            numeros[0] = 30;
            numeros[1] = 21;
            numeros[2] = 29;
            numeros[3] = 27;
            numeros[4] = 52;
            numeros[5] = 10;

            // numeros.Length : é o tamanho do vetor
            
            int soma = numeros[0] + numeros[1] + numeros[2] + numeros[3] + 
                numeros[4] + numeros[5];
            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Média: " + soma / numeros.Length);
        }

        private void ExemploProdutos()
        {
            // nome, preço unitário e quantidade, calcular e apresentar
            // solicitar estes dados para 3 produtos
            string[] nomes = new string[3];
            double[] precosUnitarios = new double[3];
            int[] quantidades = new int[3];
            double[] totalProdutos = new double[3];

            // Input
            Console.Write("Produto: ");
            nomes[0] = Console.ReadLine().Trim();
            Console.Write("Preço Unitário: ");
            precosUnitarios[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantidade: ");
            quantidades[0] = Convert.ToInt32(Console.ReadLine());

            // Processamento
            totalProdutos[0] = precosUnitarios[0] * quantidades[0];
            
            // Output
            Console.WriteLine("Preço do produto 1: " + totalProdutos[0]);

            // Input
            Console.Write("Produto: ");
            nomes[1] = Console.ReadLine().Trim();
            Console.Write("Preço Unitário: ");
            precosUnitarios[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantidade: ");
            quantidades[1] = Convert.ToInt32(Console.ReadLine());

            // Processamento
            totalProdutos[1] = precosUnitarios[1] * quantidades[1];
            
            // Output
            Console.WriteLine("Preço do produto 2: " + totalProdutos[1]);

            // Input
            Console.Write("Produto: ");
            nomes[2] = Console.ReadLine().Trim();
            Console.Write("Preço Unitário: ");
            precosUnitarios[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantidade: ");
            quantidades[2] = Convert.ToInt32(Console.ReadLine());

            // Processamento
            totalProdutos[2] = precosUnitarios[2] * quantidades[2];
            // Output
            Console.WriteLine("Preço do produto 3: " + totalProdutos[2]);

            // Processamento
            double total = totalProdutos[0] + totalProdutos[1] + totalProdutos[2];
            
            // Output
            Console.WriteLine("Total: " + total);
        }

        // Exercício
        // Solicitar nome, altura e peso de 3 pessoas
        // Calcular o imc de cada pessoa e apresentar
    }
}
