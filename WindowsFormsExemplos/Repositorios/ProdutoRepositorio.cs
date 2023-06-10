using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsExemplos.BancoDados;
using WindowsFormsExemplos.Forms.Produtos;

namespace WindowsFormsExemplos.Repositorios
{
    public class ProdutoRepositorio : CadastroProdutoForm
    {
        public void Cadastrar(string nome, decimal precoUnitario, int quantidade)
        {
            var bancoDadosConexao = new BancoDadosConexao();
            var comando = bancoDadosConexao.Conectar();

            comando.CommandText = $@"INSERT INTO
                produtos (nome, preco_unitario, quantidade)
                VALUES (@NOME, @PRECO_UNITARIO, @QUANTIDADE);";

            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", precoUnitario);
            comando.Parameters.AddWithValue("@QUANTIDADE", quantidade);

            comando.ExecuteNonQuery();
        }

        public void Editar(string nome, decimal precoUnitario, int quantidae, int id)
        {

        }

        public void Apagar(int id)
        {
            var bancoDadosConexao = new BancoDadosConexao();
            var comando = bancoDadosConexao.Conectar();

            comando.CommandText = "DELETE FROM produtos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();
        }

        public List<Produto> ObterTodos()
        {
            var produtos = new List<Produto>();

            var bancoDadosConexao = new BancoDadosConexao();
            var comando = bancoDadosConexao.Conectar();

            comando.CommandText = "SELECT * FROM produtos";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var produto = new Produto();

                produto.Nome = registro["nome"].ToString();
                produto.Quantidade = Convert.ToInt32(registro["quantidade"]);
                produto.PrecoUnitario = Convert.ToDecimal(registro["preco_unitario"]);

                produtos.Add(produto);
            }
            return produtos;
        }
    }

    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; } 
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set;}
}
