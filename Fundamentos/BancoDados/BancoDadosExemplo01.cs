using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.BancoDados
{
    internal class BancoDadosExemplo01
    {
        private const string CadeiaConexaoBancoDados = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\73672\Desktop\bancodados.mdf;Integrated Security=True;Connect Timeout=30";

        public void Executar()
        {
            //CriarRegistro();
            //AtualizarRegistro();
            ConsultarRegistros();
        }

        private void ConsultarRegistros()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoBancoDados;
            conexao.Open();
            Console.WriteLine("Conectou");

            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, categoria FROM jogos";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];
                var id = Convert.ToInt32(linha["ID"]);
                var nome = linha["nome"].ToString();
                var categoria = linha["categoria"].ToString();
                Console.WriteLine(
                    $"ID: {id}, Nome: {nome}, Categoria: {categoria}");
            }
        }

        private void AtualizarRegistro()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoBancoDados;
            conexao.Open();
            Console.WriteLine("Conectou");

            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE jogos SET nome = 'God of War 1' WHERE id = 1";
            comando.ExecuteNonQuery();
        }

        private void ApagarRegistro()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoBancoDados;
            conexao.Open();
            Console.WriteLine("Conectou");

            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM jogos WHERE id = 2";
            comando.ExecuteNonQuery();
        }

        private void CriarRegistro()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoBancoDados;
            conexao.Open();
            Console.WriteLine("Conectou");

            var comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO jogos (nome, categoria) VALUES ('God of War', 'RPG')";
            comando.ExecuteNonQuery();
            Console.WriteLine("Registro criado com sucesso.");
        }
    }
}
