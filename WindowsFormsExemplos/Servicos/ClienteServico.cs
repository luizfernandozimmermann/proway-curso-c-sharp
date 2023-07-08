using WindowsFormsExemplos.Modelos;
using WindowsFormsExemplos.Repositorios;

namespace WindowsFormsExemplos.Servicos
{
    internal class ClienteServico
    {
        private ClienteRepositorio repositorio;

        public ClienteServico()
        {
            repositorio = new ClienteRepositorio();
        }

        public void Cadastrar(Cliente cliente)
        {
            repositorio.Cadastrar(cliente);
        }

        public List<Cliente> ObterTodos()
        {
            var clientes = repositorio.ObterTodos();
            return clientes;
        }
    }
}
