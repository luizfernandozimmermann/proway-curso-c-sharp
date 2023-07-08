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
            buttonListaClientes = new Button();
            buttonListarPedidos = new Button();
            SuspendLayout();
            // 
            // buttonFolhaPagamento
            // 
            buttonFolhaPagamento.Location = new Point(12, 12);
            buttonFolhaPagamento.Name = "buttonFolhaPagamento";
            buttonFolhaPagamento.Size = new Size(145, 135);
            buttonFolhaPagamento.TabIndex = 0;
            buttonFolhaPagamento.Text = "Folha Pagamento";
            buttonFolhaPagamento.UseVisualStyleBackColor = true;
            buttonFolhaPagamento.Click += buttonFolhaPagamento_Click;
            // 
            // buttonCadastroSimplificadoProduto
            // 
            buttonCadastroSimplificadoProduto.Location = new Point(163, 12);
            buttonCadastroSimplificadoProduto.Name = "buttonCadastroSimplificadoProduto";
            buttonCadastroSimplificadoProduto.Size = new Size(143, 135);
            buttonCadastroSimplificadoProduto.TabIndex = 1;
            buttonCadastroSimplificadoProduto.Text = "Cadastro Simplificado Produto";
            buttonCadastroSimplificadoProduto.UseVisualStyleBackColor = true;
            buttonCadastroSimplificadoProduto.Click += buttonCadastroSimplificadoProduto_Click;
            // 
            // buttonCadastroFilmes
            // 
            buttonCadastroFilmes.Location = new Point(311, 12);
            buttonCadastroFilmes.Margin = new Padding(3, 2, 3, 2);
            buttonCadastroFilmes.Name = "buttonCadastroFilmes";
            buttonCadastroFilmes.Size = new Size(150, 135);
            buttonCadastroFilmes.TabIndex = 2;
            buttonCadastroFilmes.Text = "Cadastro Filmes";
            buttonCadastroFilmes.UseVisualStyleBackColor = true;
            buttonCadastroFilmes.Click += buttonCadastroFilmes_Click;
            // 
            // buttonCadastroSimplificadoProdutoBancoDados
            // 
            buttonCadastroSimplificadoProdutoBancoDados.Location = new Point(474, 12);
            buttonCadastroSimplificadoProdutoBancoDados.Margin = new Padding(3, 2, 3, 2);
            buttonCadastroSimplificadoProdutoBancoDados.Name = "buttonCadastroSimplificadoProdutoBancoDados";
            buttonCadastroSimplificadoProdutoBancoDados.Size = new Size(150, 135);
            buttonCadastroSimplificadoProdutoBancoDados.TabIndex = 3;
            buttonCadastroSimplificadoProdutoBancoDados.Text = "Cadastro Simplificado Produto Bando Dados";
            buttonCadastroSimplificadoProdutoBancoDados.UseVisualStyleBackColor = true;
            buttonCadastroSimplificadoProdutoBancoDados.Click += buttonCadastroSimplificadoProdutoBancoDados_Click;
            // 
            // buttonListaProdutos
            // 
            buttonListaProdutos.Location = new Point(8, 298);
            buttonListaProdutos.Margin = new Padding(3, 2, 3, 2);
            buttonListaProdutos.Name = "buttonListaProdutos";
            buttonListaProdutos.Size = new Size(150, 135);
            buttonListaProdutos.TabIndex = 4;
            buttonListaProdutos.Text = "Lista de Produtos";
            buttonListaProdutos.UseVisualStyleBackColor = true;
            buttonListaProdutos.Click += buttonListaProdutos_Click;
            // 
            // buttonListaClientes
            // 
            buttonListaClientes.Location = new Point(163, 298);
            buttonListaClientes.Margin = new Padding(3, 2, 3, 2);
            buttonListaClientes.Name = "buttonListaClientes";
            buttonListaClientes.Size = new Size(162, 135);
            buttonListaClientes.TabIndex = 5;
            buttonListaClientes.Text = "Lista Clientes";
            buttonListaClientes.UseVisualStyleBackColor = true;
            buttonListaClientes.Click += buttonListaClientes_Click;
            // 
            // buttonListarPedidos
            // 
            buttonListarPedidos.Location = new Point(331, 298);
            buttonListarPedidos.Margin = new Padding(3, 2, 3, 2);
            buttonListarPedidos.Name = "buttonListarPedidos";
            buttonListarPedidos.Size = new Size(162, 135);
            buttonListarPedidos.TabIndex = 6;
            buttonListarPedidos.Text = "Lista Pedidos";
            buttonListarPedidos.UseVisualStyleBackColor = true;
            buttonListarPedidos.Click += buttonListarProdutos_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonListarPedidos);
            Controls.Add(buttonListaClientes);
            Controls.Add(buttonListaProdutos);
            Controls.Add(buttonCadastroSimplificadoProdutoBancoDados);
            Controls.Add(buttonCadastroFilmes);
            Controls.Add(buttonCadastroSimplificadoProduto);
            Controls.Add(buttonFolhaPagamento);
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
        private Button buttonListaClientes;
        private Button buttonListarPedidos;
    }
}