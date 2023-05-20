using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProWayModelos
{
    public class Filme
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public ushort Minutos { get; set; }
        public FilmeCategoria Categoria { get; set; }
        public bool VitoriaOscar { get; set; }
        public bool VitoriaAmmy { get; set; }
        public bool VitoriaGrammy { get; set; }
        public bool Flopou { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Descricao { get; set; }
    }

    public enum FilmeCategoria
    {
        
    }
}
