namespace WindowsFormsExemplos.Forms
{
    partial class MenuPrincipal
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
            buttonFolhaPagamento = new Button();
            buttonCadastroSimplificadoProduto = new Button();
            buttonCadastroFilmes = new Button();
            buttonExercicio = new Button();
            buttonFormBancoDados = new Button();
            buttonListaProdutos = new Button();
            SuspendLayout();
            // 
            // buttonFolhaPagamento
            // 
            buttonFolhaPagamento.Location = new Point(14, 16);
            buttonFolhaPagamento.Margin = new Padding(3, 4, 3, 4);
            buttonFolhaPagamento.Name = "buttonFolhaPagamento";
            buttonFolhaPagamento.Size = new Size(198, 224);
            buttonFolhaPagamento.TabIndex = 0;
            buttonFolhaPagamento.Text = "Folha Pagamento";
            buttonFolhaPagamento.UseVisualStyleBackColor = true;
            buttonFolhaPagamento.Click += buttonFolhaPagamento_Click;
            // 
            // buttonCadastroSimplificadoProduto
            // 
            buttonCadastroSimplificadoProduto.Location = new Point(218, 16);
            buttonCadastroSimplificadoProduto.Margin = new Padding(3, 4, 3, 4);
            buttonCadastroSimplificadoProduto.Name = "buttonCadastroSimplificadoProduto";
            buttonCadastroSimplificadoProduto.Size = new Size(191, 224);
            buttonCadastroSimplificadoProduto.TabIndex = 1;
            buttonCadastroSimplificadoProduto.Text = "Cadastro Simplificado Produto";
            buttonCadastroSimplificadoProduto.UseVisualStyleBackColor = true;
            buttonCadastroSimplificadoProduto.Click += buttonCadastroSimplificadoProduto_Click;
            // 
            // buttonCadastroFilmes
            // 
            buttonCadastroFilmes.Location = new Point(416, 16);
            buttonCadastroFilmes.Margin = new Padding(3, 4, 3, 4);
            buttonCadastroFilmes.Name = "buttonCadastroFilmes";
            buttonCadastroFilmes.Size = new Size(209, 224);
            buttonCadastroFilmes.TabIndex = 2;
            buttonCadastroFilmes.Text = "Cadastro de filmes";
            buttonCadastroFilmes.UseVisualStyleBackColor = true;
            buttonCadastroFilmes.Click += buttonCadastroFilmes_Click;
            // 
            // buttonExercicio
            // 
            buttonExercicio.Location = new Point(632, 16);
            buttonExercicio.Margin = new Padding(3, 4, 3, 4);
            buttonExercicio.Name = "buttonExercicio";
            buttonExercicio.Size = new Size(218, 224);
            buttonExercicio.TabIndex = 3;
            buttonExercicio.Text = "Exercicio";
            buttonExercicio.UseVisualStyleBackColor = true;
            buttonExercicio.Click += buttonExercicio_Click;
            // 
            // buttonFormBancoDados
            // 
            buttonFormBancoDados.Location = new Point(14, 248);
            buttonFormBancoDados.Margin = new Padding(3, 4, 3, 4);
            buttonFormBancoDados.Name = "buttonFormBancoDados";
            buttonFormBancoDados.Size = new Size(198, 224);
            buttonFormBancoDados.TabIndex = 4;
            buttonFormBancoDados.Text = "Banco de dados";
            buttonFormBancoDados.UseVisualStyleBackColor = true;
            buttonFormBancoDados.Click += buttonFormBancoDados_Click;
            // 
            // buttonListaProdutos
            // 
            buttonListaProdutos.Location = new Point(218, 248);
            buttonListaProdutos.Margin = new Padding(3, 4, 3, 4);
            buttonListaProdutos.Name = "buttonListaProdutos";
            buttonListaProdutos.Size = new Size(198, 224);
            buttonListaProdutos.TabIndex = 5;
            buttonListaProdutos.Text = "Lista de produtos";
            buttonListaProdutos.UseVisualStyleBackColor = true;
            buttonListaProdutos.Click += buttonListaProdutos_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 600);
            Controls.Add(buttonListaProdutos);
            Controls.Add(buttonFormBancoDados);
            Controls.Add(buttonExercicio);
            Controls.Add(buttonCadastroFilmes);
            Controls.Add(buttonCadastroSimplificadoProduto);
            Controls.Add(buttonFolhaPagamento);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Windows Forms";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonFolhaPagamento;
        private Button buttonCadastroSimplificadoProduto;
        private Button buttonCadastroFilmes;
        private Button buttonExercicio;
        private Button buttonFormBancoDados;
        private Button buttonListaProdutos;
    }
}