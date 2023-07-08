using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Construtores
{
    internal class Computador
    {
        public string ModeloProcessador { get; set; }
        public string ModeloMemoriaRam { get; set; }
        public MemoriaRamEnum MemoriaRam { get; set; }
        public string ModeloPlacaMae { get; set; }
        public string ModeloArmazenamento { get; set; }
        public int Armazenamento { get; set; }
        public string ModeloFonte { get; set; }
        public int CapacidadeFonte { get; set; }


        // Construtor (é método) tem como objetivo garantir que
        // o objeto será criado com as propriedades necessárias preenchidas,
        // para o correto funcionamento.
        // encapsulamento + NomeClasse(parâmetros)
        public Computador(
            string modeloProcessador,
            MemoriaRamEnum memoriaRam, 
            int capacidadeFonte, 
            int armazenamento)
        {
            // Propriedade = parâmetro
            ModeloProcessador = modeloProcessador;
            MemoriaRam = memoriaRam;
            CapacidadeFonte = capacidadeFonte;
            Armazenamento = armazenamento;
        }
    }
}
