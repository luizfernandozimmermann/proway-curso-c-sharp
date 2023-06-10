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
        public void Cadastrar(string nome, decimal precoUnitario, int quantidade)
        {
            var produtoRepositorio = new ProdutoRepositorio();
            produtoRepositorio.Cadastrar(nome, precoUnitario, quantidade);
        }

        public List<Produto> ObterTodos()
        {
            var produtoRepositorio = new ProdutoRepositorio();
            var produtos = produtoRepositorio.ObterTodos();
            return produtos;
        }

        public void Apagar(int id)
        {
            var produtoRepositorio = new ProdutoRepositorio();
            produtoRepositorio.Apagar(id);
        }
    }
}
