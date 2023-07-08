using System.Data;
using WindowsFormsExemplos.BancoDados;
using WindowsFormsExemplos.Enums;
using WindowsFormsExemplos.Modelos;

namespace WindowsFormsExemplos.Repositorios
{
    internal class PedidoRepositorio
    {
        private BancoDadosConexao bancoDadosConexao;

        public PedidoRepositorio()
        {
            bancoDadosConexao = new BancoDadosConexao();
        }

        internal void CancelarPedido(int idPedido)
        {
            var comando = bancoDadosConexao.Conectar();
            comando.CommandText = "UPDATE pedidos SET status = @STATUS WHERE id = @ID_PEDIDO";

            comando.Parameters.AddWithValue("@STATUS", PedidoStatus.Cancelado);
            comando.Parameters.AddWithValue("@ID_PEDIDO", idPedido);

            comando.ExecuteNonQuery();
        }

        internal int CriarOrcamento(Pedido pedido)
        {
            var comando = bancoDadosConexao.Conectar();
            comando.CommandText = @"INSERT INTO pedidos (id_cliente, status) 
            OUTPUT INSERTED.ID
            VALUES (@ID_CLIENTE, @STATUS)";
            comando.Parameters.AddWithValue("@ID_CLIENTE", pedido.Cliente.Id);
            comando.Parameters.AddWithValue("@STATUS", pedido.Status);

            var idPedido = Convert.ToInt32(comando.ExecuteScalar());

            return idPedido;
        }

        internal void FecharPedido(int idPedido, decimal totalPedido)
        {
            var comando = bancoDadosConexao.Conectar();
            comando.CommandText = @"UPDATE pedido SET 
                                    status = @STATUS,
                                    total = @TOTAL_PEDIDO WHERE id = @ID_PEDIDO";

            comando.Parameters.AddWithValue("@STATUS", PedidoStatus.Finalizado);
            comando.Parameters.AddWithValue("@TOTAL_PEDIDO", totalPedido);
            comando.Parameters.AddWithValue("@ID_PEDIDO", idPedido);
            comando.ExecuteNonQuery();
        }

        internal IList<Pedido> ObterTodos(string? cliente, PedidoStatus pedidoStatus)
        {
            var comando = bancoDadosConexao.Conectar();

            comando.CommandText = @"SELECT
                pedidos.id AS 'pedido_id',
                pedidos.status AS 'pedido_status',
                clientes.id AS 'cliente_id',
                clientes.nome AS 'cliente_nome'

                FROM pedidos
                INNER JOIN clientes ON (pedidos.id_cliente = clientes.id)";

            if (cliente != null)
            {
            comando.CommandText += "\nWHERE clientes.nome = @CLIENTE_NOME";

            comando.Parameters.AddWithValue("@CLIENTE_NOME", cliente);
            }
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var pedidos = new List<Pedido>();

            foreach (DataRow registro in tabelaEmMemoria.Rows)
            {
                var pedido = ConstruirPedidoComRegistro(registro);
                pedidos.Add(pedido);
            }
            return pedidos;
        }

        private Pedido ConstruirPedidoComRegistro(DataRow registro)
        {
            var pedido = new Pedido();

            pedido.Id = Convert.ToInt32(registro["pedido_id"]);

            pedido.Cliente = new Cliente();
            pedido.Cliente.Id = Convert.ToInt32(registro["cliente_id"]);
            pedido.Cliente.Nome = registro["cliente_nome"].ToString();

            pedido.Status = (PedidoStatus)registro["pedido_status"];

            return pedido;
        }
    }
}
