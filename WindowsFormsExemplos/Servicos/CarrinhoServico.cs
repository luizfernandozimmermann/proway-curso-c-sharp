using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsExemplos.Modelos;
using WindowsFormsExemplos.Repositorios;

namespace WindowsFormsExemplos.Servicos
{
    internal class CarrinhoServico
    {
        private CarrinhoRepositorio carrinhoRepositorio;

        public CarrinhoServico()
        {
            carrinhoRepositorio = new CarrinhoRepositorio();
        }

        public int AdicionarItemCarrinho(Carrinho carrinho)
        {
            var idCarrinho = carrinhoRepositorio.AdicionarItemCarrinho(carrinho);

            return idCarrinho;
        }

        internal IList<Carrinho> ObterItensPorIdDoPedido(int idPedido)
        {
            var itensCarrinho = carrinhoRepositorio.ObterItensPorIdDoPedido(idPedido);
            return itensCarrinho;
        }
    }
}
