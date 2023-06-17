using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OrientacaoObjetos
{
    internal class Loja : Executor
    {
        public override void Executar()
        {
            // Instanciando um objeto chamado computadorJose da classe Computador
            Computador computadorJose = new Computador();
            computadorJose.Processador = "i5 11500H";
            computadorJose.PlacaVideo = "GTX 1650 4GB";
            computadorJose.Preco = 4000.00;

            Computador computadorFrancisco = new Computador();
            computadorFrancisco.Processador = "i7 8700";
            computadorFrancisco.PlacaVideo = "GTX 1060 6GB";
            computadorFrancisco.Preco = 2500;

            Computador computadorCristina = new Computador();
            computadorCristina.Processador = "i5 12300";
            computadorCristina.PlacaVideo = "RTX 4090";
            computadorCristina.Preco = 18000;

            double total = computadorJose.Preco + computadorFrancisco.Preco + computadorCristina.Preco;

            Console.WriteLine(
                "Computador do José: " + 
                "\nProcessador: " + computadorJose.Processador + 
                "\nPlaca de Vídeo: " + computadorJose.PlacaVideo + 
                "\nPreço: " + computadorJose.Preco +
                "\n\nComputador do Francisco: " +

                "\nProcessador: " + computadorFrancisco.Processador +
                "\nPlaca de Vídeo: " + computadorFrancisco.PlacaVideo +
                "\nPreço: " + computadorFrancisco.Preco +
                "\n\nComputador do Cristina: " +
                "\nProcessador: " + computadorCristina.Processador +
                "\nPlaca de Vídeo: " + computadorCristina.PlacaVideo +
                "\nPreço: " + computadorCristina.Preco + 
                "\n\nTotal: " + total);
        }
    }
}
