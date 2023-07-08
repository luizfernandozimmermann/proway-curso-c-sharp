using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.ExemploVetor
{
    internal class ExemploVetorComFor
    {
        public void Executar()
        {
            ExemploNumeros();
        }

        private void ExemploNomes()
        {
            string[] nomes = new string[5];

            for (int i = 0; i < nomes.Length; i++) 
            {
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
            }

            Console.Clear();
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }
        }

        private void ExemploNumeros()
        {
            int[] numeros = new int[6];
            
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int soma = 0;
            int menorNumero = numeros[0];
            int maiorNumero = numeros[0];
            foreach (int numero in numeros)
            {
                soma += numero;

                if (numero > maiorNumero)
                {
                    maiorNumero = numero;
                }
                if (numero < menorNumero)
                {
                    menorNumero = numero;
                }
            }

            double media = Convert.ToDouble(soma) / numeros.Length;

            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Média: " + media);
            Console.WriteLine("Maior número: " + maiorNumero);
            Console.WriteLine("Menor número: " + menorNumero);
        }

        private void ExemploProdutos()
        {
            Console.Write("Digite a quantidade de produtos desejada: ");
            int quantidadeProdutos = Convert.ToInt32(Console.ReadLine());

            string[] nomes = new string[quantidadeProdutos];
            int[] quantidades = new int[quantidadeProdutos];
            double[] precosUnitarios = new double[quantidadeProdutos];
            double[] totalProdutos = new double[quantidadeProdutos];

            SolicitarDadosProdutos(nomes, quantidades, precosUnitarios);
            CalcularTotalProdutos();
            ApresentarCupomFiscal();


        }

        private void SolicitarDadosProdutos(string[] nomes, int[] quantidades, double[] precosUnitarios)
        {

        }

        private void CalcularTotalProdutos()
        {

        }

        private void ApresentarCupomFiscal()
        {
            
        }
    }
}
