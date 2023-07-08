using System;
using System.Collections.Generic;
using System.Data;
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

            comando.CommandText = @"INSERT INTO carrinho (id_pedido, id_produto, quantidade) OUTPUT INSERTED.ID VALUES
                                    (@ID_PEDIDO, @ID_PRODUTO, @QUANTIDADE)";

            comando.Parameters.AddWithValue("@ID_PEDIDO", carrinho.Venda.Id);
            comando.Parameters.AddWithValue("@ID_PRODUTO", carrinho.Produto.Id);
            comando.Parameters.AddWithValue("@QUANTIDADE", carrinho.Quantidade);

            return Convert.ToInt32(comando.ExecuteScalar());
        }

        internal IList<Carrinho> ObterItensPorIdDoPedido(int idPedido)
        {
            var comando = conexao.Conectar();

            comando.CommandText = @"SELECT
                                    carrinho.id AS 'carrinho_id',
                                    carrinho.quantidade AS 'carrinho_quantidade',
                                    produtos.id AS 'produto_id',
                                    produtos.preco_unitario AS 'produto_preco_unitario',
                                    produtos.nome AS 'produto_nome'
                                    FROM carrinho 
                                    INNER JOIN produtos ON (carrinho.id_produto = produtos.id)
                                    WHERE carrinho.id_pedido = @ID_PEDIDO";

            comando.Parameters.AddWithValue("@ID_PEDIDO", idPedido);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var itensCarrinho = new List<Carrinho>();

            foreach (DataRow registro in tabelaEmMemoria.Rows)
            {
                var itemCarrinho = ConstruirItemCarrinhoDoRegistro(registro);
                itensCarrinho.Add(itemCarrinho);
            }
            return itensCarrinho;
        }

        private Carrinho ConstruirItemCarrinhoDoRegistro(DataRow registro)
        {
            var carrinho = new Carrinho();

            carrinho.Id = Convert.ToInt32(registro["carrinho_id"]);
            carrinho.Quantidade = Convert.ToInt32(registro["carrinho_quantidade"]);

            carrinho.Produto = new Produto();
            carrinho.Produto.PrecoUnitario = Convert.ToDecimal(registro["produto_preco_unitario"]);
            carrinho.Produto.Nome = registro["produto_nome"]?.ToString() ?? "";

            return carrinho;
        }
    }
}
