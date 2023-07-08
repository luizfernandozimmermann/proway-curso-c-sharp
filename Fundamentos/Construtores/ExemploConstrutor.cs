using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Construtores
{
    internal class ExemploConstrutor : Executor
    {
        public override void Executar()
        {
            var computadorJose = new Computador(
                "Inte Core i5 11ª Geração",
                MemoriaRamEnum.Memoria32Gb,
                500,
                1024);

            var computadorLeilane = new Computador(
                "Intel Core i7",
                MemoriaRamEnum.Memoria32Gb,
                1000,
                512);

            var computadorLuiz = new Computador(
                "Intel Core i5 7ª Geração",
                MemoriaRamEnum.Memoria16Gb,
                500,
                2048);
        }
    }
}
