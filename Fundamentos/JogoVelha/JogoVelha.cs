using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.JogoVelha
{
    internal class JogoVelha
    {
        public void Executar()
        {
            bool continuarJogo = true;
            string[] lista1 = new string[3] { " ", " ", " " };
            string[] lista2 = new string[3] { " ", " ", " " };
            string[] lista3 = new string[3] { " ", " ", " " };

            string[][] tabelaJogo = new string[][] { lista1, lista2, lista3 };
            while (continuarJogo)
            {
                apresentarTabelaJogo(tabelaJogo, true);

                Console.Write("Escolha uma posição da tabela: ");

                string resposta = Console.ReadLine().Trim();
                int posicaoResposta = 0;
                int.TryParse(resposta, out posicaoResposta);
                while (posicaoResposta > 9 || posicaoResposta < 0)
                {
                    Console.Write("Digite uma posição válida: ");
                    resposta = Console.ReadLine().Trim();
                }
                tabelaJogo[(posicaoResposta - 1) / 3][(posicaoResposta - 1) % 3] = "X";

                apresentarTabelaJogo(tabelaJogo);
            }
        }

        private bool checarFim(string[][] tabelaJogo)
        {
            // horizontal
            foreach (string[] linha in tabelaJogo)
            {
                int itensIguaisHorizontal = 0;
                string itemAnteriorHorizontal = "X";
                foreach (string item in linha)
                {
                    if (item == itemAnteriorHorizontal)
                    {
                        itensIguaisHorizontal++;
                    }
                    else if (itensIguaisHorizontal == 1)
                    {
                        break;
                    }
                    else
                    {
                        itemAnteriorHorizontal = item;
                    }
                }
                if (itensIguaisHorizontal == 3)
                {
                    return true;
                }
            }

            // vertical
            int indexItem = 0;
            int[] itensIguaisVertical = { 0, 0, 0 };
            string[] itensAnterioresVertical = { "X", "X", "X"};
            foreach (string[] linha in tabelaJogo)
            {
                indexItem = 0;
                foreach (string item in linha)
                {
                    if (itensAnterioresVertical[indexItem] == item)
                    {
                        itensIguaisVertical[indexItem]++;
                    }
                    else
                    {
                        itensAnterioresVertical[indexItem] = item;
                    }
                    indexItem++;
                }
            }
            foreach (int quantidadeIguais in itensIguaisVertical)
            {
                if (quantidadeIguais == 3)
                {
                    return true;
                }
            }

            // diagonal
            if (tabelaJogo[0][0] == tabelaJogo[1][1] && tabelaJogo[1][1] == tabelaJogo[2][2] && tabelaJogo[1][1] != " ")
            {
                return true;
            }
            if (tabelaJogo[0][2] == tabelaJogo[1][1] && tabelaJogo[1][1] == tabelaJogo[2][0] && tabelaJogo[1][1] != " ")
            {
                return true;
            }

            return false;
        }

        private void apresentarTabelaJogo(string[][] tabelaJogo, bool numeracao=false)
        {
            if (numeracao)
            {
                Console.WriteLine("1 | 2 | 3");
                Console.WriteLine("----------");
                Console.WriteLine("4 | 5 | 6");
                Console.WriteLine("----------");
                Console.WriteLine("7 | 8 | 9");
            }
            else
            {
                foreach (string[] linha in tabelaJogo)
                {
                    foreach (string item in linha)
                    {
                        Console.Write(item + " |");
                    }
                    Console.WriteLine();
                    Console.WriteLine("---------");
                }
            }
        }
    }
}
