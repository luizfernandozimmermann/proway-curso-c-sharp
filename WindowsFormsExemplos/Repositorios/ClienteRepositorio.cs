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
    }
}
