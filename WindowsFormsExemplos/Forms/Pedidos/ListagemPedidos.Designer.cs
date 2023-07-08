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
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnCliente = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            ColumnValorTotal = new DataGridViewTextBoxColumn();
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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnCliente, ColumnStatus, ColumnValorTotal });
            dataGridView1.Location = new Point(10, 101);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(679, 227);
            dataGridView1.TabIndex = 0;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Código";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            // 
            // ColumnCliente
            // 
            ColumnCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnCliente.HeaderText = "Cliente";
            ColumnCliente.Name = "ColumnCliente";
            ColumnCliente.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.Name = "ColumnStatus";
            ColumnStatus.ReadOnly = true;
            // 
            // ColumnValorTotal
            // 
            ColumnValorTotal.HeaderText = "Valor Total";
            ColumnValorTotal.Name = "ColumnValorTotal";
            ColumnValorTotal.ReadOnly = true;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(31, 10);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(44, 15);
            labelCliente.TabIndex = 1;
            labelCliente.Text = "Cliente";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.DisplayMember = "Nome";
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(31, 27);
            comboBoxClientes.Margin = new Padding(3, 2, 3, 2);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(216, 23);
            comboBoxClientes.TabIndex = 2;
            comboBoxClientes.ValueMember = "Nome";
            comboBoxClientes.SelectedIndexChanged += comboBoxClientes_SelectedIndexChanged;
            // 
            // radioButtonStatusTodos
            // 
            radioButtonStatusTodos.AutoSize = true;
            radioButtonStatusTodos.Checked = true;
            radioButtonStatusTodos.Location = new Point(251, 27);
            radioButtonStatusTodos.Margin = new Padding(3, 2, 3, 2);
            radioButtonStatusTodos.Name = "radioButtonStatusTodos";
            radioButtonStatusTodos.Size = new Size(56, 19);
            radioButtonStatusTodos.TabIndex = 3;
            radioButtonStatusTodos.TabStop = true;
            radioButtonStatusTodos.Text = "Todos";
            radioButtonStatusTodos.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatusOrcamento
            // 
            radioButtonStatusOrcamento.AutoSize = true;
            radioButtonStatusOrcamento.Location = new Point(251, 50);
            radioButtonStatusOrcamento.Margin = new Padding(3, 2, 3, 2);
            radioButtonStatusOrcamento.Name = "radioButtonStatusOrcamento";
            radioButtonStatusOrcamento.Size = new Size(90, 19);
            radioButtonStatusOrcamento.TabIndex = 4;
            radioButtonStatusOrcamento.Text = "Orçamentos";
            radioButtonStatusOrcamento.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatusEfetivado
            // 
            radioButtonStatusEfetivado.AutoSize = true;
            radioButtonStatusEfetivado.Location = new Point(374, 27);
            radioButtonStatusEfetivado.Margin = new Padding(3, 2, 3, 2);
            radioButtonStatusEfetivado.Name = "radioButtonStatusEfetivado";
            radioButtonStatusEfetivado.Size = new Size(79, 19);
            radioButtonStatusEfetivado.TabIndex = 5;
            radioButtonStatusEfetivado.Text = "Efetivados";
            radioButtonStatusEfetivado.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatusCancelado
            // 
            radioButtonStatusCancelado.AutoSize = true;
            radioButtonStatusCancelado.Location = new Point(374, 50);
            radioButtonStatusCancelado.Margin = new Padding(3, 2, 3, 2);
            radioButtonStatusCancelado.Name = "radioButtonStatusCancelado";
            radioButtonStatusCancelado.Size = new Size(86, 19);
            radioButtonStatusCancelado.TabIndex = 6;
            radioButtonStatusCancelado.Text = "Cancelados";
            radioButtonStatusCancelado.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(251, 7);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(39, 15);
            labelStatus.TabIndex = 7;
            labelStatus.Text = "Status";
            // 
            // buttonCriarOrcamento
            // 
            buttonCriarOrcamento.Location = new Point(584, 10);
            buttonCriarOrcamento.Margin = new Padding(3, 2, 3, 2);
            buttonCriarOrcamento.Name = "buttonCriarOrcamento";
            buttonCriarOrcamento.Size = new Size(105, 87);
            buttonCriarOrcamento.TabIndex = 8;
            buttonCriarOrcamento.Text = "Criar orçamento";
            buttonCriarOrcamento.UseVisualStyleBackColor = true;
            buttonCriarOrcamento.Click += buttonCriarOrcamento_Click;
            // 
            // ListagemPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonCriarOrcamento);
            Controls.Add(labelStatus);
            Controls.Add(radioButtonStatusCancelado);
            Controls.Add(radioButtonStatusEfetivado);
            Controls.Add(radioButtonStatusOrcamento);
            Controls.Add(radioButtonStatusTodos);
            Controls.Add(comboBoxClientes);
            Controls.Add(labelCliente);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListagemPedidos";
            Text = "ListagemPedidos";
            Load += ListagemPedidos_Load;
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
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnCliente;
        private DataGridViewTextBoxColumn ColumnStatus;
        private DataGridViewTextBoxColumn ColumnValorTotal;
    }
}