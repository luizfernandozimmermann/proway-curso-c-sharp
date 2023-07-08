using System.ComponentModel;

namespace ProWayModelos
{
    public class Filme
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public ushort Minutos { get; set; }
        public FilmeCategoria Categoria { get; set; }
        public bool VitoriaOscar { get; set; }
        public bool VitoriaEmmy { get; set; }
        public bool VitoriaGrammy { get; set; }
        public bool Flopou { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Descricao { get; set; }
    }

    public enum FilmeCategoria
    {
        Acao,
        Comedia,
        Terror,
        Suspense
    }
}
