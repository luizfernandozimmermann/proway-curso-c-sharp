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
            this.labelNome = new System.Windows.Forms.Label();
            this.textboxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxQuantidadeHoras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxValorHora = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(24, 17);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // textboxNome
            // 
            this.textboxNome.Location = new System.Drawing.Point(73, 15);
            this.textboxNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxNome.Name = "textboxNome";
            this.textboxNome.Size = new System.Drawing.Size(344, 23);
            this.textboxNome.TabIndex = 1;
            this.textboxNome.TextChanged += new System.EventHandler(this.textboxNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade de horas";
            // 
            // textboxQuantidadeHoras
            // 
            this.textboxQuantidadeHoras.Location = new System.Drawing.Point(158, 59);
            this.textboxQuantidadeHoras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxQuantidadeHoras.Name = "textboxQuantidadeHoras";
            this.textboxQuantidadeHoras.Size = new System.Drawing.Size(259, 23);
            this.textboxQuantidadeHoras.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor hora";
            // 
            // textboxValorHora
            // 
            this.textboxValorHora.Location = new System.Drawing.Point(96, 98);
            this.textboxValorHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxValorHora.Name = "textboxValorHora";
            this.textboxValorHora.Size = new System.Drawing.Size(321, 23);
            this.textboxValorHora.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(393, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular salário";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.Move += new System.EventHandler(this.button1_Move);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textboxValorHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxQuantidadeHoras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxNome);
            this.Controls.Add(this.labelNome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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