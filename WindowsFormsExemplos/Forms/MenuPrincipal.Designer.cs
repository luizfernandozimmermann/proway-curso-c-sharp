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
            buttonCadastroSimplificadoProdutoBancoDados = new Button();
            buttonListaProdutos = new Button();
            SuspendLayout();
            // 
            // buttonFolhaPagamento
            // 
            buttonFolhaPagamento.Location = new Point(14, 16);
            buttonFolhaPagamento.Margin = new Padding(3, 4, 3, 4);
            buttonFolhaPagamento.Name = "buttonFolhaPagamento";
            buttonFolhaPagamento.Size = new Size(166, 180);
            buttonFolhaPagamento.TabIndex = 0;
            buttonFolhaPagamento.Text = "Folha Pagamento";
            buttonFolhaPagamento.UseVisualStyleBackColor = true;
            buttonFolhaPagamento.Click += buttonFolhaPagamento_Click;
            // 
            // buttonCadastroSimplificadoProduto
            // 
            buttonCadastroSimplificadoProduto.Location = new Point(186, 16);
            buttonCadastroSimplificadoProduto.Margin = new Padding(3, 4, 3, 4);
            buttonCadastroSimplificadoProduto.Name = "buttonCadastroSimplificadoProduto";
            buttonCadastroSimplificadoProduto.Size = new Size(163, 180);
            buttonCadastroSimplificadoProduto.TabIndex = 1;
            buttonCadastroSimplificadoProduto.Text = "Cadastro Simplificado Produto";
            buttonCadastroSimplificadoProduto.UseVisualStyleBackColor = true;
            buttonCadastroSimplificadoProduto.Click += buttonCadastroSimplificadoProduto_Click;
            // 
            // buttonCadastroFilmes
            // 
            buttonCadastroFilmes.Location = new Point(355, 16);
            buttonCadastroFilmes.Name = "buttonCadastroFilmes";
            buttonCadastroFilmes.Size = new Size(171, 180);
            buttonCadastroFilmes.TabIndex = 2;
            buttonCadastroFilmes.Text = "Cadastro Filmes";
            buttonCadastroFilmes.UseVisualStyleBackColor = true;
            buttonCadastroFilmes.Click += buttonCadastroFilmes_Click;
            // 
            // buttonCadastroSimplificadoProdutoBancoDados
            // 
            buttonCadastroSimplificadoProdutoBancoDados.Location = new Point(542, 16);
            buttonCadastroSimplificadoProdutoBancoDados.Name = "buttonCadastroSimplificadoProdutoBancoDados";
            buttonCadastroSimplificadoProdutoBancoDados.Size = new Size(171, 180);
            buttonCadastroSimplificadoProdutoBancoDados.TabIndex = 3;
            buttonCadastroSimplificadoProdutoBancoDados.Text = "Cadastro Simplificado Produto Bando Dados";
            buttonCadastroSimplificadoProdutoBancoDados.UseVisualStyleBackColor = true;
            buttonCadastroSimplificadoProdutoBancoDados.Click += buttonCadastroSimplificadoProdutoBancoDados_Click;
            // 
            // buttonListaProdutos
            // 
            buttonListaProdutos.Location = new Point(9, 398);
            buttonListaProdutos.Name = "buttonListaProdutos";
            buttonListaProdutos.Size = new Size(171, 180);
            buttonListaProdutos.TabIndex = 4;
            buttonListaProdutos.Text = "Lista de Produtos";
            buttonListaProdutos.UseVisualStyleBackColor = true;
            buttonListaProdutos.Click += buttonListaProdutos_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonListaProdutos);
            Controls.Add(buttonCadastroSimplificadoProdutoBancoDados);
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
        private Button buttonCadastroSimplificadoProdutoBancoDados;
        private Button buttonListaProdutos;
    }
}