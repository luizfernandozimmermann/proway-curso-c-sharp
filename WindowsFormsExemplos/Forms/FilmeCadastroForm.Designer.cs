namespace WindowsFormsExemplos.Forms
{
    partial class FilmeCadastroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            ColumnCodigo = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnCategoria = new DataGridViewTextBoxColumn();
            ColumnDuracao = new DataGridViewTextBoxColumn();
            labelNome = new Label();
            numericUpDownMinutos = new NumericUpDown();
            textBoxNome = new TextBox();
            comboBoxCategoria = new ComboBox();
            labelMinutos = new Label();
            labelCategoria = new Label();
            checkBoxOscar = new CheckBox();
            checkBoxEmmy = new CheckBox();
            checkBoxGrammy = new CheckBox();
            radioButtonFlopouSim = new RadioButton();
            radioButtonFlopouNao = new RadioButton();
            labelDescricao = new Label();
            richTextBoxDescricao = new RichTextBox();
            dateTimePickerDataLancamento = new DateTimePicker();
            labelDataLancamento = new Label();
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            labelVitorias = new Label();
            labelFlopou = new Label();
            labelListaFilmes = new Label();
            labelPesquisa = new Label();
            textBoxPesquisa = new TextBox();
            buttonApagar = new Button();
            buttonEditar = new Button();
            labelQuantidadeValor = new Label();
            labelQuantidade = new Label();
            labelCodigoEditar = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutos).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnCodigo, ColumnNome, ColumnCategoria, ColumnDuracao });
            dataGridView.Location = new Point(12, 58);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(669, 489);
            dataGridView.TabIndex = 0;
            // 
            // ColumnCodigo
            // 
            ColumnCodigo.HeaderText = "Código";
            ColumnCodigo.Name = "ColumnCodigo";
            ColumnCodigo.ReadOnly = true;
            // 
            // ColumnNome
            // 
            ColumnNome.HeaderText = "Nome";
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            // 
            // ColumnCategoria
            // 
            ColumnCategoria.HeaderText = "Categoria";
            ColumnCategoria.Name = "ColumnCategoria";
            ColumnCategoria.ReadOnly = true;
            // 
            // ColumnDuracao
            // 
            ColumnDuracao.HeaderText = "Duração";
            ColumnDuracao.Name = "ColumnDuracao";
            ColumnDuracao.ReadOnly = true;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(812, 9);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome";
            // 
            // numericUpDownMinutos
            // 
            numericUpDownMinutos.Location = new Point(812, 76);
            numericUpDownMinutos.Name = "numericUpDownMinutos";
            numericUpDownMinutos.Size = new Size(136, 23);
            numericUpDownMinutos.TabIndex = 2;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(812, 27);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(423, 23);
            textBoxNome.TabIndex = 3;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(969, 76);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(266, 23);
            comboBoxCategoria.TabIndex = 4;
            // 
            // labelMinutos
            // 
            labelMinutos.AutoSize = true;
            labelMinutos.Location = new Point(812, 58);
            labelMinutos.Name = "labelMinutos";
            labelMinutos.Size = new Size(51, 15);
            labelMinutos.TabIndex = 5;
            labelMinutos.Text = "Minutos";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(969, 58);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(58, 15);
            labelCategoria.TabIndex = 6;
            labelCategoria.Text = "Categoria";
            // 
            // checkBoxOscar
            // 
            checkBoxOscar.AutoSize = true;
            checkBoxOscar.Location = new Point(812, 137);
            checkBoxOscar.Name = "checkBoxOscar";
            checkBoxOscar.Size = new Size(56, 19);
            checkBoxOscar.TabIndex = 7;
            checkBoxOscar.Text = "Oscar";
            checkBoxOscar.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmmy
            // 
            checkBoxEmmy.AutoSize = true;
            checkBoxEmmy.Location = new Point(812, 162);
            checkBoxEmmy.Name = "checkBoxEmmy";
            checkBoxEmmy.Size = new Size(60, 19);
            checkBoxEmmy.TabIndex = 8;
            checkBoxEmmy.Text = "Emmy";
            checkBoxEmmy.UseVisualStyleBackColor = true;
            // 
            // checkBoxGrammy
            // 
            checkBoxGrammy.AutoSize = true;
            checkBoxGrammy.Location = new Point(812, 187);
            checkBoxGrammy.Name = "checkBoxGrammy";
            checkBoxGrammy.Size = new Size(72, 19);
            checkBoxGrammy.TabIndex = 9;
            checkBoxGrammy.Text = "Grammy";
            checkBoxGrammy.UseVisualStyleBackColor = true;
            // 
            // radioButtonFlopouSim
            // 
            radioButtonFlopouSim.AutoSize = true;
            radioButtonFlopouSim.Location = new Point(968, 136);
            radioButtonFlopouSim.Name = "radioButtonFlopouSim";
            radioButtonFlopouSim.Size = new Size(45, 19);
            radioButtonFlopouSim.TabIndex = 11;
            radioButtonFlopouSim.TabStop = true;
            radioButtonFlopouSim.Text = "Sim";
            radioButtonFlopouSim.UseVisualStyleBackColor = true;
            // 
            // radioButtonFlopouNao
            // 
            radioButtonFlopouNao.AutoSize = true;
            radioButtonFlopouNao.Location = new Point(968, 162);
            radioButtonFlopouNao.Name = "radioButtonFlopouNao";
            radioButtonFlopouNao.Size = new Size(47, 19);
            radioButtonFlopouNao.TabIndex = 12;
            radioButtonFlopouNao.TabStop = true;
            radioButtonFlopouNao.Text = "Não";
            radioButtonFlopouNao.UseVisualStyleBackColor = true;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Location = new Point(812, 285);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(58, 15);
            labelDescricao.TabIndex = 13;
            labelDescricao.Text = "Descrição";
            // 
            // richTextBoxDescricao
            // 
            richTextBoxDescricao.Location = new Point(812, 303);
            richTextBoxDescricao.Name = "richTextBoxDescricao";
            richTextBoxDescricao.Size = new Size(423, 213);
            richTextBoxDescricao.TabIndex = 14;
            richTextBoxDescricao.Text = "";
            // 
            // dateTimePickerDataLancamento
            // 
            dateTimePickerDataLancamento.Format = DateTimePickerFormat.Short;
            dateTimePickerDataLancamento.Location = new Point(812, 240);
            dateTimePickerDataLancamento.Name = "dateTimePickerDataLancamento";
            dateTimePickerDataLancamento.Size = new Size(423, 23);
            dateTimePickerDataLancamento.TabIndex = 15;
            // 
            // labelDataLancamento
            // 
            labelDataLancamento.AutoSize = true;
            labelDataLancamento.Location = new Point(812, 222);
            labelDataLancamento.Name = "labelDataLancamento";
            labelDataLancamento.Size = new Size(116, 15);
            labelDataLancamento.TabIndex = 16;
            labelDataLancamento.Text = "Data de Lançamento";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(812, 522);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(209, 66);
            buttonCancelar.TabIndex = 17;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(1027, 522);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(208, 66);
            buttonSalvar.TabIndex = 18;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // labelVitorias
            // 
            labelVitorias.AutoSize = true;
            labelVitorias.Location = new Point(812, 119);
            labelVitorias.Name = "labelVitorias";
            labelVitorias.Size = new Size(46, 15);
            labelVitorias.TabIndex = 19;
            labelVitorias.Text = "Vitórias";
            // 
            // labelFlopou
            // 
            labelFlopou.AutoSize = true;
            labelFlopou.Location = new Point(968, 119);
            labelFlopou.Name = "labelFlopou";
            labelFlopou.Size = new Size(44, 15);
            labelFlopou.TabIndex = 20;
            labelFlopou.Text = "Flopou";
            // 
            // labelListaFilmes
            // 
            labelListaFilmes.AutoSize = true;
            labelListaFilmes.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelListaFilmes.ForeColor = Color.Red;
            labelListaFilmes.Location = new Point(12, 9);
            labelListaFilmes.Name = "labelListaFilmes";
            labelListaFilmes.Size = new Size(141, 26);
            labelListaFilmes.TabIndex = 21;
            labelListaFilmes.Text = "Lista de Filmes";
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Location = new Point(467, 9);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(53, 15);
            labelPesquisa.TabIndex = 22;
            labelPesquisa.Text = "Pesquisa";
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Location = new Point(467, 27);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(318, 23);
            textBoxPesquisa.TabIndex = 23;
            textBoxPesquisa.KeyDown += textBoxPesquisa_KeyDown;
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(687, 58);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(98, 55);
            buttonApagar.TabIndex = 24;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(687, 119);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(98, 55);
            buttonEditar.TabIndex = 25;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // labelQuantidadeValor
            // 
            labelQuantidadeValor.AutoSize = true;
            labelQuantidadeValor.Location = new Point(657, 564);
            labelQuantidadeValor.Name = "labelQuantidadeValor";
            labelQuantidadeValor.Size = new Size(13, 15);
            labelQuantidadeValor.TabIndex = 26;
            labelQuantidadeValor.Text = "0";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(582, 564);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(69, 15);
            labelQuantidade.TabIndex = 27;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelCodigoEditar
            // 
            labelCodigoEditar.AutoSize = true;
            labelCodigoEditar.Location = new Point(888, 9);
            labelCodigoEditar.Name = "labelCodigoEditar";
            labelCodigoEditar.Size = new Size(0, 15);
            labelCodigoEditar.TabIndex = 28;
            labelCodigoEditar.Visible = false;
            // 
            // FilmeCadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 600);
            Controls.Add(labelCodigoEditar);
            Controls.Add(labelQuantidade);
            Controls.Add(labelQuantidadeValor);
            Controls.Add(buttonEditar);
            Controls.Add(buttonApagar);
            Controls.Add(textBoxPesquisa);
            Controls.Add(labelPesquisa);
            Controls.Add(labelListaFilmes);
            Controls.Add(labelFlopou);
            Controls.Add(labelVitorias);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonCancelar);
            Controls.Add(labelDataLancamento);
            Controls.Add(dateTimePickerDataLancamento);
            Controls.Add(richTextBoxDescricao);
            Controls.Add(labelDescricao);
            Controls.Add(radioButtonFlopouNao);
            Controls.Add(radioButtonFlopouSim);
            Controls.Add(checkBoxGrammy);
            Controls.Add(checkBoxEmmy);
            Controls.Add(checkBoxOscar);
            Controls.Add(labelCategoria);
            Controls.Add(labelMinutos);
            Controls.Add(comboBoxCategoria);
            Controls.Add(textBoxNome);
            Controls.Add(numericUpDownMinutos);
            Controls.Add(labelNome);
            Controls.Add(dataGridView);
            Name = "FilmeCadastroForm";
            Text = "FilmeCadastroForm";
            Load += FilmeCadastroForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Label labelNome;
        private NumericUpDown numericUpDownMinutos;
        private TextBox textBoxNome;
        private ComboBox comboBoxCategoria;
        private Label labelMinutos;
        private Label labelCategoria;
        private CheckBox checkBoxOscar;
        private CheckBox checkBoxEmmy;
        private CheckBox checkBoxGrammy;
        private RadioButton radioButtonFlopouSim;
        private RadioButton radioButtonFlopouNao;
        private Label labelDescricao;
        private RichTextBox richTextBoxDescricao;
        private DateTimePicker dateTimePickerDataLancamento;
        private Label labelDataLancamento;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label labelVitorias;
        private Label labelFlopou;
        private Label labelListaFilmes;
        private Label labelPesquisa;
        private TextBox textBoxPesquisa;
        private Button buttonApagar;
        private Button buttonEditar;
        private Label labelQuantidadeValor;
        private Label labelQuantidade;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnDuracao;
        private Label labelCodigoEditar;
    }
}