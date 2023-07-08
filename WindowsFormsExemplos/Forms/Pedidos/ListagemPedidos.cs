using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExemplos.Forms.Pedidos
{
    public partial class ListagemPedidos : Form
    {
        public ListagemPedidos()
        {
            InitializeComponent();
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
            
        }
    }
}
