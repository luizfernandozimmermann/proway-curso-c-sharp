namespace WindowsFormsExemplos.Forms
{
    partial class ProdutoCadastroSimplificadoBancoDadosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoCadastroSimplificadoBancoDadosForm));
            dataGridView1 = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnQuantidade = new DataGridViewTextBoxColumn();
            ColumnPrecoUnitario = new DataGridViewTextBoxColumn();
            ColumnPreco = new DataGridViewTextBoxColumn();
            textBoxPrecoUnitario = new TextBox();
            textBoxQuantidade = new TextBox();
            textBoxNome = new TextBox();
            buttonSalvar = new Button();
            labelPrecoUnitario = new Label();
            labelQuantidade = new Label();
            labelNome = new Label();
            labelListaProdutos = new Label();
            buttonEditar = new Button();
            buttonApagar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNome, ColumnQuantidade, ColumnPrecoUnitario, ColumnPreco });
            dataGridView1.Location = new Point(14, 57);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(696, 477);
            dataGridView1.TabIndex = 19;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Código";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Width = 125;
            // 
            // ColumnNome
            // 
            ColumnNome.HeaderText = "Nome";
            ColumnNome.MinimumWidth = 6;
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            ColumnNome.Width = 125;
            // 
            // ColumnQuantidade
            // 
            ColumnQuantidade.HeaderText = "Quantidade";
            ColumnQuantidade.MinimumWidth = 6;
            ColumnQuantidade.Name = "ColumnQuantidade";
            ColumnQuantidade.ReadOnly = true;
            ColumnQuantidade.Width = 125;
            // 
            // ColumnPrecoUnitario
            // 
            ColumnPrecoUnitario.HeaderText = "Preço unitário";
            ColumnPrecoUnitario.MinimumWidth = 6;
            ColumnPrecoUnitario.Name = "ColumnPrecoUnitario";
            ColumnPrecoUnitario.ReadOnly = true;
            ColumnPrecoUnitario.Width = 125;
            // 
            // ColumnPreco
            // 
            ColumnPreco.HeaderText = "Preço";
            ColumnPreco.MinimumWidth = 6;
            ColumnPreco.Name = "ColumnPreco";
            ColumnPreco.ReadOnly = true;
            ColumnPreco.Width = 125;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.Location = new Point(717, 277);
            textBoxPrecoUnitario.Margin = new Padding(3, 4, 3, 4);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.Size = new Size(283, 27);
            textBoxPrecoUnitario.TabIndex = 16;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(717, 184);
            textBoxQuantidade.Margin = new Padding(3, 4, 3, 4);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(283, 27);
            textBoxQuantidade.TabIndex = 14;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(717, 93);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(283, 27);
            textBoxNome.TabIndex = 12;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackgroundImageLayout = ImageLayout.None;
            buttonSalvar.Image = Properties.Resources.disk;
            buttonSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvar.Location = new Point(775, 383);
            buttonSalvar.Margin = new Padding(3, 4, 3, 4);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(173, 68);
            buttonSalvar.TabIndex = 18;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // labelPrecoUnitario
            // 
            labelPrecoUnitario.AutoSize = true;
            labelPrecoUnitario.Location = new Point(717, 253);
            labelPrecoUnitario.Name = "labelPrecoUnitario";
            labelPrecoUnitario.Size = new Size(101, 20);
            labelPrecoUnitario.TabIndex = 17;
            labelPrecoUnitario.Text = "Preço unitário";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(717, 160);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(87, 20);
            labelQuantidade.TabIndex = 15;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(717, 69);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 13;
            labelNome.Text = "Nome";
            // 
            // labelListaProdutos
            // 
            labelListaProdutos.AutoSize = true;
            labelListaProdutos.Location = new Point(14, 15);
            labelListaProdutos.Name = "labelListaProdutos";
            labelListaProdutos.Size = new Size(123, 20);
            labelListaProdutos.TabIndex = 11;
            labelListaProdutos.Text = "Lista de Produtos";
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(531, 15);
            buttonEditar.Margin = new Padding(3, 4, 3, 4);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(86, 31);
            buttonEditar.TabIndex = 21;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(624, 15);
            buttonApagar.Margin = new Padding(3, 4, 3, 4);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(86, 31);
            buttonApagar.TabIndex = 20;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // ProdutoCadastroSimplificadoBancoDadosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1011, 553);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(textBoxQuantidade);
            Controls.Add(textBoxNome);
            Controls.Add(buttonSalvar);
            Controls.Add(labelPrecoUnitario);
            Controls.Add(labelQuantidade);
            Controls.Add(labelNome);
            Controls.Add(labelListaProdutos);
            Controls.Add(buttonEditar);
            Controls.Add(buttonApagar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProdutoCadastroSimplificadoBancoDadosForm";
            Text = "ProdutoCadastroSimplificadoBancoDadosForm";
            Load += ProdutoCadastroSimplificadoBancoDadosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxPrecoUnitario;
        private TextBox textBoxQuantidade;
        private TextBox textBoxNome;
        private Button buttonSalvar;
        private Label labelPrecoUnitario;
        private Label labelQuantidade;
        private Label labelNome;
        private Label labelListaProdutos;
        private Button buttonEditar;
        private Button buttonApagar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnQuantidade;
        private DataGridViewTextBoxColumn ColumnPrecoUnitario;
        private DataGridViewTextBoxColumn ColumnPreco;
    }
}