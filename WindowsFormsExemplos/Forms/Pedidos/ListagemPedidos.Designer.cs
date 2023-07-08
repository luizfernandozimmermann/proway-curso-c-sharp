namespace WindowsFormsExemplos.Forms.Pedidos
{
    partial class ListagemPedidos
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
            labelCliente = new Label();
            comboBoxClientes = new ComboBox();
            radioButtonStatusTodos = new RadioButton();
            radioButtonStatusOrcamento = new RadioButton();
            radioButtonStatusEfetivado = new RadioButton();
            radioButtonStatusCancelado = new RadioButton();
            labelStatus = new Label();
            buttonCriarOrcamento = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 303);
            dataGridView1.TabIndex = 0;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(35, 13);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(55, 20);
            labelCliente.TabIndex = 1;
            labelCliente.Text = "Cliente";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(35, 36);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(246, 28);
            comboBoxClientes.TabIndex = 2;
            // 
            // radioButtonStatusTodos
            // 
            radioButtonStatusTodos.AutoSize = true;
            radioButtonStatusTodos.Location = new Point(287, 36);
            radioButtonStatusTodos.Name = "radioButtonStatusTodos";
            radioButtonStatusTodos.Size = new Size(70, 24);
            radioButtonStatusTodos.TabIndex = 3;
            radioButtonStatusTodos.TabStop = true;
            radioButtonStatusTodos.Text = "Todos";
            radioButtonStatusTodos.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatusOrcamento
            // 
            radioButtonStatusOrcamento.AutoSize = true;
            radioButtonStatusOrcamento.Location = new Point(287, 66);
            radioButtonStatusOrcamento.Name = "radioButtonStatusOrcamento";
            radioButtonStatusOrcamento.Size = new Size(110, 24);
            radioButtonStatusOrcamento.TabIndex = 4;
            radioButtonStatusOrcamento.TabStop = true;
            radioButtonStatusOrcamento.Text = "Orçamentos";
            radioButtonStatusOrcamento.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatusEfetivado
            // 
            radioButtonStatusEfetivado.AutoSize = true;
            radioButtonStatusEfetivado.Location = new Point(428, 36);
            radioButtonStatusEfetivado.Name = "radioButtonStatusEfetivado";
            radioButtonStatusEfetivado.Size = new Size(99, 24);
            radioButtonStatusEfetivado.TabIndex = 5;
            radioButtonStatusEfetivado.TabStop = true;
            radioButtonStatusEfetivado.Text = "Efetivados";
            radioButtonStatusEfetivado.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatusCancelado
            // 
            radioButtonStatusCancelado.AutoSize = true;
            radioButtonStatusCancelado.Location = new Point(428, 66);
            radioButtonStatusCancelado.Name = "radioButtonStatusCancelado";
            radioButtonStatusCancelado.Size = new Size(106, 24);
            radioButtonStatusCancelado.TabIndex = 6;
            radioButtonStatusCancelado.TabStop = true;
            radioButtonStatusCancelado.Text = "Cancelados";
            radioButtonStatusCancelado.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(287, 9);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(49, 20);
            labelStatus.TabIndex = 7;
            labelStatus.Text = "Status";
            // 
            // buttonCriarOrcamento
            // 
            buttonCriarOrcamento.Location = new Point(668, 13);
            buttonCriarOrcamento.Name = "buttonCriarOrcamento";
            buttonCriarOrcamento.Size = new Size(120, 116);
            buttonCriarOrcamento.TabIndex = 8;
            buttonCriarOrcamento.Text = "Criar orçamento";
            buttonCriarOrcamento.UseVisualStyleBackColor = true;
            buttonCriarOrcamento.Click += buttonCriarOrcamento_Click;
            // 
            // ListagemPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCriarOrcamento);
            Controls.Add(labelStatus);
            Controls.Add(radioButtonStatusCancelado);
            Controls.Add(radioButtonStatusEfetivado);
            Controls.Add(radioButtonStatusOrcamento);
            Controls.Add(radioButtonStatusTodos);
            Controls.Add(comboBoxClientes);
            Controls.Add(labelCliente);
            Controls.Add(dataGridView1);
            Name = "ListagemPedidos";
            Text = "ListagemPedidos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelCliente;
        private ComboBox comboBoxClientes;
        private RadioButton radioButtonStatusTodos;
        private RadioButton radioButtonStatusOrcamento;
        private RadioButton radioButtonStatusEfetivado;
        private RadioButton radioButtonStatusCancelado;
        private Label labelStatus;
        private Button buttonCriarOrcamento;
    }
}