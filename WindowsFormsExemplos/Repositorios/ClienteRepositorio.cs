using System.Data;
using WindowsFormsExemplos.BancoDados;
using WindowsFormsExemplos.Modelos;

namespace WindowsFormsExemplos.Repositorios
{
    internal class ClienteRepositorio
    {
        private BancoDadosConexao bancoDadosConexao;

        public ClienteRepositorio()
        {
            bancoDadosConexao = new BancoDadosConexao();
        }

        public void Cadastrar(Cliente cliente)
        {
            var comando = bancoDadosConexao.Conectar();
            comando.CommandText = @"INSERT INTO clientes 
                (nome,  cpf,  data_nascimento,  estado,  cidade,  bairro,  cep,  
                logradouro,  numero,  complemento)
            VALUES 
                (@NOME, @CPF, @DATA_NASCIMENTO, @ESTADO, @CIDADE, @BAIRRO, @CEP, 
                @LOGRADOURO, @NUMERO, @COMPLEMENTO)";

            comando.Parameters.AddWithValue("@NOME", cliente.Nome);
            comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DataNascimento);
            comando.Parameters.AddWithValue("@ESTADO", cliente.Endereco.Estado);
            comando.Parameters.AddWithValue("@CIDADE", cliente.Endereco.Cidade);
            comando.Parameters.AddWithValue("@BAIRRO", cliente.Endereco.Bairro);
            comando.Parameters.AddWithValue("@CEP", cliente.Endereco.Cep);
            comando.Parameters.AddWithValue("@LOGRADOURO", cliente.Endereco.Logradouro);
            comando.Parameters.AddWithValue("@NUMERO", cliente.Endereco.Numero);
            comando.Parameters.AddWithValue("@COMPLEMENTO", cliente.Endereco.Complemento);

            comando.ExecuteNonQuery();
        }

        public List<Cliente> ObterTodos()
        {
            var bancoDadosConexao = new BancoDadosConexao();
            var comando = bancoDadosConexao.Conectar();
            comando.CommandText = "SELECT * FROM clientes";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var clientes = new List<Cliente>();
            foreach (DataRow registro in tabelaEmMemoria.Rows)
            {
                var cliente = new Cliente();

                cliente.Id = Convert.ToInt32(registro["id"]);
                cliente.Nome = registro["nome"].ToString();
                cliente.Cpf = registro["cpf"].ToString();
                cliente.DataNascimento = Convert.ToDateTime(registro["data_nascimento"]);

                cliente.Endereco = new Endereco();
                cliente.Endereco.Cep = registro["cep"].ToString();
                cliente.Endereco.Numero = registro["numero"].ToString();
                cliente.Endereco.Estado = registro["estado"].ToString();
                cliente.Endereco.Cidade = registro["cidade"].ToString();
                cliente.Endereco.Bairro = registro["bairro"].ToString();
                cliente.Endereco.Complemento = registro["complemento"].ToString();

                clientes.Add(cliente);
            }

            return clientes;
        }
    }
}
