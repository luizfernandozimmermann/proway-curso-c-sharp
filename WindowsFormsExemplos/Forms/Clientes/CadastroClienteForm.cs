using Newtonsoft.Json;
using System.Net;
using WindowsFormsExemplos.Modelos;
using WindowsFormsExemplos.Servicos;

namespace WindowsFormsExemplos.Forms.Clientes
{
    public partial class CadastroClienteForm : Form
    {
        private ClienteServico clienteServico;

        public CadastroClienteForm()
        {
            InitializeComponent();

            clienteServico = new ClienteServico();
        }

        private void BuscarEnderecoPorCep()
        {
            try
            {
                var cep = maskedTextBoxCep.Text;

                var url = $"https://viacep.com.br/ws/{cep}/json/";

                var httpCliente = new HttpClient();
                var response = httpCliente.GetAsync(url).GetAwaiter().GetResult();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseTexto = response.Content.ReadAsStringAsync().Result;
                    var endereco = JsonConvert.DeserializeObject
                        <Dictionary<string, string>>(responseTexto);

                    comboBoxEstado.SelectedItem = endereco["uf"].ToUpper();
                    textBoxCidade.Text = endereco["localidade"];
                    textBoxBairro.Text = endereco["bairro"];
                    textBoxLogradouro.Text = endereco["logradouro"];
                    textBoxNumero.Focus();
                }
            }catch (Exception ex)
            {

            }
            
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            BuscarEnderecoPorCep();
        }

        private void maskedTextBoxCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarEnderecoPorCep();
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var cpf = maskedTextBoxCpf.Text;
            var dataNascimento = dateTimePickerDataNascimento.Value;

            var estado = comboBoxEstado.Text.Trim();
            var cidade = textBoxCidade.Text.Trim();
            var bairro = textBoxBairro.Text.Trim();
            var cep = maskedTextBoxCep.Text.Trim();
            var logradouro = textBoxLogradouro.Text.Trim();
            var numero = textBoxNumero.Text.Trim();
            var complemento = richTextBoxComplemento.Text.Trim();

            var cliente = new Cliente();
            cliente.Nome = nome;
            cliente.Cpf = cpf;
            cliente.DataNascimento = dataNascimento;
            cliente.Endereco.Estado = estado;
            cliente.Endereco.Cidade = cidade;
            cliente.Endereco.Bairro = bairro;
            cliente.Endereco.Cep = cep;
            cliente.Endereco.Logradouro = logradouro;
            cliente.Endereco.Numero = numero;
            cliente.Endereco.Complemento = complemento;

            clienteServico.Cadastrar(cliente);

            MessageBox.Show("Cliente cadastrado com sucesso!");
        }
    }
}
