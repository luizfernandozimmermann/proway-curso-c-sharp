using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsExemplos.BancoDados;
using WindowsFormsExemplos.Modelos;

namespace WindowsFormsExemplos.Repositorios
{
    public class ProdutoRepositorio
    {
        private BancoDadosConexao bancoDadosConexao;

        public ProdutoRepositorio()
        {
            bancoDadosConexao = new BancoDadosConexao();
        }
        // CRUD
        public void Cadastrar(Produto produto)
        {
            var comando = bancoDadosConexao.Conectar();

            comando.CommandText = @"INSERT INTO produtos (nome, preco_unitario, quantidade) 
VALUES (@NOME, @PRECO_UNITARIO, @QUANTIDADE);";

            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", produto.PrecoUnitario);
            comando.Parameters.AddWithValue("@QUANTIDADE", produto.Quantidade);

            comando.ExecuteNonQuery();
        }

        public void Editar(Produto produto)
        {
            var comando = bancoDadosConexao.Conectar();

            comando.CommandText = "UPDATE produtos SET " +
                "nome = @NOME, preco_unitario = @PRECO_UNITARIO, quantidade = @QUANTIDADE " +
                "WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", produto.Id);
            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", produto.PrecoUnitario);
            comando.Parameters.AddWithValue("@QUANTIDADE", produto.Quantidade);

            comando.ExecuteNonQuery();
        }

        public void Apagar(int id)
        {
            // Abrir conexão
            var comando = bancoDadosConexao.Conectar();

            // Definir o comando
            comando.CommandText = "DELETE FROM produtos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            // Executar o comando de apagar o registro
            comando.ExecuteNonQuery();
        }

        public List<Produto> ObterTodos()
        {
            var produtos = new List<Produto>();
            // Abrir a conexão
            var comando = bancoDadosConexao.Conectar();

            // Executar o comando de SELECT
            comando.CommandText = "SELECT * FROM produtos";

            // Criar tabela em memória para carregar os registros da tabela de produtos
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Criar a lista de produtos com os produtos do banco de dados
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                // Obter o registro(consultado da tabela de produtos) da tabela em memória
                var registro = tabelaEmMemoria.Rows[i];
                
                // Instanciar um objeto da classe Produto
                var produto = ConstruirProdutoDoRegistro(registro);

                // Adicionar o produto na lista de produtos
                produtos.Add(produto);
            }
            // Retornar a lista de produtos (com os
            // registros da tabela de produtos (Banco de Dados))
            return produtos;
        }

        public Produto ObterPorId(int id)
        {
            var comando = bancoDadosConexao.Conectar();

            comando.CommandText = "SELECT * FROM produtos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var linha = tabelaEmMemoria.Rows[0];

            var produto = ConstruirProdutoDoRegistro(linha);
            return produto;
        }

        private Produto ConstruirProdutoDoRegistro(DataRow linha)
        {
            var produto = new Produto();
            produto.Id = Convert.ToInt32(linha["id"]);
            produto.Nome = linha["nome"].ToString();
            produto.Quantidade = Convert.ToInt32(linha["quantidade"]);
            produto.PrecoUnitario = Convert.ToDecimal(linha["preco_unitario"]);

            return produto;
        }

    }
}
