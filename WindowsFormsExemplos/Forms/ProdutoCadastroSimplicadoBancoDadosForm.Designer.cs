namespace WindowsFormsExemplos.Forms
{
    partial class ProdutoCadastroSimplicadoBancoDadosForm
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
            dataGridView1 = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnQuantidade = new DataGridViewTextBoxColumn();
            ColumnPrecoUnitario = new DataGridViewTextBoxColumn();
            ColumnPreço = new DataGridViewTextBoxColumn();
            textBoxNome = new TextBox();
            textBoxQuantidade = new TextBox();
            textBoxPrecoUnitario = new TextBox();
            buttonSalvar = new Button();
            labelListaProdutos = new Label();
            labelPrecoUnitario = new Label();
            labelQuantidade = new Label();
            labelNome = new Label();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNome, ColumnQuantidade, ColumnPrecoUnitario, ColumnPreço });
            dataGridView1.Location = new Point(12, 111);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(758, 527);
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
            ColumnPrecoUnitario.HeaderText = "Preço Unitário";
            ColumnPrecoUnitario.MinimumWidth = 6;
            ColumnPrecoUnitario.Name = "ColumnPrecoUnitario";
            ColumnPrecoUnitario.ReadOnly = true;
            ColumnPrecoUnitario.Width = 125;
            // 
            // ColumnPreço
            // 
            ColumnPreço.HeaderText = "Preço";
            ColumnPreço.MinimumWidth = 6;
            ColumnPreço.Name = "ColumnPreço";
            ColumnPreço.ReadOnly = true;
            ColumnPreço.Width = 125;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(800, 69);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(389, 27);
            textBoxNome.TabIndex = 12;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(800, 128);
            textBoxQuantidade.Margin = new Padding(3, 4, 3, 4);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(389, 27);
            textBoxQuantidade.TabIndex = 14;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.Location = new Point(800, 186);
            textBoxPrecoUnitario.Margin = new Padding(3, 4, 3, 4);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.Size = new Size(389, 27);
            textBoxPrecoUnitario.TabIndex = 16;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackgroundImageLayout = ImageLayout.None;
            buttonSalvar.Image = Properties.Resources.disk;
            buttonSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvar.Location = new Point(1041, 225);
            buttonSalvar.Margin = new Padding(3, 4, 3, 4);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(149, 70);
            buttonSalvar.TabIndex = 18;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // labelListaProdutos
            // 
            labelListaProdutos.AutoSize = true;
            labelListaProdutos.Location = new Point(61, 52);
            labelListaProdutos.Name = "labelListaProdutos";
            labelListaProdutos.Size = new Size(102, 20);
            labelListaProdutos.TabIndex = 17;
            labelListaProdutos.Text = "Lista Produtos";
            // 
            // labelPrecoUnitario
            // 
            labelPrecoUnitario.AutoSize = true;
            labelPrecoUnitario.Location = new Point(800, 162);
            labelPrecoUnitario.Name = "labelPrecoUnitario";
            labelPrecoUnitario.Size = new Size(103, 20);
            labelPrecoUnitario.TabIndex = 15;
            labelPrecoUnitario.Text = "Preço Unitário";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(800, 104);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(87, 20);
            labelQuantidade.TabIndex = 13;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(800, 45);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 11;
            labelNome.Text = "Nome";
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(373, 65);
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
            buttonApagar.Location = new Point(465, 65);
            buttonApagar.Margin = new Padding(3, 4, 3, 4);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(86, 31);
            buttonApagar.TabIndex = 20;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // ProdutoCadastroSimplicadoBancoDadosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.plano_de_fundo;
            ClientSize = new Size(1233, 690);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxQuantidade);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(buttonSalvar);
            Controls.Add(labelListaProdutos);
            Controls.Add(labelPrecoUnitario);
            Controls.Add(labelQuantidade);
            Controls.Add(labelNome);
            Controls.Add(buttonEditar);
            Controls.Add(buttonApagar);
            Name = "ProdutoCadastroSimplicadoBancoDadosForm";
            Text = "ProdutoCadastroSimplicadoBancoDadosForm";
            Load += ProdutoCadastroSimplicadoBancoDadosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxNome;
        private TextBox textBoxQuantidade;
        private TextBox textBoxPrecoUnitario;
        private Button buttonSalvar;
        private Label labelListaProdutos;
        private Label labelPrecoUnitario;
        private Label labelQuantidade;
        private Label labelNome;
        private Button buttonEditar;
        private Button buttonApagar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnQuantidade;
        private DataGridViewTextBoxColumn ColumnPrecoUnitario;
        private DataGridViewTextBoxColumn ColumnPreço;
    }
}