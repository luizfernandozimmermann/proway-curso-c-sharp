using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Listas
{
    internal class ListaTiposPrimitivos : Executor
    {
        public override void Executar()
        {
            string[] nomesVetor = new string[5];
            nomesVetor[0] = "Fabiana";
            nomesVetor[1] = "Joana";
            nomesVetor[2] = "Uélington";
            nomesVetor[3] = "Manuell";
            nomesVetor[4] = "Robinson";

            // Criando uma lista(vetor) de string
            List<string> nomes = new List<string>();
            nomes.Add("Fabiana"); // CRUD => CREATE
            nomes.Add("Uélington");
            nomes.Add("Robinson");

            Console.WriteLine("Nomes: ");
            Console.WriteLine("Index: 0 " + nomes[0]); // CRUD => READ
            Console.WriteLine($"Index: 1 {nomes[1]}");
            Console.WriteLine($"Index: 2 {nomes[2]}");
            Console.WriteLine($"Index: 3 {nomes[3]}");
            Console.WriteLine($"Index: 4 {nomes[4]}");

            // Remover elemento da lista por nome
            nomes.Remove("Joana"); // Indice: 1
            // Remover elemento da lista por indice
            nomes.RemoveAt(2); // Manuell

            nomes[1] = nomes[1] + " da Silva";

            Console.WriteLine("\n\nNomes: ");
            Console.WriteLine(nomes[0]); // Fabiana
            Console.WriteLine(nomes[1]); // Uélington da Silva
            Console.WriteLine(nomes[2]); // Robinson


            List<int> numeros = new List<int>();
            numeros.Add(1);
            numeros.Add(7);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(8);
            numeros.Add(10);

            List<int> numerosAux = new List<int>
            {
                1, 7, 2, 3, 8, 10
            };

            int somaComFor = 0;
            for (int i = 0; i < numeros.Count; i += 1)
                somaComFor = somaComFor + numeros[i];

            for (int i = 0; i < numeros.Count; i += 1)
                Console.WriteLine($"Posição {i}: {numeros[i]}");

            Console.WriteLine("Soma: " + somaComFor);

            bool existeNumero11NaLista = numeros.Contains(11);
            Console.WriteLine($"Existe o número 11 na lista? {existeNumero11NaLista}");
            int indiceNumero8NaLista = numeros.IndexOf(8);
            Console.WriteLine($"Indice do número 8 na lista: {indiceNumero8NaLista}");

            // Retorna -1 pq n existe o número 11 na lista
            int indiceNumero11NaLista = numeros.IndexOf(11);
            Console.WriteLine($"Indice do número 11 na lista: {indiceNumero11NaLista}");

            // Tipos primitivos:
            //   string, int, short, long, byte, float, double, decimal, bool, char, object
            // https://bit.ly/41U8o76
        }
    }
}
