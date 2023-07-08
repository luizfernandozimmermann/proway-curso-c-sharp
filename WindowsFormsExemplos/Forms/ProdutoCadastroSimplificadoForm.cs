using ProWayModelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExemplos.Forms
{
    public partial class ProdutoCadastroSimplificadoForm : Form
    {

        private int indiceLinhaEdicao = -1; // Não eh modo de edição

        public ProdutoCadastroSimplificadoForm()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Nome = textBoxNome.Text.Trim();
            if (produto.Nome.Length < 3)
            {
                MessageBox.Show("Nome deve conter no mínimo 3 caracteres");
                textBoxNome.Focus();
                return;
            }

            try
            {
                produto.Quantidade = Convert.ToInt32(textBoxQuantidade.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quantidade deve conter número inteiro");
                textBoxQuantidade.Focus();
                return;
            }
            try
            {
                produto.ValorUnitario = Convert.ToDouble(
                    textBoxPrecoUnitario.Text.Replace("R$", "").Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valor unitário deve conter número real");
                textBoxPrecoUnitario.Focus();
                return;
            }


            // Verificar que não é modo de edição, ou seja, deve criar uma
            // nova linha na tabela
            if (indiceLinhaEdicao == -1)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    produto.Nome,
                    produto.Quantidade,
                    produto.ValorUnitario,
                    produto.Quantidade * produto.ValorUnitario
                });
            }
            else
            {
                dataGridView1.Rows[indiceLinhaEdicao].Cells[0].Value = produto.Nome;
                dataGridView1.Rows[indiceLinhaEdicao].Cells[1].Value = produto.Quantidade;
                dataGridView1.Rows[indiceLinhaEdicao].Cells[2].Value = produto.ValorUnitario;
                dataGridView1.Rows[indiceLinhaEdicao].Cells[3].Value =
                    produto.Quantidade * produto.ValorUnitario;
                indiceLinhaEdicao = -1;
            }

            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            textBoxQuantidade.Clear();
            textBoxPrecoUnitario.Clear();
            textBoxNome.Focus();
        }
        // CRUD
        // C => ✔ Create 
        // R => ✔ Read
        // U => Update
        // D => ✔ Delete

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            // Validar que o usuário selecionou alguma linha
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe produtos cadastrados");
                return;
            }

            // Obtendo o indice da linha selecionada pelo usuário
            int indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            string nome = dataGridView1.Rows[indiceLinhaSelecionada].Cells[0].Value.ToString();
            DialogResult resultado = MessageBox
                .Show($"Deseja realmente apagar o registro '{nome}'?", "AVISO", MessageBoxButtons.YesNo);

            // Validar que o usuário não quer apagar, mantendo o registro do produto na tabela
            if (resultado == DialogResult.No)
            {
                return;
            }

            // Removendo a linha selecionada do DataGridView
            dataGridView1.Rows.RemoveAt(indiceLinhaSelecionada);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto cadastrado");
                return;
            }

            // Obtém o indice da linha desejada para edição
            indiceLinhaEdicao = dataGridView1.SelectedRows[0].Index;

            // Obter os dados da linha selecionada
            string nome = dataGridView1.Rows[indiceLinhaEdicao].Cells[0].Value.ToString();
            int quantidade = Convert.ToInt32(dataGridView1.Rows[indiceLinhaEdicao]
                .Cells[1].Value);
            double valorUnitario = Convert.ToDouble(dataGridView1.Rows[indiceLinhaEdicao]
                .Cells[2].Value);

            // Preenchendo os campos com os dados do produto desejado para edição
            textBoxNome.Text = nome;
            textBoxQuantidade.Text = quantidade.ToString();
            textBoxPrecoUnitario.Text = valorUnitario.ToString();
        }
    }
}
