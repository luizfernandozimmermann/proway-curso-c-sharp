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
            dataGridView1.Location = new Point(12, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(609, 358);
            dataGridView1.TabIndex = 19;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Código";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
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
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.Location = new Point(627, 208);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.Size = new Size(248, 23);
            textBoxPrecoUnitario.TabIndex = 16;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(627, 138);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(248, 23);
            textBoxQuantidade.TabIndex = 14;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(627, 70);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(248, 23);
            textBoxNome.TabIndex = 12;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackgroundImageLayout = ImageLayout.None;
            buttonSalvar.Image = Properties.Resources.disk;
            buttonSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvar.Location = new Point(678, 287);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(151, 51);
            buttonSalvar.TabIndex = 18;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // labelPrecoUnitario
            // 
            labelPrecoUnitario.AutoSize = true;
            labelPrecoUnitario.Location = new Point(627, 190);
            labelPrecoUnitario.Name = "labelPrecoUnitario";
            labelPrecoUnitario.Size = new Size(81, 15);
            labelPrecoUnitario.TabIndex = 17;
            labelPrecoUnitario.Text = "Preço unitário";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(627, 120);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(69, 15);
            labelQuantidade.TabIndex = 15;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(627, 52);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 13;
            labelNome.Text = "Nome";
            // 
            // labelListaProdutos
            // 
            labelListaProdutos.AutoSize = true;
            labelListaProdutos.Location = new Point(12, 11);
            labelListaProdutos.Name = "labelListaProdutos";
            labelListaProdutos.Size = new Size(98, 15);
            labelListaProdutos.TabIndex = 11;
            labelListaProdutos.Text = "Lista de Produtos";
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(465, 11);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 21;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(546, 11);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(75, 23);
            buttonApagar.TabIndex = 20;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // ProdutoCadastroSimplificadoBancoDadosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(885, 415);
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