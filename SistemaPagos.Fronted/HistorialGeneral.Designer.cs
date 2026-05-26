namespace SistemaPagos.Fronted
{
    partial class HistorialGeneral
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            lblTotalPagos = new Label();
            label2 = new Label();
            lblTotalGeneral = new Label();
            label3 = new Label();
            lblTotalClientes = new Label();
            label5 = new Label();
            dgvUltimosPagos = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUltimosPagos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(47, 48);
            label1.Name = "label1";
            label1.Size = new Size(245, 20);
            label1.TabIndex = 0;
            label1.Text = "Total de Pagos Realizados:";
            // 
            // lblTotalPagos
            // 
            lblTotalPagos.AutoSize = true;
            lblTotalPagos.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalPagos.Location = new Point(342, 48);
            lblTotalPagos.Name = "lblTotalPagos";
            lblTotalPagos.Size = new Size(19, 20);
            lblTotalPagos.TabIndex = 1;
            lblTotalPagos.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Fuchsia;
            label2.Location = new Point(46, 71);
            label2.Name = "label2";
            label2.Size = new Size(233, 20);
            label2.TabIndex = 2;
            label2.Text = "Total General Monetario:";
            // 
            // lblTotalGeneral
            // 
            lblTotalGeneral.AutoSize = true;
            lblTotalGeneral.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalGeneral.Location = new Point(298, 71);
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(63, 20);
            lblTotalGeneral.TabIndex = 3;
            lblTotalGeneral.Text = "Q 0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Fuchsia;
            label3.Location = new Point(46, 96);
            label3.Name = "label3";
            label3.Size = new Size(247, 20);
            label3.TabIndex = 4;
            label3.Text = "Total Clientes Registrados:";
            // 
            // lblTotalClientes
            // 
            lblTotalClientes.AutoSize = true;
            lblTotalClientes.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalClientes.ForeColor = Color.Black;
            lblTotalClientes.Location = new Point(342, 96);
            lblTotalClientes.Name = "lblTotalClientes";
            lblTotalClientes.Size = new Size(19, 20);
            lblTotalClientes.TabIndex = 5;
            lblTotalClientes.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(192, 0, 192);
            label5.Location = new Point(49, 149);
            label5.Name = "label5";
            label5.Size = new Size(172, 22);
            label5.TabIndex = 7;
            label5.Text = "Últimos 10 Pagos:";
            label5.Click += label5_Click;
            // 
            // dgvUltimosPagos
            // 
            dgvUltimosPagos.AllowUserToAddRows = false;
            dgvUltimosPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUltimosPagos.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Fuchsia;
            dataGridViewCellStyle3.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUltimosPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUltimosPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUltimosPagos.Columns.AddRange(new DataGridViewColumn[] { Fecha, Monto, Descripcion });
            dgvUltimosPagos.Location = new Point(49, 184);
            dgvUltimosPagos.Name = "dgvUltimosPagos";
            dgvUltimosPagos.ReadOnly = true;
            dgvUltimosPagos.RowHeadersWidth = 51;
            dgvUltimosPagos.Size = new Size(713, 121);
            dgvUltimosPagos.TabIndex = 8;
            dgvUltimosPagos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle4.Format = "N2";
            Monto.DefaultCellStyle = dataGridViewCellStyle4;
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Fuchsia;
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(670, 387);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(92, 34);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // HistorialGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(dgvUltimosPagos);
            Controls.Add(label5);
            Controls.Add(lblTotalClientes);
            Controls.Add(label3);
            Controls.Add(lblTotalGeneral);
            Controls.Add(label2);
            Controls.Add(lblTotalPagos);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HistorialGeneral";
            Text = "Historial  General";
            Load += HistorialGeneral_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUltimosPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTotalPagos;
        private Label label2;
        private Label lblTotalGeneral;
        private Label label3;
        private Label lblTotalClientes;
        private Label label5;
        private DataGridView dgvUltimosPagos;
        private Button btnAceptar;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Descripcion;
    }
}