using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsExemplos.Enums;
using WindowsFormsExemplos.Modelos;
using WindowsFormsExemplos.Servicos;

namespace WindowsFormsExemplos.Forms.Pedidos
{
    public partial class ListagemPedidos : Form
    {
        private PedidoServico pedidoServico;
        private ClienteServico clienteServico;
        public ListagemPedidos()
        {
            InitializeComponent();

            pedidoServico = new PedidoServico();
            clienteServico = new ClienteServico();
        }

        private void buttonCriarOrcamento_Click(object sender, EventArgs e)
        {
            var form = new CadastroPedidoForm();
            form.Text = "Criar orçamento";
            form.ApresentarCamposModoOrcamento();
            form.ShowDialog();
            ListarPedidos();
        }

        private void ListarPedidos()
        {
            var cliente = (Cliente)comboBoxClientes.SelectedItem;
            var pedidoStatus = PedidoStatus.Orcamento;
            var pedidos = pedidoServico.ObterTodos(cliente?.Nome ?? null, pedidoStatus);

            dataGridView1.Rows.Clear();

            foreach (var pedido in pedidos)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    pedido.Id,
                    pedido.Cliente.Nome,
                    pedido.Status,
                    "0"
                });
            }
        }

        private void ListagemPedidos_Load(object sender, EventArgs e)
        {
            PreencherComboBoxClientes();
            ListarPedidos();
        }

        private void PreencherComboBoxClientes()
        {
            var clientes = clienteServico.ObterTodos();

            foreach (var cliente in clientes)
            {
                comboBoxClientes.Items.Add(cliente);
            }
        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
