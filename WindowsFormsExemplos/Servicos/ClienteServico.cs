using WindowsFormsExemplos.Modelos;
using WindowsFormsExemplos.Repositorios;

namespace WindowsFormsExemplos.Servicos
{
    internal class ClienteServico
    {
        private ClienteRepositorio repositorio { get; set; }

        public ClienteServico()
        {
            repositorio = new ClienteRepositorio();
        }

        public void Cadastrar(Cliente cliente)
        {
            repositorio.Cadastrar(cliente); 
        }
    }
}
