namespace WindowsFormsExemplos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNome = new Label();
            textboxNome = new TextBox();
            label2 = new Label();
            textboxQuantidadeHoras = new TextBox();
            label3 = new Label();
            textboxValorHora = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(27, 23);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            labelNome.Click += label1_Click;
            // 
            // textboxNome
            // 
            textboxNome.Location = new Point(83, 20);
            textboxNome.Name = "textboxNome";
            textboxNome.Size = new Size(393, 27);
            textboxNome.TabIndex = 1;
            textboxNome.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 82);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 2;
            label2.Text = "Quantidade de horas";
            // 
            // textboxQuantidadeHoras
            // 
            textboxQuantidadeHoras.Location = new Point(181, 79);
            textboxQuantidadeHoras.Name = "textboxQuantidadeHoras";
            textboxQuantidadeHoras.Size = new Size(295, 27);
            textboxQuantidadeHoras.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 134);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 4;
            label3.Text = "Valor hora";
            // 
            // textboxValorHora
            // 
            textboxValorHora.Location = new Point(110, 131);
            textboxValorHora.Name = "textboxValorHora";
            textboxValorHora.Size = new Size(366, 27);
            textboxValorHora.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(27, 189);
            button1.Name = "button1";
            button1.Size = new Size(449, 67);
            button1.TabIndex = 6;
            button1.Text = "Calcular salário";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 279);
            Controls.Add(button1);
            Controls.Add(textboxValorHora);
            Controls.Add(label3);
            Controls.Add(textboxQuantidadeHoras);
            Controls.Add(label2);
            Controls.Add(textboxNome);
            Controls.Add(labelNome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private TextBox textboxNome;
        private Label label2;
        private TextBox textboxQuantidadeHoras;
        private Label label3;
        private TextBox textboxValorHora;
        private Button button1;
    }
}