namespace WindowsFormsExemplos.Forms.Clientes
{
    partial class CadastroClienteForm
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
            maskedTextBoxCpf = new MaskedTextBox();
            labelCpf = new Label();
            textBoxNome = new TextBox();
            labelDataNascimento = new Label();
            labelEstado = new Label();
            labelBairro = new Label();
            labelCidade = new Label();
            labelCep = new Label();
            dateTimePickerDataNascimento = new DateTimePicker();
            labelLogradouro = new Label();
            labelNumero = new Label();
            labelComplemento = new Label();
            comboBoxEstado = new ComboBox();
            textBoxCidade = new TextBox();
            textBoxBairro = new TextBox();
            maskedTextBoxCep = new MaskedTextBox();
            textBoxLogradouro = new TextBox();
            textBoxNumero = new TextBox();
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
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(12, 85);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(151, 27);
            maskedTextBoxCpf.TabIndex = 1;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(12, 62);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(33, 20);
            labelCpf.TabIndex = 2;
            labelCpf.Text = "CPF";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 32);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(407, 27);
            textBoxNome.TabIndex = 3;
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Location = new Point(169, 62);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(145, 20);
            labelDataNascimento.TabIndex = 4;
            labelDataNascimento.Text = "Data de Nascimento";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(12, 115);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(54, 20);
            labelEstado.TabIndex = 5;
            labelEstado.Text = "Estado";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(12, 169);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(49, 20);
            labelBairro.TabIndex = 6;
            labelBairro.Text = "Bairro";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(169, 115);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(56, 20);
            labelCidade.TabIndex = 7;
            labelCidade.Text = "Cidade";
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Location = new Point(261, 169);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(34, 20);
            labelCep.TabIndex = 8;
            labelCep.Text = "CEP";
            // 
            // dateTimePickerDataNascimento
            // 
            dateTimePickerDataNascimento.Format = DateTimePickerFormat.Short;
            dateTimePickerDataNascimento.Location = new Point(169, 85);
            dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            dateTimePickerDataNascimento.Size = new Size(250, 27);
            dateTimePickerDataNascimento.TabIndex = 9;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(12, 222);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(87, 20);
            labelLogradouro.TabIndex = 10;
            labelLogradouro.Text = "Logradouro";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(12, 275);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(63, 20);
            labelNumero.TabIndex = 11;
            labelNumero.Text = "Número";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(12, 328);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(104, 20);
            labelComplemento.TabIndex = 12;
            labelComplemento.Text = "Complemento";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxEstado.Location = new Point(12, 138);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(151, 28);
            comboBoxEstado.TabIndex = 13;
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(169, 138);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(250, 27);
            textBoxCidade.TabIndex = 14;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(12, 192);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(243, 27);
            textBoxBairro.TabIndex = 15;
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(261, 192);
            maskedTextBoxCep.Mask = "00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(158, 27);
            maskedTextBoxCep.TabIndex = 16;
            maskedTextBoxCep.KeyDown += maskedTextBoxCep_KeyDown;
            maskedTextBoxCep.Leave += maskedTextBoxCep_Leave;
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(12, 245);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(407, 27);
            textBoxLogradouro.TabIndex = 17;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(12, 298);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(407, 27);
            textBoxNumero.TabIndex = 18;
            // 
            // richTextBoxComplemento
            // 
            richTextBoxComplemento.Location = new Point(12, 351);
            richTextBoxComplemento.Name = "richTextBoxComplemento";
            richTextBoxComplemento.Size = new Size(407, 76);
            richTextBoxComplemento.TabIndex = 19;
            richTextBoxComplemento.Text = "";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(220, 433);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(199, 108);
            buttonCadastrar.TabIndex = 20;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // CadastroClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 553);
            Controls.Add(buttonCadastrar);
            Controls.Add(richTextBoxComplemento);
            Controls.Add(textBoxNumero);
            Controls.Add(textBoxLogradouro);
            Controls.Add(maskedTextBoxCep);
            Controls.Add(textBoxBairro);
            Controls.Add(textBoxCidade);
            Controls.Add(comboBoxEstado);
            Controls.Add(labelComplemento);
            Controls.Add(labelNumero);
            Controls.Add(labelLogradouro);
            Controls.Add(dateTimePickerDataNascimento);
            Controls.Add(labelCep);
            Controls.Add(labelCidade);
            Controls.Add(labelBairro);
            Controls.Add(labelEstado);
            Controls.Add(labelDataNascimento);
            Controls.Add(textBoxNome);
            Controls.Add(labelCpf);
            Controls.Add(maskedTextBoxCpf);
            Controls.Add(labelNome);
            Name = "CadastroClienteForm";
            Text = "CadastroClienteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private MaskedTextBox maskedTextBoxCpf;
        private Label labelCpf;
        private TextBox textBoxNome;
        private Label labelDataNascimento;
        private Label labelEstado;
        private Label labelBairro;
        private Label labelCidade;
        private Label labelCep;
        private DateTimePicker dateTimePickerDataNascimento;
        private Label labelLogradouro;
        private Label labelNumero;
        private Label labelComplemento;
        private ComboBox comboBoxEstado;
        private TextBox textBoxCidade;
        private TextBox textBoxBairro;
        private MaskedTextBox maskedTextBoxCep;
        private TextBox textBoxLogradouro;
        private TextBox textBoxNumero;
        private RichTextBox richTextBoxComplemento;
        private Button buttonCadastrar;
    }
}