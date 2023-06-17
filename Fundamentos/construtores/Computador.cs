using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.construtores
{
    internal class Computador
    {
        public string ModeloProcessador { get; set; }
        public string ModeloMemoriaRam { get; set; }
        public MemoriaRamEnum MemoriaRam { get; set; }
        public string ModeloPlacaMae { get; set; }
        public string ModeloArmazenamento { get; set; }
        public int Armazenamento { get; set; }
        public string Fonte { get; set; }
        public int CapacidadeFonte { get; set; }

        public Computador(
            string modeloProcessador, 
            MemoriaRamEnum memoriaRam, 
            int capacidadeFonte, 
            int armazenamento) 
        {
            ModeloProcessador = modeloProcessador;
            MemoriaRam = memoriaRam;
            CapacidadeFonte = capacidadeFonte;  
            Armazenamento = armazenamento;
        }
    }
}
