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
            this.buttonFolhaPagamento = new System.Windows.Forms.Button();
            this.buttonCadastroSimplificadoProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFolhaPagamento
            // 
            this.buttonFolhaPagamento.Location = new System.Drawing.Point(12, 12);
            this.buttonFolhaPagamento.Name = "buttonFolhaPagamento";
            this.buttonFolhaPagamento.Size = new System.Drawing.Size(173, 168);
            this.buttonFolhaPagamento.TabIndex = 0;
            this.buttonFolhaPagamento.Text = "Folha Pagamento";
            this.buttonFolhaPagamento.UseVisualStyleBackColor = true;
            this.buttonFolhaPagamento.Click += new System.EventHandler(this.buttonFolhaPagamento_Click);
            // 
            // buttonCadastroSimplificadoProduto
            // 
            this.buttonCadastroSimplificadoProduto.Location = new System.Drawing.Point(191, 12);
            this.buttonCadastroSimplificadoProduto.Name = "buttonCadastroSimplificadoProduto";
            this.buttonCadastroSimplificadoProduto.Size = new System.Drawing.Size(167, 168);
            this.buttonCadastroSimplificadoProduto.TabIndex = 1;
            this.buttonCadastroSimplificadoProduto.Text = "Cadastro Simplificado Produto";
            this.buttonCadastroSimplificadoProduto.UseVisualStyleBackColor = true;
            this.buttonCadastroSimplificadoProduto.Click += new System.EventHandler(this.buttonCadastroSimplificadoProduto_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCadastroSimplificadoProduto);
            this.Controls.Add(this.buttonFolhaPagamento);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Windows Forms";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonFolhaPagamento;
        private Button buttonCadastroSimplificadoProduto;
    }
}