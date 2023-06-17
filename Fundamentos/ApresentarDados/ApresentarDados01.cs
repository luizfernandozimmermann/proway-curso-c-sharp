using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.ApresentarDados
{
    internal class ApresentarDados01 : Executor
    {
        public override void Executar()
        {
            //// Este é um comentário e será ignorado.
            //Console.Write("Oie"); // Apresentar uma mensagem
            //Console.WriteLine("Olá"); // Apresentar a mensagem e quebra a linha

            //Console.WriteLine("Dia de aula de C# :)");
            //// OieOlá
            //// Dia de aula de C# :)
            //Console.WriteLine("Soma: " + 2 + 2);
            //Console.WriteLine(2 + 2);


            // string + string => string(texto)
            // Concatenação: juntar dois textos

            Console.WriteLine("Francisco" + " " + "Lucas Sens");
            Console.WriteLine("Soma:" + 2);// string + int => string
            Console.WriteLine("Soma: " + 2 + 2);
            // "Soma: " + 2 => "Soma: 2"
            // string + int => string
            // "Soma: 2" + 2 => "Soma: 22"
            // string + int => string
            Console.WriteLine("Soma: " + (2 + 2));
            Console.WriteLine("Subtração: " + (2 - 2));
            Console.WriteLine("Multiplicação: " + 2 * 2);
            Console.WriteLine("Divisão: " + 2 / 2);
            Console.WriteLine("Resto da divisão: " + 2 % 2);

            // 2 / 2    5 / 2
            //-2 / 1   -4   2
            // 0        1

            // 4 / 2    7 / 2
            //-4  2    -6   3
            // 0        1


            // Variávies: local onde é possível armazenar info
            Console.Write("Aperte qualquer tecla para continuar:");
            Console.ReadKey(); // Ler o que o usuário apertou
            Console.Clear(); // Limpa tela
            string nomeAluna = "Julia";
            Console.WriteLine("Nome da aluna: " + nomeAluna);
            int idadeAluna = 15;
            Console.WriteLine("Idade da Julia: " + idadeAluna);
            double salarioAluna = 9000.90;
            Console.WriteLine("Salário da Julia: " + salarioAluna);
            // bool => boolean (true ou false) => (verdadeiro ou falso)
            bool matriculadaAluna = true;
            Console.WriteLine("Matriculada na turma de C#: " + matriculadaAluna);
            double valorHoraAluna = salarioAluna / 220;
            Console.WriteLine("Valor hora: " + valorHoraAluna);
            // char armazena no mínimo 1 e no máximo 1 caracter 
            char letraFavoritaAluna = 'J';
            Console.WriteLine("Letra favorita: " + letraFavoritaAluna);

            // Descobrir o percentual
            // 120 livros   100 %
            // 1            x
            // (1 * 100) / 120 => Percentual de livros lidos
            double jogou = 253;
            int venceu = 200;
            double percentualVitoria = (venceu * 100) / jogou;
            Console.WriteLine("Jogou: " + jogou + "   100%");
            Console.WriteLine("Venceu: " + venceu + "   " + percentualVitoria);

            //     int / double
            //  (venceu * 100) / jogou
            // int * int => int


            // Solicitar para o usuário seu nome
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            // Solicitar para o usuário seu sobrenome
            Console.Write("Digite o seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            // Padrão de nomenclatura de variávies
            // Correto: nome, sobrenome, nomeCompleto, nomeCompleto2
            // Errado: 2nome, $nome, nome_completo
            string nomeCompleto = nome + " " + sobrenome;
            Console.WriteLine("Nome completo: " + nomeCompleto);

            // Alt + Cima, Alt + Baixo Mover linha
            // Ctrl + R + R => Renomear
            // Windows + D => Desktop
            // Alt + Tab => Trocar janela do windows


            // Conversão de string para int => texto para inteiro
            int numeroExemploConversao = Convert.ToInt32("2");
            // Conversão de string para double => texto para real
            double salarioExemploConversao = Convert.ToDouble("10000.90");
            // Conversão de string para boolean => texto para lógico
            bool matriculadaExemploConversao = Convert.ToBoolean("true");
            // Conversão de string para char
            char letra = Convert.ToChar("A");
            Console.WriteLine(
                "Dados convertidos de string para o seu devido tipo"
            );
            Console.WriteLine("Número: " + numeroExemploConversao);
            Console.WriteLine("Salário: " + salarioExemploConversao);
            Console.WriteLine("Matricula: " + matriculadaExemploConversao);
            Console.WriteLine("Letra: " + letra);

            // Link do Miro com os exemplos do prof Francisco https://bit.ly/3nRV19f
        }
    }
}
