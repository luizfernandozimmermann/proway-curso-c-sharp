using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.EstruturaCondicional
{
    internal class EstruturaCondicionalAvancada
    {
        public void Executar()
        {
            // INPUT
            Console.Write("Quantidade de horas trabalhadas: ");
            byte horasTrabalhadas = Convert.ToByte(Console.ReadLine());

            Console.Write("Valor hora: ");
            double valorHora = Convert.ToDouble(Console.ReadLine());

            Console.Write("Recebe vale educação? S ou N: ");
            bool valeEducacao =
                Console.ReadLine().ToLower().Trim() == "s" ? true : false;

            Console.Write("Recebe auxilio passe? S ou N: ");
            bool recebeValeTransporte =
                Console.ReadLine().ToLower().Trim() == "s" ? true : false;

            Console.Write("Filhos menores de 5 anos? S ou N: ");
            bool recebeAuxilioCreche =
                Console.ReadLine().ToLower().Trim() == "s" ? true : false;

            // PROCESSAMENTO
            double salarioBruto = horasTrabalhadas * valorHora;

            double descontoInss = calcularInss(salarioBruto);
            double descontoImpostoRenda = calcularImpostoRenda(salarioBruto);            
            double descontoValeTransporte = calcularValeTransporte(recebeValeTransporte, salarioBruto);
           
            double descontos = descontoValeTransporte + descontoInss + descontoImpostoRenda;

            double acescimoAuxilioCreche = calcularAuxilioCreche(recebeAuxilioCreche);            
            double acrescimoAuxilioEducacao = calcularAuxilioEducacao(valeEducacao);            
            
            double acrescimos = acrescimoAuxilioEducacao + acescimoAuxilioCreche;
 
            double salarioLiquido = salarioBruto - descontos + acrescimos;

            // OUTPUT
            Console.WriteLine("Salário bruto: " + salarioBruto);
            Console.WriteLine("Inss: " + descontoInss);
            Console.WriteLine("IR: " + descontoImpostoRenda);
            Console.WriteLine("Vale transporte: " + descontoValeTransporte);
            Console.WriteLine("Auxílio educação: " + acrescimoAuxilioEducacao);
            Console.WriteLine("Auxílio creche: " + acescimoAuxilioCreche);
            Console.WriteLine("Salário líquido: " + salarioLiquido);
        }

        /// <summary>
        /// Calcula o desconto do Vale Transporte
        /// </summary>
        public double calcularValeTransporte(bool recebeValeTransporte, double salarioBruto)
        {
            double descontoValeTransporte = 0;
            if (recebeValeTransporte)
            {
                descontoValeTransporte = salarioBruto * 0.06;
            }
            return descontoValeTransporte;
        }

        /// <summary>
        /// Calcula o acréscimo do Auxílio Educação
        /// </summary>
        public double calcularAuxilioEducacao(bool valeEducacao)
        {
            double acrescimoAuxilioEducacao = 0;
            if (valeEducacao) 
            {
                acrescimoAuxilioEducacao = 400;
            }
            return acrescimoAuxilioEducacao;
        }

        /// <summary>
        /// Calcula o acréscimo do Auxílio Creche
        /// </summary>
        public double calcularAuxilioCreche(bool recebeAuxilioCreche)
        {
            double acescimoAuxilioCreche = 0;
            if (recebeAuxilioCreche)
            {
                acescimoAuxilioCreche = 200;
            }
            return acescimoAuxilioCreche;
        }

        /// <summary>
        /// Calcula o desconto do Imposto de Renda
        /// </summary>
        public double calcularImpostoRenda(double salarioBruto)
        {
            double aliquotaImpostoRenda = 0;
            if (salarioBruto >= 1903.99)
            {
                if (salarioBruto <= 2826.65)
                {
                    aliquotaImpostoRenda = 0.075;
                }
                else if (salarioBruto <= 3751.05)
                {
                    aliquotaImpostoRenda = 0.15;
                }
                else if (salarioBruto <= 4664.68)
                {
                    aliquotaImpostoRenda = 0.225;
                }
                else
                {
                    aliquotaImpostoRenda = 0.275;
                }
            }
            double descontoImpostoRenda = salarioBruto * aliquotaImpostoRenda;

            return descontoImpostoRenda;
        }

        /// <summary>
        /// Calcula o desconto do INSS
        /// </summary>
        public double calcularInss(double salarioBruto)
        {
            double aliquotaInss = 0;
            if (salarioBruto <= 1302)
            {
                aliquotaInss = 7.5;
            }
            else if (salarioBruto <= 25071.29)
            {
                aliquotaInss = 9;
            }
            else if (salarioBruto <= 3854.94)
            {
                aliquotaInss = 12;
            }
            else
            {
                aliquotaInss = 14;
            }
            double descontoInss = salarioBruto / 100 * aliquotaInss;
            return descontoInss;
        }
    }
}
