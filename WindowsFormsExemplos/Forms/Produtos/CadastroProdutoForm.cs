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

        public CadastroProdutoForm()
        {
            InitializeComponent();
        }

        public CadastroProdutoForm(Produto produto)
        {
            InitializeComponent();
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

            var produtoServico = new ProdutoServico();

            if (idProdutoEditar == -1)
            {
                produtoServico.Cadastrar(nome, precoUnitario, quantidade);
                MessageBox.Show("Produto cadastrado com sucesso");
            }
            else
            {
                produtoServico.Editar(idProdutoEditar, nome, precoUnitario, quantidade);
                MessageBox.Show("Produto alterado com sucesso");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
