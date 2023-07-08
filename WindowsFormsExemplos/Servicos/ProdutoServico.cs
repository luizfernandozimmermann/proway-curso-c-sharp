using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsExemplos.Modelos;
using WindowsFormsExemplos.Repositorios;

namespace WindowsFormsExemplos.Servicos
{
    public class ProdutoServico
    {
        private ProdutoRepositorio produtoRepositorio;

        // Construtor
        public ProdutoServico()
        {
            // Instanciando o objeto da classe ProdutoRepositorio 
            produtoRepositorio = new ProdutoRepositorio();
        }

        // CRUD
        public void Cadastrar(Produto produto)
        {
            produtoRepositorio.Cadastrar(produto);
        }

        public List<Produto> ObterTodos(string pesquisa)
        {
            // Obter a lista de produtos da tabela de produtos
            var produtos = produtoRepositorio.ObterTodos(pesquisa);
            // Retornar a lista de produtos
            return produtos;
        }

        public void Apagar(int id)
        {
            // Chamar o método Apagar do ProdutoRepositorio(que irá executar o DELETE)
            produtoRepositorio.Apagar(id);
        }

        public Produto ObterPorId(int id)
        {
            var produto = produtoRepositorio.ObterPorId(id);
            return produto;
        }

        internal void Editar(Produto produto)
        {
            produtoRepositorio.Editar(produto);
        }
    }
}
