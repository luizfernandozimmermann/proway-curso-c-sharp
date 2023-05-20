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

        private int indiceLinhaEdicao = -1;

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
                MessageBox.Show("Nome do produto deve conter pelo menos 3 letras.");
                textBoxNome.ForeColor = Color.Red;
                textBoxNome.Focus();
                return;
            }

            try
            {
                produto.Quantidade = Convert.ToInt32(textBoxQuantidade.Text);
                textBoxQuantidade.ForeColor = Color.Black;
            }
            catch
            {
                MessageBox.Show("Quantidade deve apenas conter números.");
                textBoxQuantidade.ForeColor = Color.Red;
                textBoxQuantidade.Focus();
                return;
            }

            try
            {
                produto.ValorUnitario = Convert.ToDouble(
                    textBoxPrecoUnitario.Text.Replace("R$", "").Trim()
                    );
                textBoxPrecoUnitario.ForeColor = Color.Black;
            }
            catch
            {
                MessageBox.Show("Valor unitário deve apenas conter números reais.");
                textBoxPrecoUnitario.ForeColor = Color.Red;
                textBoxPrecoUnitario.Focus();
                return;
            }

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
                dataGridView1.Rows[indiceLinhaEdicao].Cells[3].Value = produto.ValorUnitario * produto.Quantidade;

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

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma linha selecionada.");
                return;
            }

            int indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            string nomeProduto = dataGridView1.Rows[indiceLinhaSelecionada].Cells[0].Value.ToString();
            DialogResult resultado = MessageBox
                .Show($"Deseja realmente apagar '{nomeProduto}'?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(indiceLinhaSelecionada);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma linha selecionada.");
                return;
            }

            indiceLinhaEdicao = dataGridView1.SelectedRows[0].Index;
            
            string nome = dataGridView1.Rows[indiceLinhaEdicao].Cells[0].Value.ToString();
            string quantidade = dataGridView1.SelectedRows[indiceLinhaEdicao].Cells[1].Value.ToString();
            string valorUnitario = dataGridView1.SelectedRows[indiceLinhaEdicao].Cells[2].Value.ToString();

            textBoxNome.Text = nome;
            textBoxQuantidade.Text = quantidade;
            textBoxPrecoUnitario.Text = valorUnitario;
        }
    }
}
