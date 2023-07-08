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
        private EmailServico emailServico;
        public PedidoServico()
        {
            pedidoRepositorio = new PedidoRepositorio();
            emailServico = new EmailServico();
        }

        internal void CancelarPedido(int idPedido)
        {
            pedidoRepositorio.CancelarPedido(idPedido);
        }

        internal int CriarOrcamento(Cliente clienteEscolhido)
        {
            var pedido = new Pedido();
            pedido.Cliente = clienteEscolhido;
            pedido.Status = PedidoStatus.Orcamento;

            var pedidoId = pedidoRepositorio.CriarOrcamento(pedido);

            return pedidoId;
        }

        internal void FecharPedido(int idPedido, decimal totalPedido)
        {
            pedidoRepositorio.FecharPedido(idPedido, totalPedido);
            emailServico.EnviarEmail("franciscosensaulas@gmail.com", "Aulas", "Corpo do e-mail pedido", "Assunto");
        }

        internal IList<Pedido> ObterTodos(string? cliente, PedidoStatus pedidoStatus)
        {
            var pedidos = pedidoRepositorio.ObterTodos(cliente, pedidoStatus); 
            return pedidos;
        }
    }
}
