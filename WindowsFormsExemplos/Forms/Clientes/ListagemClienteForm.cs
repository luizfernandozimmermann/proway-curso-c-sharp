using WindowsFormsExemplos.Servicos;

namespace WindowsFormsExemplos.Forms.Clientes
{
    public partial class ListagemClienteForm : Form
    {
        private ClienteServico clienteServico;

        public ListagemClienteForm()
        {
            InitializeComponent();

            clienteServico = new ClienteServico();
        }

        private void ListagemClienteForm_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            var clientes = clienteServico.ObterTodos();

            dataGridView1.Rows.Clear();

            foreach (var cliente in clientes)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    cliente.Id,
                    cliente.Nome,
                    cliente.Cpf
                });
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var form = new CadastroClienteFrom();
            form.ShowDialog();

            ListarClientes();
        }
    }
}
