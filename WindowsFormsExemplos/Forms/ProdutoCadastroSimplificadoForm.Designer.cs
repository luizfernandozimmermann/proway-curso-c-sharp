namespace WindowsFormsExemplos.Forms
{
    partial class ProdutoCadastroSimplificadoForm
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
            labelListaProdutos = new Label();
            labelNome = new Label();
            labelQuantidade = new Label();
            labelPrecoUnitario = new Label();
            buttonSalvar = new Button();
            textBoxNome = new TextBox();
            textBoxQuantidade = new TextBox();
            textBoxPrecoUnitario = new TextBox();
            dataGridView1 = new DataGridView();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnQuantidade = new DataGridViewTextBoxColumn();
            ColumnPrecoUnitario = new DataGridViewTextBoxColumn();
            ColumnPreco = new DataGridViewTextBoxColumn();
            buttonApagar = new Button();
            buttonEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelListaProdutos
            // 
            labelListaProdutos.AutoSize = true;
            labelListaProdutos.Location = new Point(12, 9);
            labelListaProdutos.Name = "labelListaProdutos";
            labelListaProdutos.Size = new Size(98, 15);
            labelListaProdutos.TabIndex = 0;
            labelListaProdutos.Text = "Lista de Produtos";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(490, 58);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(490, 126);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(69, 15);
            labelQuantidade.TabIndex = 2;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelPrecoUnitario
            // 
            labelPrecoUnitario.AutoSize = true;
            labelPrecoUnitario.Location = new Point(490, 196);
            labelPrecoUnitario.Name = "labelPrecoUnitario";
            labelPrecoUnitario.Size = new Size(81, 15);
            labelPrecoUnitario.TabIndex = 3;
            labelPrecoUnitario.Text = "Preço unitário";
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(490, 271);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(248, 51);
            buttonSalvar.TabIndex = 4;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(490, 76);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(248, 23);
            textBoxNome.TabIndex = 1;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(490, 144);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(248, 23);
            textBoxQuantidade.TabIndex = 2;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.Location = new Point(490, 214);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.Size = new Size(248, 23);
            textBoxPrecoUnitario.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnNome, ColumnQuantidade, ColumnPrecoUnitario, ColumnPreco });
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(472, 358);
            dataGridView1.TabIndex = 8;
            // 
            // ColumnNome
            // 
            ColumnNome.HeaderText = "Nome";
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            // 
            // ColumnQuantidade
            // 
            ColumnQuantidade.HeaderText = "Quantidade";
            ColumnQuantidade.Name = "ColumnQuantidade";
            ColumnQuantidade.ReadOnly = true;
            // 
            // ColumnPrecoUnitario
            // 
            ColumnPrecoUnitario.HeaderText = "Preço unitário";
            ColumnPrecoUnitario.Name = "ColumnPrecoUnitario";
            ColumnPrecoUnitario.ReadOnly = true;
            // 
            // ColumnPreco
            // 
            ColumnPreco.HeaderText = "Preço";
            ColumnPreco.Name = "ColumnPreco";
            ColumnPreco.ReadOnly = true;
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(409, 12);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(75, 23);
            buttonApagar.TabIndex = 9;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(328, 12);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 10;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // ProdutoCadastroSimplificadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 411);
            Controls.Add(buttonEditar);
            Controls.Add(buttonApagar);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(textBoxQuantidade);
            Controls.Add(textBoxNome);
            Controls.Add(buttonSalvar);
            Controls.Add(labelPrecoUnitario);
            Controls.Add(labelQuantidade);
            Controls.Add(labelNome);
            Controls.Add(labelListaProdutos);
            Name = "ProdutoCadastroSimplificadoForm";
            Text = "ProdutoCadastroSimplificadoForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelListaProdutos;
        private Label labelNome;
        private Label labelQuantidade;
        private Label labelPrecoUnitario;
        private Button buttonSalvar;
        private TextBox textBoxNome;
        private TextBox textBoxQuantidade;
        private TextBox textBoxPrecoUnitario;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnQuantidade;
        private DataGridViewTextBoxColumn ColumnPrecoUnitario;
        private DataGridViewTextBoxColumn ColumnPreco;
        private Button buttonApagar;
        private Button buttonEditar;
    }
}