using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsExemplos.Forms.Clientes;
using WindowsFormsExemplos.Forms.Pedidos;
using WindowsFormsExemplos.Forms.Produtos;

namespace WindowsFormsExemplos.Forms
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void buttonFolhaPagamento_Click(object sender, EventArgs e)
        {
            // <NomeClasse> <nomeObjeto> = new <NomeClasse>();
            Form1 folhaPagamentoForm = new Form1();
            folhaPagamentoForm.Show();
        }

        private void buttonCadastroSimplificadoProduto_Click(object sender, EventArgs e)
        {
            ProdutoCadastroSimplificadoForm form = new ProdutoCadastroSimplificadoForm();
            form.ShowDialog();
        }

        private void buttonCadastroFilmes_Click(object sender, EventArgs e)
        {
            FilmeCadastroForm form = new FilmeCadastroForm();
            form.ShowDialog();
        }

        private void buttonCadastroSimplificadoProdutoBancoDados_Click(object sender, EventArgs e)
        {
            var form = new ProdutoCadastroSimplicadoBancoDadosForm();
            form.ShowDialog();
        }

        private void buttonListaProdutos_Click(object sender, EventArgs e)
        {
            var form = new ListagemProdutoForm();
            form.ShowDialog();
        }

        private void buttonListaClientes_Click(object sender, EventArgs e)
        {
            var form = new ListagemClienteForm();
            form.ShowDialog();
        }

        private void buttonListarProdutos_Click(object sender, EventArgs e)
        {
            var form = new ListagemPedidos();
            form.ShowDialog();
        }
    }
}
