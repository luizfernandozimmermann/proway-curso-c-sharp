using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstruturaCondicional
{
    internal class EstruturaCondicionalOr
    {
        public void Executar()
        {
            Console.Write("Digite a quantidade de horas jogadas por dia: ");
            int quantidadeHoras = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tem LED no PC? ");
            string respostaLed = Console.ReadLine().ToUpper().Trim();
            bool setupGamer = false;

            if (respostaLed == "SIM" || respostaLed == "S")
            {
                setupGamer = true;
            }

            if (quantidadeHoras >= 9 || setupGamer)
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
