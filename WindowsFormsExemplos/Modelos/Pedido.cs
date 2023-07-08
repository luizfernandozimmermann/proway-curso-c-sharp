using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsExemplos.Enums;

namespace WindowsFormsExemplos.Modelos
{
    internal class Pedido : ModeloBase
    {
        public Cliente Cliente { get; set; }
        public DateTime? DataEfetivacao { get; set; }
        public decimal Total { get; set; }
        public PedidoStatus Status { get; internal set; }
    }
}
