using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WindowsFormsExemplos.Servicos;

namespace WindowsFormsExemplos.Forms.Produtos
{
    public partial class ListagemProdutoForm : Form
    {
        private ProdutoServico produtoServico;

        public ListagemProdutoForm()
        {
            InitializeComponent();

            produtoServico = new ProdutoServico();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var formulario = new CadastroProdutoForm();
            formulario.Text = "Cadatrar Produto";
            formulario.ShowDialog();

            ListarProdutos();
        }

        private void ListagemProdutoForm_Load(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void ListarProdutos()
        {
            // Obter o texto que o usuário digitou para filtrar os produtos
            var pesquisa = textBoxPesquisa.Text.Trim();

            // Obter a lista de produtos
            var produtos = produtoServico.ObterTodos(pesquisa);
            
            // Remover todas as linhas do DataGridView
            dataGridView1.Rows.Clear();

            // Percorrer a lista dos produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obter o produto iterado
                var produto = produtos[i];

                // Adicionar linha no dataGridView com as informações
                // do produto iterado
                dataGridView1.Rows.Add(new object[] {
                    produto.Id,
                    produto.Nome,
                    produto.Quantidade,
                    produto.PrecoUnitario
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            // Obter a linha selecionada do dataGridView1
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            // Obter o valor da primeira coluna(código=='id') da linha selecionada
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Chamar o método que irá realizar o delete
            produtoServico.Apagar(id);

            // Atualizar o dataGridView1 com a lista produtos da tabela de produtos
            ListarProdutos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var produtoEscolhido = produtoServico.ObterPorId(id);

            var form = new CadastroProdutoForm(produtoEscolhido);
            form.ShowDialog();

            ListarProdutos();
        }

        private void textBoxPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            // Quando usuário apertar a tecla enter irá filtrar os produtos (buscar no banco de dados)
            if (e.KeyCode == Keys.Enter)
            {
                ListarProdutos();
            }
        }
    }
}
