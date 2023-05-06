using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OrientacaoObjetos
{
    internal class Loja
    {
        public void Executar()
        {
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
            "Computador José: " +
            "\nProcessador: " + computadorJose.Processador +
            "\nPlaca de vídeo: " + computadorJose.PlacaVideo +
            "\nPreço: " + computadorJose.Preco +
            "Computador Francisco: " +
            "\nProcessador: " + computadorFrancisco.Processador +
            "\nPlaca de vídeo: " + computadorFrancisco.PlacaVideo +
            "\nPreço: " + computadorFrancisco.Preco +
            "Computador José: " +
            "\nProcessador: " + computadorCristina.Processador +
            "\nPlaca de vídeo: " + computadorCristina.PlacaVideo +
            "\nPreço: " + computadorCristina.Preco
                );
        }
    }
}
