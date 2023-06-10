namespace WindowsFormsExemplos.Forms.Produtos
{
    partial class CadastroProdutoForm
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
            textBoxPrecoUnitario = new TextBox();
            textBoxQuantidade = new TextBox();
            textBoxNome = new TextBox();
            buttonSalvar = new Button();
            labelPrecoUnitario = new Label();
            labelQuantidade = new Label();
            labelNome = new Label();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.Location = new Point(12, 221);
            textBoxPrecoUnitario.Margin = new Padding(3, 4, 3, 4);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.Size = new Size(283, 27);
            textBoxPrecoUnitario.TabIndex = 23;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(12, 128);
            textBoxQuantidade.Margin = new Padding(3, 4, 3, 4);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(283, 27);
            textBoxQuantidade.TabIndex = 21;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 37);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(283, 27);
            textBoxNome.TabIndex = 19;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackgroundImageLayout = ImageLayout.None;
            buttonSalvar.Image = Properties.Resources.disk;
            buttonSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvar.Location = new Point(160, 266);
            buttonSalvar.Margin = new Padding(3, 4, 3, 4);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(135, 68);
            buttonSalvar.TabIndex = 25;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // labelPrecoUnitario
            // 
            labelPrecoUnitario.AutoSize = true;
            labelPrecoUnitario.Location = new Point(12, 197);
            labelPrecoUnitario.Name = "labelPrecoUnitario";
            labelPrecoUnitario.Size = new Size(101, 20);
            labelPrecoUnitario.TabIndex = 24;
            labelPrecoUnitario.Text = "Preço unitário";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(12, 104);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(87, 20);
            labelQuantidade.TabIndex = 22;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 13);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 20;
            labelNome.Text = "Nome";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(12, 266);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(142, 68);
            buttonCancelar.TabIndex = 26;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroProdutoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 347);
            Controls.Add(buttonCancelar);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(textBoxQuantidade);
            Controls.Add(textBoxNome);
            Controls.Add(buttonSalvar);
            Controls.Add(labelPrecoUnitario);
            Controls.Add(labelQuantidade);
            Controls.Add(labelNome);
            Name = "CadastroProdutoForm";
            Text = "CadastroProdutoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPrecoUnitario;
        private TextBox textBoxQuantidade;
        private TextBox textBoxNome;
        private Button buttonSalvar;
        private Label labelPrecoUnitario;
        private Label labelQuantidade;
        private Label labelNome;
        private Button buttonCancelar;
    }
}