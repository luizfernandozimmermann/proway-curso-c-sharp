namespace WindowsFormsExemplos.Forms.Clientes
{
    partial class CadastroClienteFrom
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
            labelNome = new Label();
            textBoxNome = new TextBox();
            labelCpf = new Label();
            maskedTextBoxCpf = new MaskedTextBox();
            labelDataNascimento = new Label();
            dateTimePickerDataNascimento = new DateTimePicker();
            labelEstado = new Label();
            comboBoxEstado = new ComboBox();
            labelCidade = new Label();
            labelCep = new Label();
            labelBairro = new Label();
            textBoxCidade = new TextBox();
            maskedTextBoxCep = new MaskedTextBox();
            textBoxBairro = new TextBox();
            labelLogradouro = new Label();
            textBoxLogradouro = new TextBox();
            labelNúmero = new Label();
            textBoxNumero = new TextBox();
            labelComplemento = new Label();
            richTextBoxComplemento = new RichTextBox();
            buttonCadastrar = new Button();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 9);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 32);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(406, 27);
            textBoxNome.TabIndex = 1;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(12, 77);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(33, 20);
            labelCpf.TabIndex = 2;
            labelCpf.Text = "CPF";
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(12, 100);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(171, 27);
            maskedTextBoxCpf.TabIndex = 3;
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Location = new Point(210, 77);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(145, 20);
            labelDataNascimento.TabIndex = 4;
            labelDataNascimento.Text = "Data de Nascimento";
            // 
            // dateTimePickerDataNascimento
            // 
            dateTimePickerDataNascimento.Format = DateTimePickerFormat.Short;
            dateTimePickerDataNascimento.Location = new Point(210, 100);
            dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            dateTimePickerDataNascimento.Size = new Size(208, 27);
            dateTimePickerDataNascimento.TabIndex = 5;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(12, 147);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(54, 20);
            labelEstado.TabIndex = 6;
            labelEstado.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxEstado.Location = new Point(12, 170);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(171, 28);
            comboBoxEstado.TabIndex = 7;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(210, 147);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(56, 20);
            labelCidade.TabIndex = 8;
            labelCidade.Text = "Cidade";
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Location = new Point(210, 206);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(34, 20);
            labelCep.TabIndex = 9;
            labelCep.Text = "CEP";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(12, 206);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(49, 20);
            labelBairro.TabIndex = 10;
            labelBairro.Text = "Bairro";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(210, 171);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(208, 27);
            textBoxCidade.TabIndex = 11;
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(210, 229);
            maskedTextBoxCep.Mask = "00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(208, 27);
            maskedTextBoxCep.TabIndex = 12;
            maskedTextBoxCep.KeyDown += maskedTextBoxCep_KeyDown;
            maskedTextBoxCep.Leave += maskedTextBoxCep_Leave;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(12, 229);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(171, 27);
            textBoxBairro.TabIndex = 13;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(12, 259);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(87, 20);
            labelLogradouro.TabIndex = 14;
            labelLogradouro.Text = "Logradouro";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(12, 282);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(406, 27);
            textBoxLogradouro.TabIndex = 15;
            // 
            // labelNúmero
            // 
            labelNúmero.AutoSize = true;
            labelNúmero.Location = new Point(12, 321);
            labelNúmero.Name = "labelNúmero";
            labelNúmero.Size = new Size(63, 20);
            labelNúmero.TabIndex = 16;
            labelNúmero.Text = "Número";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(12, 344);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(406, 27);
            textBoxNumero.TabIndex = 17;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(12, 387);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(104, 20);
            labelComplemento.TabIndex = 18;
            labelComplemento.Text = "Complemento";
            // 
            // richTextBoxComplemento
            // 
            richTextBoxComplemento.Location = new Point(12, 410);
            richTextBoxComplemento.Name = "richTextBoxComplemento";
            richTextBoxComplemento.Size = new Size(406, 213);
            richTextBoxComplemento.TabIndex = 19;
            richTextBoxComplemento.Text = "";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(320, 639);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(94, 29);
            buttonCadastrar.TabIndex = 20;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // CadastroClienteFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 694);
            Controls.Add(buttonCadastrar);
            Controls.Add(richTextBoxComplemento);
            Controls.Add(labelComplemento);
            Controls.Add(textBoxNumero);
            Controls.Add(labelNúmero);
            Controls.Add(textBoxLogradouro);
            Controls.Add(labelLogradouro);
            Controls.Add(textBoxBairro);
            Controls.Add(maskedTextBoxCep);
            Controls.Add(textBoxCidade);
            Controls.Add(labelBairro);
            Controls.Add(labelCep);
            Controls.Add(labelCidade);
            Controls.Add(comboBoxEstado);
            Controls.Add(labelEstado);
            Controls.Add(dateTimePickerDataNascimento);
            Controls.Add(labelDataNascimento);
            Controls.Add(maskedTextBoxCpf);
            Controls.Add(labelCpf);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Name = "CadastroClienteFrom";
            Text = "CadastroClienteFrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelCpf;
        private MaskedTextBox maskedTextBoxCpf;
        private Label labelDataNascimento;
        private DateTimePicker dateTimePickerDataNascimento;
        private Label labelEstado;
        private ComboBox comboBoxEstado;
        private Label labelCidade;
        private Label labelCep;
        private Label labelBairro;
        private TextBox textBoxCidade;
        private MaskedTextBox maskedTextBoxCep;
        private TextBox textBoxBairro;
        private Label labelLogradouro;
        private TextBox textBoxLogradouro;
        private Label labelNúmero;
        private TextBox textBoxNumero;
        private Label labelComplemento;
        private RichTextBox richTextBoxComplemento;
        private Button buttonCadastrar;
    }
}