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
            labelListaFilmes = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            labelMinutos = new Label();
            numericUpDownMinutos = new NumericUpDown();
            labelCategoria = new Label();
            comboBoxCategoria = new ComboBox();
            labelPesquisa = new Label();
            checkBoxVitoriaOscar = new CheckBox();
            checkBoxVitoriaEmmy = new CheckBox();
            checkBoxVitoriaGrammy = new CheckBox();
            buttonSalvar = new Button();
            radioButtonFlopouSim = new RadioButton();
            radioButtonFlopouNao = new RadioButton();
            labelFlopou = new Label();
            richTextBoxDescricao = new RichTextBox();
            labelDescricao = new Label();
            labelDataLancamento = new Label();
            dateTimePickerDataLancamento = new DateTimePicker();
            textBoxPesquisa = new TextBox();
            labelQuantidadeValor = new Label();
            labelQuantidade = new Label();
            buttonCancelar = new Button();
            buttonApagar = new Button();
            buttonEditar = new Button();
            labelVitorias = new Label();
            labelCodigoEditar = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutos).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnCodigo, ColumnNome, ColumnCategoria, ColumnDuracao });
            dataGridView.Location = new Point(12, 69);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(643, 534);
            dataGridView.TabIndex = 0;
            // 
            // ColumnCodigo
            // 
            ColumnCodigo.HeaderText = "Código";
            ColumnCodigo.MinimumWidth = 6;
            ColumnCodigo.Name = "ColumnCodigo";
            ColumnCodigo.ReadOnly = true;
            ColumnCodigo.Width = 125;
            // 
            // ColumnNome
            // 
            ColumnNome.HeaderText = "Nome";
            ColumnNome.MinimumWidth = 6;
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            ColumnNome.Width = 125;
            // 
            // ColumnCategoria
            // 
            ColumnCategoria.HeaderText = "Categoria";
            ColumnCategoria.MinimumWidth = 6;
            ColumnCategoria.Name = "ColumnCategoria";
            ColumnCategoria.ReadOnly = true;
            ColumnCategoria.Width = 125;
            // 
            // ColumnDuracao
            // 
            ColumnDuracao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnDuracao.HeaderText = "Duração";
            ColumnDuracao.MinimumWidth = 6;
            ColumnDuracao.Name = "ColumnDuracao";
            ColumnDuracao.ReadOnly = true;
            // 
            // labelListaFilmes
            // 
            labelListaFilmes.AutoSize = true;
            labelListaFilmes.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelListaFilmes.ForeColor = Color.Red;
            labelListaFilmes.Location = new Point(12, 9);
            labelListaFilmes.Name = "labelListaFilmes";
            labelListaFilmes.Size = new Size(213, 38);
            labelListaFilmes.TabIndex = 1;
            labelListaFilmes.Text = "Lista de Filmes";
            // 
            // textBoxNome
            // 
            textBoxNome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNome.Location = new Point(804, 39);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(504, 27);
            textBoxNome.TabIndex = 2;
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNome.AutoSize = true;
            labelNome.Location = new Point(804, 9);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome";
            // 
            // labelMinutos
            // 
            labelMinutos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelMinutos.AutoSize = true;
            labelMinutos.Location = new Point(804, 69);
            labelMinutos.Name = "labelMinutos";
            labelMinutos.Size = new Size(62, 20);
            labelMinutos.TabIndex = 4;
            labelMinutos.Text = "Minutos";
            // 
            // numericUpDownMinutos
            // 
            numericUpDownMinutos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDownMinutos.Location = new Point(804, 93);
            numericUpDownMinutos.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownMinutos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMinutos.Name = "numericUpDownMinutos";
            numericUpDownMinutos.Size = new Size(188, 27);
            numericUpDownMinutos.TabIndex = 5;
            numericUpDownMinutos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelCategoria
            // 
            labelCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(1016, 69);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(74, 20);
            labelCategoria.TabIndex = 6;
            labelCategoria.Text = "Categoria";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Items.AddRange(new object[] { "ComboBox" });
            comboBoxCategoria.Location = new Point(1016, 92);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(292, 28);
            comboBoxCategoria.TabIndex = 7;
            // 
            // labelPesquisa
            // 
            labelPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPesquisa.AutoSize = true;
            labelPesquisa.Location = new Point(412, 9);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(65, 20);
            labelPesquisa.TabIndex = 8;
            labelPesquisa.Text = "Pesquisa";
            // 
            // checkBoxVitoriaOscar
            // 
            checkBoxVitoriaOscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxVitoriaOscar.AutoSize = true;
            checkBoxVitoriaOscar.Location = new Point(804, 155);
            checkBoxVitoriaOscar.Name = "checkBoxVitoriaOscar";
            checkBoxVitoriaOscar.Size = new Size(68, 24);
            checkBoxVitoriaOscar.TabIndex = 9;
            checkBoxVitoriaOscar.Text = "Oscar";
            checkBoxVitoriaOscar.UseVisualStyleBackColor = true;
            // 
            // checkBoxVitoriaEmmy
            // 
            checkBoxVitoriaEmmy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxVitoriaEmmy.AutoSize = true;
            checkBoxVitoriaEmmy.Location = new Point(804, 185);
            checkBoxVitoriaEmmy.Name = "checkBoxVitoriaEmmy";
            checkBoxVitoriaEmmy.Size = new Size(72, 24);
            checkBoxVitoriaEmmy.TabIndex = 10;
            checkBoxVitoriaEmmy.Text = "Emmy";
            checkBoxVitoriaEmmy.UseVisualStyleBackColor = true;
            // 
            // checkBoxVitoriaGrammy
            // 
            checkBoxVitoriaGrammy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxVitoriaGrammy.AutoSize = true;
            checkBoxVitoriaGrammy.Location = new Point(804, 215);
            checkBoxVitoriaGrammy.Name = "checkBoxVitoriaGrammy";
            checkBoxVitoriaGrammy.Size = new Size(87, 24);
            checkBoxVitoriaGrammy.TabIndex = 11;
            checkBoxVitoriaGrammy.Text = "Grammy";
            checkBoxVitoriaGrammy.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSalvar.Location = new Point(1214, 592);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 12;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // radioButtonFlopouSim
            // 
            radioButtonFlopouSim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButtonFlopouSim.AutoSize = true;
            radioButtonFlopouSim.Location = new Point(1016, 155);
            radioButtonFlopouSim.Name = "radioButtonFlopouSim";
            radioButtonFlopouSim.Size = new Size(55, 24);
            radioButtonFlopouSim.TabIndex = 13;
            radioButtonFlopouSim.Text = "Sim";
            radioButtonFlopouSim.UseVisualStyleBackColor = true;
            // 
            // radioButtonFlopouNao
            // 
            radioButtonFlopouNao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButtonFlopouNao.AutoSize = true;
            radioButtonFlopouNao.Checked = true;
            radioButtonFlopouNao.Location = new Point(1016, 185);
            radioButtonFlopouNao.Name = "radioButtonFlopouNao";
            radioButtonFlopouNao.Size = new Size(58, 24);
            radioButtonFlopouNao.TabIndex = 14;
            radioButtonFlopouNao.TabStop = true;
            radioButtonFlopouNao.Text = "Não";
            radioButtonFlopouNao.UseVisualStyleBackColor = true;
            // 
            // labelFlopou
            // 
            labelFlopou.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelFlopou.AutoSize = true;
            labelFlopou.Location = new Point(1016, 132);
            labelFlopou.Name = "labelFlopou";
            labelFlopou.Size = new Size(62, 20);
            labelFlopou.TabIndex = 15;
            labelFlopou.Text = "Flopou?";
            // 
            // richTextBoxDescricao
            // 
            richTextBoxDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            richTextBoxDescricao.Location = new Point(804, 352);
            richTextBoxDescricao.Name = "richTextBoxDescricao";
            richTextBoxDescricao.Size = new Size(504, 231);
            richTextBoxDescricao.TabIndex = 16;
            richTextBoxDescricao.Text = "";
            // 
            // labelDescricao
            // 
            labelDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDescricao.AutoSize = true;
            labelDescricao.Location = new Point(804, 320);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(74, 20);
            labelDescricao.TabIndex = 17;
            labelDescricao.Text = "Descrição";
            // 
            // labelDataLancamento
            // 
            labelDataLancamento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDataLancamento.AutoSize = true;
            labelDataLancamento.Location = new Point(804, 249);
            labelDataLancamento.Name = "labelDataLancamento";
            labelDataLancamento.Size = new Size(147, 20);
            labelDataLancamento.TabIndex = 18;
            labelDataLancamento.Text = "Data de Lançamento";
            // 
            // dateTimePickerDataLancamento
            // 
            dateTimePickerDataLancamento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePickerDataLancamento.Format = DateTimePickerFormat.Short;
            dateTimePickerDataLancamento.Location = new Point(804, 272);
            dateTimePickerDataLancamento.Name = "dateTimePickerDataLancamento";
            dateTimePickerDataLancamento.Size = new Size(504, 27);
            dateTimePickerDataLancamento.TabIndex = 19;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPesquisa.Location = new Point(412, 39);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(319, 27);
            textBoxPesquisa.TabIndex = 20;
            textBoxPesquisa.TextChanged += textBoxPesquisa_TextChanged;
            textBoxPesquisa.KeyDown += textBoxPesquisa_KeyDown;
            // 
            // labelQuantidadeValor
            // 
            labelQuantidadeValor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelQuantidadeValor.AutoSize = true;
            labelQuantidadeValor.Location = new Point(638, 612);
            labelQuantidadeValor.Name = "labelQuantidadeValor";
            labelQuantidadeValor.Size = new Size(17, 20);
            labelQuantidadeValor.TabIndex = 21;
            labelQuantidadeValor.Text = "0";
            // 
            // labelQuantidade
            // 
            labelQuantidade.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(541, 612);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(87, 20);
            labelQuantidade.TabIndex = 22;
            labelQuantidade.Text = "Quantidade";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelar.Location = new Point(1114, 592);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 23;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonApagar
            // 
            buttonApagar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonApagar.Location = new Point(661, 70);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(70, 70);
            buttonApagar.TabIndex = 24;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditar.Location = new Point(661, 146);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(70, 70);
            buttonEditar.TabIndex = 25;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // labelVitorias
            // 
            labelVitorias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelVitorias.AutoSize = true;
            labelVitorias.Location = new Point(804, 132);
            labelVitorias.Name = "labelVitorias";
            labelVitorias.Size = new Size(59, 20);
            labelVitorias.TabIndex = 26;
            labelVitorias.Text = "Vitórias";
            // 
            // labelCodigoEditar
            // 
            labelCodigoEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCodigoEditar.AutoSize = true;
            labelCodigoEditar.Location = new Point(882, 9);
            labelCodigoEditar.Name = "labelCodigoEditar";
            labelCodigoEditar.Size = new Size(0, 20);
            labelCodigoEditar.TabIndex = 27;
            labelCodigoEditar.Visible = false;
            // 
            // FilmeCadastroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 677);
            Controls.Add(labelCodigoEditar);
            Controls.Add(labelVitorias);
            Controls.Add(buttonEditar);
            Controls.Add(buttonApagar);
            Controls.Add(buttonCancelar);
            Controls.Add(labelQuantidade);
            Controls.Add(labelQuantidadeValor);
            Controls.Add(textBoxPesquisa);
            Controls.Add(dateTimePickerDataLancamento);
            Controls.Add(labelDataLancamento);
            Controls.Add(labelDescricao);
            Controls.Add(richTextBoxDescricao);
            Controls.Add(labelFlopou);
            Controls.Add(radioButtonFlopouNao);
            Controls.Add(radioButtonFlopouSim);
            Controls.Add(buttonSalvar);
            Controls.Add(checkBoxVitoriaGrammy);
            Controls.Add(checkBoxVitoriaEmmy);
            Controls.Add(checkBoxVitoriaOscar);
            Controls.Add(labelPesquisa);
            Controls.Add(comboBoxCategoria);
            Controls.Add(labelCategoria);
            Controls.Add(numericUpDownMinutos);
            Controls.Add(labelMinutos);
            Controls.Add(labelNome);
            Controls.Add(textBoxNome);
            Controls.Add(labelListaFilmes);
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
        private Label labelListaFilmes;
        private TextBox textBoxNome;
        private Label labelNome;
        private Label labelMinutos;
        private NumericUpDown numericUpDownMinutos;
        private Label labelCategoria;
        private ComboBox comboBoxCategoria;
        private Label labelPesquisa;
        private CheckBox checkBoxVitoriaOscar;
        private CheckBox checkBoxVitoriaEmmy;
        private CheckBox checkBoxVitoriaGrammy;
        private Button buttonSalvar;
        private RadioButton radioButtonFlopouSim;
        private RadioButton radioButtonFlopouNao;
        private Label labelFlopou;
        private RichTextBox richTextBoxDescricao;
        private Label labelDescricao;
        private Label labelDataLancamento;
        private DateTimePicker dateTimePickerDataLancamento;
        private TextBox textBoxPesquisa;
        private Label labelQuantidadeValor;
        private Label labelQuantidade;
        private Button buttonCancelar;
        private Button buttonApagar;
        private Button buttonEditar;
        private Label labelVitorias;
        private Label labelCodigoEditar;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnDuracao;
    }
}