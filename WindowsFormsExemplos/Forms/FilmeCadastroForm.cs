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
using ProWayModelos;

namespace WindowsFormsExemplos.Forms
{
    public partial class FilmeCadastroForm : Form
    {
        int codigo = 0;
        List<Filme> filmes = new List<Filme> { };

        public FilmeCadastroForm()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            richTextBoxDescricao.Clear();
            numericUpDownMinutos.Value = 0;
            comboBoxCategoria.SelectedIndex = -1;
            dateTimePickerDataLancamento.ResetText();
            checkBoxOscar.Checked = false;
            checkBoxEmmy.Checked = false;
            checkBoxGrammy.Checked = false;
            radioButtonFlopouNao.Checked = false;
            radioButtonFlopouSim.Checked = false;
            textBoxPesquisa.Clear();
            labelCodigoEditar.Text = "";
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var codigoParaEditar = labelCodigoEditar.Text;

            if (codigoParaEditar == "")
            {
                AdicionarNovoFilme(nome);
            }
            else
            {
                EditarFilme(nome, codigoParaEditar);
            }

            AdicionarFilmesDataGridView(filmes);
            LimparCampos();
            SalvarFilmesEmArquivoJson();
        }

        private void EditarFilme(string nome, string codigoParaEditar)
        {
            for (int i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];
                if (filme.Codigo.ToString() == codigoParaEditar)
                {
                    filme.Nome = nome;
                    break;
                }
            }
        }

        private void AdicionarNovoFilme(string nome)
        {
            var filme = new Filme();
            filme.Nome = nome;
            filme.Codigo = codigo;
            codigo++;

            filmes.Add(filme);
        }

        private void AdicionarFilmesDataGridView(List<Filme> filmes)
        {
            dataGridView.Rows.Clear();

            for (int i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];
                dataGridView.Rows.Add(new object[]
                {
                    filme.Codigo,
                    filme.Nome
                });
            }

            labelQuantidadeValor.Text = filmes.Count.ToString();
        }

        private void SalvarFilmesEmArquivoJson()
        {
            var filmesSerializados = JsonConvert.SerializeObject(filmes);

            File.WriteAllText("C:\\Users\\73672\\Desktop\\filmes.json", filmesSerializados);
        }

        private void LerFilmesDoArquivoJson()
        {
            if (File.Exists("C:\\Users\\73672\\Desktop\\filmes.json") == false)
            {
                return;
            }
            var arquivoLinhas = File.ReadAllText("C:\\Users\\73672\\Desktop\\filmes.json");
            var filmesDeserializados = JsonConvert.DeserializeObject<List<Filme>>(arquivoLinhas);

            if (filmesDeserializados != null)
            {
                filmes = filmesDeserializados;
            }
            ObterUltimoCodigo();
        }

        private void FilmeCadastroForm_Load(object sender, EventArgs e)
        {
            LerFilmesDoArquivoJson();
            AdicionarFilmesDataGridView(filmes);
        }

        private void ObterUltimoCodigo()
        {
            for (int i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];

                if (filme.Codigo > codigo)
                {
                    codigo = filme.Codigo;
                }
            }
            codigo++;
        }

        private void Pesquisar()
        {
            var textoPesquisa = textBoxPesquisa.Text.Trim().ToLower();
            var filmesFiltrados = new List<Filme>();

            for (int i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];

                if (filme.Nome.ToLower().Contains(textoPesquisa))
                {
                    filmesFiltrados.Add(filme);
                }
            }
            AdicionarFilmesDataGridView(filmesFiltrados);
        }

        private void textBoxPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pesquisar();
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum filme cadastrado.");
                return;
            }

            var linhaSelecionada = dataGridView.SelectedRows[0];
            var codigoParaApagar = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            for (int i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];

                if (filme.Codigo == codigoParaApagar)
                {
                    filmes.Remove(filme);
                    break;
                }
            }

            SalvarFilmesEmArquivoJson();
            AdicionarFilmesDataGridView(filmes);
            MessageBox.Show($"Filme apagado com sucesso.");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum filme cadastrado.");
                return;
            }

            var linhaSelecionada = dataGridView.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var nome = linhaSelecionada.Cells[1].Value.ToString();

            textBoxNome.Text = nome;
            labelCodigoEditar.Text = codigo.ToString();
        }
    }
}
