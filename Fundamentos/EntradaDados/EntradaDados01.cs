using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EntradaDados
{
    internal class EntradaDados01 : Executor
    {
        public override void Executar()
        {

            // debug depurar (linha por linha)
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            string idadeTexto = Console.ReadLine();
            int idade = Convert.ToInt32(idadeTexto);

            Console.Write("Digite o salário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            int anoNascimento = 2023 - idade;
            Console.WriteLine("Ano de nascimento: " + anoNascimento);

            // Ctrl + K + C (comment)
            // Ctrl + K + U (uncomment)
            // Solicitar nome, peso, altura
            // Apresentar o nome e o IMC 
            // Fórmula do imc é peso / altura²

            // Solicitar nota1, nota2, nota3, nota4
            // Calcular e apresentar média das notas


            // Solicitar a quantidade total de ingressos e a quantidade vendida
            // Apresentar o percentual vendido

            // Solicitar a quantidade de arquivos processados e o percentual processados
            // Apresentar a quantidade total de arquivos

            // Solicitar o valor da fatura de net, oi, vivo, luz, água, condominio
            // Solicitar o valor de seguro da casa, seguro do apartamento
            // Apresentar o valor totol gasto em telefonia
            // Apresentar o valor total gasto em seguros
            // Apresentar o valor total das contas

            // https://bit.ly/3Gt9KxW
        }
    }
}
