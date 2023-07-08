using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsExemplos.BancoDados;
using WindowsFormsExemplos.Modelos;

namespace WindowsFormsExemplos.Repositorios
{
    internal class CarrinhoRepositorio
    {
        private BancoDadosConexao conexao;

        public CarrinhoRepositorio()
        {
            conexao = new BancoDadosConexao();
        }

        public int AdicionarItemCarrinho(Carrinho carrinho)
        {
            var comando = conexao.Conectar();

            comando.CommandText = @"INSERT INTO carrinho (id_pedido, id_produto, quantidade) VALUES OUTPUT INSERTED.ID
                                    (@ID_PEDIDO, @ID_PRODUTO, @QUANTIDADE)";

            comando.Parameters.AddWithValue("@ID_PEDIDO", carrinho.Venda.Id);
            comando.Parameters.AddWithValue("@ID_PRODUTO", carrinho.Produto.Id);
            comando.Parameters.AddWithValue("@QUANTIDADE", carrinho.Quantidade);

            return Convert.ToInt32(comando.ExecuteScalar());
        }
    }
}
