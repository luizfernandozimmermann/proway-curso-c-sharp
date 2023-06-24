using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsExemplos.Repositorios;

namespace WindowsFormsExemplos.Servicos
{
    public class ProdutoServico 
    {
        private ProdutoRepositorio produtoRepositorio;
        
        public ProdutoServico() {
             produtoRepositorio = new ProdutoRepositorio();
        }

        public void Cadastrar(string nome, decimal precoUnitario, int quantidade)
        {
            produtoRepositorio.Cadastrar(nome, precoUnitario, quantidade);
        }

        public List<Produto> ObterTodos()
        {
            // Obter a lista de produtos da tabela de produtos
            var produtos = produtoRepositorio.ObterTodos();
            // Retornar a lista de produtos
            return produtos;
        }

        public void Apagar(int id)
        {
            // Instanciando um objeto da class ProdutoRepositorio
            // Chamar o método Apagar do ProdutoRepositorio(que irá executar o DELETE)
            produtoRepositorio.Apagar(id);
        }

        public Produto ObterPorId(int id)
        {
            var produto = produtoRepositorio.ObterPorId(id);
            return produto;
        }

        public void Editar(int idProdutoEditar, string nome, decimal precoUnitario, int quantidade)
        {
            produtoRepositorio.Editar(idProdutoEditar, nome, precoUnitario, quantidade);
        }
    }
}
