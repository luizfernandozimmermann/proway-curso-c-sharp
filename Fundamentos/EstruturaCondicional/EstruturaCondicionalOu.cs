using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstruturaCondicional
{
    internal class EstruturaCondicionalOu : Executor
    {
        public override void Executar()
        {
            // | pipeline
            // || ou 
            // Tabela verdade
            // V ou V => V
            // V ou F => V
            // F ou V => V
            // F ou F => F
            Console.Write("Digite a quantidade de horas de jogatina por dia: ");
            int quantidadeHorasJoga = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tem LED? (S -> Sim ou N -> Não)");
            // .ToUpper() transformar o texto em CAIXA ALTA
            // .TrimStart() remove espaços do começo da string
            // .TrimEnd() remove espaços do fim da string
            // .Trim() remove espaços do começo e do fim da string
            string setupGamerTextoEntrada = Console.ReadLine().ToUpper().Trim();
            bool setupGamer = false;
            if (setupGamerTextoEntrada == "SIM" || setupGamerTextoEntrada == "S")
            {
                setupGamer = true;
            }

            if (quantidadeHorasJoga >= 9 || setupGamer == true)
            {
                Console.WriteLine("Gamer profissional");
            }
            else
            {
                Console.WriteLine("Não é gamer profissional");
            }
        }
    }
}
