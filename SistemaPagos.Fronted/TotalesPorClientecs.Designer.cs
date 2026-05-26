namespace SistemaPagos.Fronted
{
    partial class TotalesPorClientecs
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            txtIdentificacionBuscar = new TextBox();
            btnBuscar = new Button();
            lblNombreCliente = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTotalPagado = new Label();
            label4 = new Label();
            lblNumeroPagos = new Label();
            groupBox1 = new GroupBox();
            dgvHistorialCliente = new DataGridView();
            btnRegresar = new Button();
            Fecha = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialCliente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 17);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Totales por Cliente";
            // 
            // txtIdentificacionBuscar
            // 
            txtIdentificacionBuscar.Location = new Point(49, 65);
            txtIdentificacionBuscar.Name = "txtIdentificacionBuscar";
            txtIdentificacionBuscar.PlaceholderText = "Ingresa No. de Identificación ";
            txtIdentificacionBuscar.Size = new Size(214, 27);
            txtIdentificacionBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(268, 65);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(103, 112);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(12, 20);
            lblNombreCliente.TabIndex = 3;
            lblNombreCliente.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 112);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 4;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 138);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 5;
            label3.Text = "Total Pagado:";
            // 
            // lblTotalPagado
            // 
            lblTotalPagado.AutoSize = true;
            lblTotalPagado.Location = new Point(145, 139);
            lblTotalPagado.Name = "lblTotalPagado";
            lblTotalPagado.Size = new Size(50, 20);
            lblTotalPagado.TabIndex = 6;
            lblTotalPagado.Text = "Q.0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 163);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 7;
            label4.Text = "No. de Pagos:";
            // 
            // lblNumeroPagos
            // 
            lblNumeroPagos.AutoSize = true;
            lblNumeroPagos.Location = new Point(151, 164);
            lblNumeroPagos.Name = "lblNumeroPagos";
            lblNumeroPagos.Size = new Size(18, 20);
            lblNumeroPagos.TabIndex = 8;
            lblNumeroPagos.Text = "#";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvHistorialCliente);
            groupBox1.Location = new Point(36, 212);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(703, 166);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Historial de Pagos del Cliente";
            groupBox1.Enter += this.groupBox1_Enter;
            // 
            // dgvHistorialCliente
            // 
            dgvHistorialCliente.AllowUserToResizeRows = false;
            dgvHistorialCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialCliente.Columns.AddRange(new DataGridViewColumn[] { Fecha, Descripcion, Monto });
            dgvHistorialCliente.Dock = DockStyle.Fill;
            dgvHistorialCliente.Location = new Point(3, 23);
            dgvHistorialCliente.Name = "dgvHistorialCliente";
            dgvHistorialCliente.ReadOnly = true;
            dgvHistorialCliente.RowHeadersWidth = 51;
            dgvHistorialCliente.Size = new Size(697, 140);
            dgvHistorialCliente.TabIndex = 0;
            dgvHistorialCliente.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnRegresar
            // 
            btnRegresar.DialogResult = DialogResult.Cancel;
            btnRegresar.Location = new Point(646, 398);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 10;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle2.Format = "N2";
            Monto.DefaultCellStyle = dataGridViewCellStyle2;
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            // 
            // TotalesPorClientecs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Controls.Add(groupBox1);
            Controls.Add(lblNumeroPagos);
            Controls.Add(label4);
            Controls.Add(lblTotalPagado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNombreCliente);
            Controls.Add(btnBuscar);
            Controls.Add(txtIdentificacionBuscar);
            Controls.Add(label1);
            Name = "TotalesPorClientecs";
            Text = "TotalesPorClientecs";
            Load += TotalesPorClientecs_Load_1;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdentificacionBuscar;
        private Button btnBuscar;
        private Label lblNombreCliente;
        private Label label2;
        private Label label3;
        private Label lblTotalPagado;
        private Label label4;
        private Label lblNumeroPagos;
        private GroupBox groupBox1;
        private DataGridView dgvHistorialCliente;
        private Button btnRegresar;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Monto;
    }
}