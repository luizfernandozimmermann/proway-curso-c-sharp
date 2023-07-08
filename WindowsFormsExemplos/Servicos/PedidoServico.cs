using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsExemplos.Enums;
using WindowsFormsExemplos.Modelos;
using WindowsFormsExemplos.Repositorios;

namespace WindowsFormsExemplos.Servicos
{
    internal class PedidoServico
    {
        private PedidoRepositorio pedidoRepositorio;

        public PedidoServico()
        {
            pedidoRepositorio = new PedidoRepositorio();
        }

        internal int CriarOrcamento(Cliente clienteEscolhido)
        {
            var pedido = new Pedido();
            pedido.Cliente = clienteEscolhido;
            pedido.Status = PedidoStatus.Orcamento;

            var pedidoId = pedidoRepositorio.CriarOrcamento(pedido);

            return pedidoId;
        }
    }
}
