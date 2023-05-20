using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Listas
{
    internal class ListaTiposPrimitivos
    {
        public void Executar()
        {
            List<string> nomes = new List<string>();

            nomes.Add("Fabiana");
            nomes.Add("Joana");
            nomes.Add("Uélington");
            nomes.Add("Manuell");
            nomes.Add("Robinson");

            Console.WriteLine("Nomes: ");
            Console.WriteLine($"Index 0: {nomes[0]}");
            Console.WriteLine($"Index 1: {nomes[1]}");
            Console.WriteLine($"Index 2: {nomes[2]}");
            Console.WriteLine($"Index 3: {nomes[3]}");
            Console.WriteLine($"Index 4: {nomes[4]}");

            nomes.Remove("Joana");

            nomes.RemoveAt(2);

            nomes[1] += " da Silva";

            Console.WriteLine("\n\nNomes: ");
            Console.WriteLine($"Index 0: {nomes[0]}");
            Console.WriteLine($"Index 1: {nomes[1]}");
            Console.WriteLine($"Index 2: {nomes[2]}");

            List<int> numeros = new List<int>();
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(8);
            numeros.Add(3);
            numeros.Add(10);
            numeros.Add(11);
            numeros.Add(30);

            int somaComFor = 0;
            for (int i = 0; i < numeros.Count; i++)
            {
                somaComFor += numeros[i];
                Console.WriteLine($"Posição {i}: {numeros[i]}");
            }

            Console.WriteLine("Soma: " + somaComFor);

            bool existeNumero11NaLista = numeros.Contains(11);
            Console.WriteLine($"Existe número 11 na lista? {existeNumero11NaLista}");

            int indiceNumero8NaLista = numeros.IndexOf(8);
            Console.WriteLine($"Indice do número 8 na lista: {indiceNumero8NaLista}");

            int indiceNumero11NaLista = numeros.IndexOf(11);
            Console.WriteLine($"Índice do número 11 na lista: {indiceNumero11NaLista}");
        }
    }
}
