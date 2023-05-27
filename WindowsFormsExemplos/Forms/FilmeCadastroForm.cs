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
        string caminhoArquivoJsonFilmesDesktop = "";

        public FilmeCadastroForm()
        {
            caminhoArquivoJsonFilmesDesktop =
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                Path.DirectorySeparatorChar +
                "filmes.json";
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
            radioButtonFlopouNao.Checked = true;
            radioButtonFlopouSim.Checked = false;
            textBoxPesquisa.Clear();
            labelCodigoEditar.Text = "";
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var codigoParaEditar = labelCodigoEditar.Text;
            var minutos = Convert.ToUInt16(numericUpDownMinutos.Text);
            var vitoriaOscar = checkBoxOscar.Checked;
            var vitoriaEmmy = checkBoxEmmy.Checked;
            var vitoriaGrammy = checkBoxGrammy.Checked;
            var flopou = radioButtonFlopouSim.Checked;
            var descricao = richTextBoxDescricao.Text;
            var dataLancamento = dateTimePickerDataLancamento.Value;

            if (dataLancamento >= DateTime.Today)
            {
                MessageBox.Show("Data de lançamento deve ser menor que data atual.");
                return;
            }

            if (comboBoxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha uma categoria.");
                return;
            }
            var categoria = (FilmeCategoria)comboBoxCategoria.SelectedItem;

            var filme = new Filme();
            if (codigoParaEditar != "")
            {
                filme = ObterFilmeParaEditar(codigoParaEditar);
            }
            filme.Nome = nome;
            filme.Minutos = minutos;
            filme.VitoriaGrammy = vitoriaGrammy;
            filme.VitoriaOscar = vitoriaOscar;
            filme.VitoriaEmmy = vitoriaEmmy;
            filme.Flopou = flopou;
            filme.Descricao = descricao;
            filme.DataLancamento = dataLancamento;
            filme.Categoria = categoria;

            if (codigoParaEditar == "")
            {
                AdicionarNovoFilme(filme);
            }
            AdicionarFilmesDataGridView(filmes);
            LimparCampos();
            SalvarFilmesEmArquivoJson();
        }

        private Filme ObterFilmeParaEditar(string codigoParaEditar)
        {
            for (int i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];
                if (filme.Codigo.ToString() == codigoParaEditar)
                {
                    return filme;
                }
            }

            return null;
        }

        private void AdicionarNovoFilme(Filme filme)
        {
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
                    filme.Nome,
                    filme.Categoria,
                    filme.Minutos
                });
            }

            labelQuantidadeValor.Text = filmes.Count.ToString();
        }

        private void SalvarFilmesEmArquivoJson()
        {
            var filmesSerializados = JsonConvert.SerializeObject(filmes);

            File.WriteAllText(caminhoArquivoJsonFilmesDesktop, filmesSerializados);
        }

        private void LerFilmesDoArquivoJson()
        {
            if (File.Exists(caminhoArquivoJsonFilmesDesktop) == false)
            {
                return;
            }
            var arquivoLinhas = File.ReadAllText(caminhoArquivoJsonFilmesDesktop);
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
            PreencherComboBoxCategoria();
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
            var codigo = linhaSelecionada.Cells[0].Value.ToString();

            var filme = ObterFilmeParaEditar(codigo);

            textBoxNome.Text = filme.Nome;
            labelCodigoEditar.Text = codigo;
            dateTimePickerDataLancamento.Value = filme.DataLancamento;
            checkBoxEmmy.Checked = filme.VitoriaEmmy;
            checkBoxOscar.Checked = filme.VitoriaOscar;
            checkBoxGrammy.Checked = filme.VitoriaGrammy;
            richTextBoxDescricao.Text = filme.Descricao;
            numericUpDownMinutos.Value = filme.Minutos;
            comboBoxCategoria.SelectedItem = filme.Categoria;
            if (filme.Flopou)
            {
                radioButtonFlopouSim.Checked = true;
            }
            else
            {
                radioButtonFlopouNao.Checked = true;
            }

            labelCodigoEditar.Text = codigo.ToString();
        }

        private void PreencherComboBoxCategoria()
        {
            var categorias = Enum.GetValues<FilmeCategoria>().OrderBy(x => x).ToList();
            comboBoxCategoria.DataSource = categorias;
            comboBoxCategoria.SelectedIndex = -1;
        }
    }
}
