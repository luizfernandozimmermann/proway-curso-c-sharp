using ProWayModelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExemplos.Forms
{
    public partial class ProdutoCadastroSimplificadoBancoDadosForm : Form
    {
        int idParaEditar = -1;
        public ProdutoCadastroSimplificadoBancoDadosForm()
        {
            InitializeComponent();
        }

        private void ListarProdutos()
        {
            var comando = Conectar();
            comando.CommandText = "SELECT * FROM produtos";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            comando.Connection.Close();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];
                var preco = Convert.ToDouble(linha["preco_unitario"]) * Convert.ToInt32(linha["quantidade"]);
                dataGridView1.Rows.Add(new object[]
                {
                    linha["id"],
                    linha["nome"],
                    linha["quantidade"],
                    linha["preco_unitario"],
                    preco.ToString()
                });
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var quantidade = Convert.ToInt32(textBoxQuantidade.Text.Trim());
            var precoUnitario = Convert.ToDouble(textBoxPrecoUnitario.Text.Trim());

            if (idParaEditar == -1)
            {
                Cadastrar(nome, quantidade, precoUnitario);
            }
            else
            {
                Editar(nome, quantidade, precoUnitario);
            }
            ListarProdutos();
            LimparCampos();
        }

        private void Editar(string nome, int quantidade, double precoUnitario)
        {
            var comando = Conectar();
            comando.CommandText = @"UPDATE produtos SET
                    nome = @NOME,
                    quantidade = @QUANTIDADE,
                    preco_unitario = @PRECO_UNITARIO
                    WHERE id = @ID";

            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@QUANTIDADE", quantidade);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", precoUnitario);
            comando.Parameters.AddWithValue("@ID", idParaEditar);
            comando.ExecuteNonQuery();
            MessageBox.Show("Editado com sucesso!");
        }

        private void LimparCampos()
        {
            textBoxNome.Text = "";
            textBoxQuantidade.Text = "";
            textBoxPrecoUnitario.Text = "";
            idParaEditar = -1;
        }

        private void Cadastrar(string nome, int quantidade, double precoUnitario)
        {
            var comando = Conectar();
            comando.CommandText = $@"INSERT INTO
                produtos (nome, preco_unitario, quantidade)
                VALUES (@NOME, @PRECO_UNITARIO, @QUANTIDADE);";

            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", precoUnitario);
            comando.Parameters.AddWithValue("@QUANTIDADE", quantidade);

            comando.ExecuteNonQuery();
            MessageBox.Show("Produto Cadastrado com sucesso");
        }

        private SqlCommand Conectar()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Luiz Fernando\Desktop\programacao\C#\proway-curso-c-sharp\WindowsFormsExemplos\BancoDados\WindowsFormsBancoDados.mdf"";Integrated Security=True";
            conexao.Open();

            var comando = conexao.CreateCommand();
            return comando;
        }

        private void ProdutoCadastroSimplificadoBancoDadosForm_Load(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var comando = Conectar();
            comando.CommandText = "DELETE FROM produtos WHERE id = @ID";

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = linhaSelecionada.Cells[0].Value;
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();

            MessageBox.Show("Produto apagado com sucesso.");
            ListarProdutos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            idParaEditar = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            textBoxNome.Text = linhaSelecionada.Cells[1].Value.ToString();
            textBoxQuantidade.Text = linhaSelecionada.Cells[2].Value.ToString();
            textBoxPrecoUnitario.Text = linhaSelecionada.Cells[3].Value.ToString();
        }
    }
}
