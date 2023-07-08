using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsExemplos.Repositorios;
using WindowsFormsExemplos.Servicos;

namespace WindowsFormsExemplos.Forms.Produtos
{
    public partial class CadastroProdutoForm : Form
    {
        private int idProdutoEditar = -1;
        private ProdutoServico produtoServico;

        public CadastroProdutoForm()
        {
            InitializeComponent();
            produtoServico = new ProdutoServico();
        }

        public CadastroProdutoForm(Produto produto) : this()
        {   
            textBoxNome.Text = produto.Nome;
            textBoxQuantidade.Text = produto.Quantidade.ToString();
            textBoxPrecoUnitario.Text = produto.PrecoUnitario.ToString();
            idProdutoEditar = produto.Id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var quantidade = Convert.ToInt32(textBoxQuantidade.Text);
            var precoUnitario = Convert.ToDecimal(textBoxPrecoUnitario.Text);

            var produto = new Produto();
            produto.Nome = nome;
            produto.Quantidade = quantidade;
            produto.PrecoUnitario = precoUnitario;

            if (idProdutoEditar == -1)
            {
                produtoServico.Cadastrar(produto);
                MessageBox.Show("Produto cadastrado com sucesso");
            }
            else
            {
                produto.Id = idProdutoEditar;
                produtoServico.Editar(produto);
                MessageBox.Show("Produto alterado com sucesso");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
