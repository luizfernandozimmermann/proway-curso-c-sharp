using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.VetorComFor
{
    internal class ExemploVetorComFor : Executor
    {
        public override void Executar()
        {
            ExemploProdutos();
        }

        private void ExemploNomes()
        {
            // nomes.Length é o tamanho do vetor
            string[] nomes = new string[5];

            // Inputs (solicitar o nome dos alunos)
            // for 0..quantidade de nomes - 1
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
            }

            // Output
            Console.Clear();
            for (int i = 0; i < nomes.Length; i += 1)
            {
                Console.WriteLine(nomes[i]);
            }
        }

        private void ExemplosNumeros()
        {
            int[] numeros = new int[6];

            // for(declaracao; condicao; incremento){
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Processamento
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma = soma + numeros[i];
            }

            int maiorNumero = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                int numero = numeros[i];
                if (numero > maiorNumero)
                {
                    maiorNumero = numero;
                }
            }

            // Maior valor de um int
            int menorNumero = int.MaxValue;
            for (int i = 0; i < numeros.Length; i++)
            {
                int numero = numeros[i];
                if (numero < menorNumero)
                {
                    menorNumero = numero;
                }
            }
            double media = soma / Convert.ToDouble(numeros.Length);

            // Output 
            // Interpolação de string
            Console.WriteLine(
            $"Soma: {soma} \nMédia: {media}\nMaior número: {maiorNumero}\nMenor número: {menorNumero}");

            // int soma = 0;
            // 0 + 3
            // soma = soma + 3;
            // 3 + 6
            // soma = soma + 6; => 9
            // 9 + 1
            // soma = soma + 1; => 10
        }

        private void ExemploProdutos()
        {
            Console.Write("Digite a quantidade de produtos desejada: ");
            int quantidadeProdutosDesejada = Convert.ToInt32(Console.ReadLine());

            string[] nomes = new string[quantidadeProdutosDesejada];
            int[] quantidades = new int[quantidadeProdutosDesejada];
            double[] precosUnitarios = new double[quantidadeProdutosDesejada];
            double[] totalProdutos = new double[quantidadeProdutosDesejada];

            SolicitarDadosProdutos(nomes, precosUnitarios, quantidades);
            CalcularTotalProdutos(precosUnitarios, totalProdutos, quantidades);
            ApresentarCupomFiscal(nomes, quantidades, precosUnitarios, totalProdutos);
        }

        // Encapsulamento: private, public
        // Tipo de retorno: void(sem retorno) string, int, ....(com retorno)
        // NomeMetodo
        // parametros: Tipo de parametro + nomeParametro
        // encapsulamento + tipoDeRetorno + NomeMetodo(parametros) {
        private void SolicitarDadosProdutos(string[] nomes, double[] precosUnitarios, int[] quantidades)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = SolicitarNomeProduto();
                precosUnitarios[i] = SolicitarPrecoUnitario();
                quantidades[i] = SolicitarQuantidadeProduto();
            }
        }

        private string SolicitarNomeProduto()
        {
            Console.Write("Produto: ");
            string nome = Console.ReadLine().Trim();

            while (nome.Length < 3 || nome.Length > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nome deve conter no mínimo 3 caracteres e no máximo 100");
                Console.ResetColor();

                Console.Write("Produto: ");
                nome = Console.ReadLine().Trim();
            }

            return nome;
        }

        private double SolicitarPrecoUnitario()
        {
            double preco = 0;
            bool valorValido = false;
            while (valorValido == false)
            {
                try
                {
                    Console.Write("Preço Unitário: ");
                    preco = Convert.ToDouble(Console.ReadLine());
                    valorValido = true;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor informado não é um valor válido");
                    Console.ResetColor();
                }
            }
            return preco;
        }

        private int SolicitarQuantidadeProduto()
        {
            int quantidade = 0;
            bool quantidadeValida = false;
            while (quantidadeValida != true)
            {
                try
                {
                    Console.Write("Quantidade: ");
                    quantidade = Convert.ToInt32(Console.ReadLine());
                    if(quantidade <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Quantidade deve ser maior que 0");
                        Console.ResetColor();
                    }
                    else
                    {
                        quantidadeValida = true;
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Quantidade informada não é um número inteiro válido");
                    Console.ResetColor();
                }
            }
            return quantidade;
        }

        private void CalcularTotalProdutos(double[] precosUnitarios, double[] totalProdutos, int[] quantidades)
        {
            for (int i = 0; i < precosUnitarios.Length; i++)
            {
                totalProdutos[i] = precosUnitarios[i] * quantidades[i];
            }
        }

        private void ApresentarCupomFiscal(
            string[] nomes, 
            int[] quantidades, 
            double[] precosUnitarios, 
            double[] totalProdutos)
        {
            var table = new ConsoleTable("Nome", "Quantidade", "Preço Unitário", "Total");
            for (int i = 0; i < nomes.Length; i++)
            {
                table.AddRow(nomes[i], quantidades[i], precosUnitarios[i], totalProdutos[i]);
            }

            Console.Clear();
            table.Write();
            Console.WriteLine();
        }
    }
}
