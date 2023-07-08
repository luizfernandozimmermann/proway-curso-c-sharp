using System.Collections.Generic;

namespace Fundamentos.EstruturaCondicional
{
    internal class EstruturaCondicionalAvancada : Executor
    {
        public override void Executar()
        {
            // INPUTS
            // byte 0..255, short -32768..32767, int -2bi..2bi e long
            // byte Convert.ToByte
            // short Convert.ToInt16
            // int Convert.ToInt32
            // long Convert.ToInt64
            // ToUpper() CALXA ALTA
            // ToLower() caixa baixa
            Console.Write("Quantidade de horas trabalhadas: ");
            byte quantidadeHorasTrabalhadas = Convert.ToByte(Console.ReadLine());
            Console.Write("Valor hora: ");
            double valorHora = Convert.ToDouble(Console.ReadLine()); // 235.94
            Console.Write("Recebe vale educação? [S/N]: ");
            string recebeAuxilioEducacaoTexto = Console.ReadLine().Trim().ToLower();
            bool recebeAuxilioEducacao = false;
            if (recebeAuxilioEducacaoTexto == "s")
            {
                recebeAuxilioEducacao = true;
            }
            Console.Write("Recebe auxilio passe? [S/N]: ");
            string recebeAuxilioPasseTexto = Console.ReadLine().ToUpper().Trim();
            bool recebeValeTransporte = false;
            if (recebeAuxilioPasseTexto == "S")
                recebeValeTransporte = true;
            Console.Write("Filhos menores de 5 anos? [S/N]: ");
            // Operador ternário é um IF com retorno de valor
            // Ex.: string classificacao = idade < 8 ? "Menor" : "Maior";
            bool recebeAuxilioCreche =
                Console.ReadLine().ToUpper().Trim() == "S" ? true : false;

            // Processamento
            double salarioBruto = quantidadeHorasTrabalhadas * valorHora;

            double descontoInss = CalcularInss(salarioBruto);
            double descontoImpostoRenda = CalcularImpostoRenda(salarioBruto);
            double acrescimoAuxilioCreche = CalcularAuxilioCreche(recebeAuxilioCreche);
            double acrescimoAuxilioEducacao = CalcularAuxilioEducacao(recebeAuxilioEducacao);
            double descontoValeTransporte = CalcularValeTransporte(recebeValeTransporte, salarioBruto);

            double descontos = descontoValeTransporte + descontoInss + descontoImpostoRenda;
            double acrescimos = acrescimoAuxilioEducacao + acrescimoAuxilioCreche;
            double salarioLiquido = salarioBruto - descontos + acrescimos;

            // OUTPUT
            Console.WriteLine("Salário Bruto: " + salarioBruto);
            Console.WriteLine("INSS: " + descontoInss);
            Console.WriteLine("IR: " + descontoImpostoRenda);
            Console.WriteLine("Vale Transporte: " + descontoValeTransporte);
            Console.WriteLine("Auxílio Educação: " + acrescimoAuxilioEducacao);
            Console.WriteLine("Auxílio Creche: " + acrescimoAuxilioCreche);
            Console.WriteLine("Salário Líquido: " + salarioLiquido);

            // https://www.tutorialspoint.com/csharp/index.htm
        }

        // Método é um trecho de código com o objetivo de realizar alguma operação
        // Existem dois tipos de métodos com e sem retorno
        // public double CalcularAreaTriangulo() é um método com retorno do tipo double
        // public void CalcularAreaTriangulo() é um método sem retorno
        // Métodos podem receber parâmetros
        // public double CalcularAreaTriangulo(int lado1, int lado2, int lado) é um método que
        //    recebe 3 parâmetros e tem um retorno do tipo double
        // public void EnviarEmail(string destinatario, int quantidadeReenvios) é um método
        //    que recebe 2 parâmetros e não tem retorno
        public double CalcularInss(double salarioBruto)
        {
            double aliquotaInss = 0;
            if (salarioBruto <= 1302.00)
            {
                aliquotaInss = 7.5;
            }
            else if (salarioBruto <= 2571.29)
            {
                aliquotaInss = 9;
            }
            else if (salarioBruto <= 3856.94)
            {
                aliquotaInss = 12;
            }
            else
            {
                aliquotaInss = 14;
            }
            double descontoInss = salarioBruto * (aliquotaInss / 100);
            return descontoInss;
        }

        public double CalcularImpostoRenda(double salarioBruto)
        {
            double aliquotaImpostoRenda = 0;
            if (salarioBruto >= 1903.99 && salarioBruto <= 2826.65)
            {
                aliquotaImpostoRenda = 0.075;
            }
            else if (salarioBruto >= 2826.66 && salarioBruto <= 3751.05)
            {
                aliquotaImpostoRenda = 0.15;
            }
            else if (salarioBruto >= 3751.06 && salarioBruto <= 4664.68)
            {
                aliquotaImpostoRenda = 0.225;
            }
            else if (salarioBruto >= 4664.69)
            {
                aliquotaImpostoRenda = 0.275;
            }
            double descontoImpostoRenda = salarioBruto * aliquotaImpostoRenda;
            return descontoImpostoRenda;
        }

        public double CalcularAuxilioCreche(bool recebeAuxilioCreche) 
        {
            double acrescimoAuxilioCreche = 0;
            if (recebeAuxilioCreche == true)
                acrescimoAuxilioCreche = 200;

            return acrescimoAuxilioCreche;
        }

        public double CalcularAuxilioEducacao(bool recebeAuxilioEducacao)
        {
            double acrescimoAuxilioEducacao = 0;
            if (recebeAuxilioEducacao == true)
                acrescimoAuxilioEducacao = 400;
            return acrescimoAuxilioEducacao;
        }

        public double CalcularValeTransporte(bool recebeValeTransporte, double salarioBruto)
        {
            double descontoValeTransporte = 0;
            if (recebeValeTransporte == true)
                descontoValeTransporte = salarioBruto * 0.06;
            return descontoValeTransporte;
        }
    }
}
