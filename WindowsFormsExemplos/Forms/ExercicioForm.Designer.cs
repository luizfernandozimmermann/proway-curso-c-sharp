namespace WindowsFormsExemplos.Forms
{
    partial class ExercicioForm
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
            textBoxUsuário = new TextBox();
            labelUsuario = new Label();
            textBoxSenha = new TextBox();
            labelSenha = new Label();
            textBoxCorFav = new TextBox();
            labelCorFav = new Label();
            linkLabelRegistrar = new LinkLabel();
            buttonEntrar = new Button();
            SuspendLayout();
            // 
            // textBoxUsuário
            // 
            textBoxUsuário.Location = new Point(12, 32);
            textBoxUsuário.Name = "textBoxUsuário";
            textBoxUsuário.Size = new Size(279, 23);
            textBoxUsuário.TabIndex = 3;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(12, 14);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(47, 15);
            labelUsuario.TabIndex = 2;
            labelUsuario.Text = "Usuário";
            // 
            // textBoxSenha
            // 
            textBoxSenha.HideSelection = false;
            textBoxSenha.Location = new Point(12, 88);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(279, 23);
            textBoxSenha.TabIndex = 5;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(12, 70);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(39, 15);
            labelSenha.TabIndex = 4;
            labelSenha.Text = "Senha";
            // 
            // textBoxCorFav
            // 
            textBoxCorFav.Location = new Point(12, 144);
            textBoxCorFav.Name = "textBoxCorFav";
            textBoxCorFav.Size = new Size(279, 23);
            textBoxCorFav.TabIndex = 7;
            // 
            // labelCorFav
            // 
            labelCorFav.AutoSize = true;
            labelCorFav.Location = new Point(12, 126);
            labelCorFav.Name = "labelCorFav";
            labelCorFav.Size = new Size(69, 15);
            labelCorFav.TabIndex = 6;
            labelCorFav.Text = "Cor favorita";
            // 
            // linkLabelRegistrar
            // 
            linkLabelRegistrar.AutoSize = true;
            linkLabelRegistrar.Location = new Point(124, 179);
            linkLabelRegistrar.Name = "linkLabelRegistrar";
            linkLabelRegistrar.Size = new Size(53, 15);
            linkLabelRegistrar.TabIndex = 8;
            linkLabelRegistrar.TabStop = true;
            linkLabelRegistrar.Text = "Registrar";
            linkLabelRegistrar.LinkClicked += linkLabelRegistrar_LinkClicked;
            // 
            // buttonEntrar
            // 
            buttonEntrar.Location = new Point(12, 208);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(279, 39);
            buttonEntrar.TabIndex = 9;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // ExercicioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 259);
            Controls.Add(buttonEntrar);
            Controls.Add(linkLabelRegistrar);
            Controls.Add(textBoxCorFav);
            Controls.Add(labelCorFav);
            Controls.Add(textBoxSenha);
            Controls.Add(labelSenha);
            Controls.Add(textBoxUsuário);
            Controls.Add(labelUsuario);
            Name = "ExercicioForm";
            Text = "ExercicioForm";
            Load += ExercicioForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuário;
        private Label labelUsuario;
        private TextBox textBoxSenha;
        private Label labelSenha;
        private TextBox textBoxCorFav;
        private Label labelCorFav;
        private LinkLabel linkLabelRegistrar;
        private Button buttonEntrar;
    }
}