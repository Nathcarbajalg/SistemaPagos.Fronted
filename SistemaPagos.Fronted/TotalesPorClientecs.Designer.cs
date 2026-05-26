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
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
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
            Fecha = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            btnRegresar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialCliente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Edwardian Script ITC", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(337, -2);
            label1.Name = "label1";
            label1.Size = new Size(296, 55);
            label1.TabIndex = 0;
            label1.Text = "Totales por Cliente";
            // 
            // txtIdentificacionBuscar
            // 
            txtIdentificacionBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtIdentificacionBuscar.ForeColor = Color.Fuchsia;
            txtIdentificacionBuscar.Location = new Point(55, 75);
            txtIdentificacionBuscar.Name = "txtIdentificacionBuscar";
            txtIdentificacionBuscar.PlaceholderText = "Ingresa No. de Identificación ";
            txtIdentificacionBuscar.Size = new Size(240, 30);
            txtIdentificacionBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Violet;
            btnBuscar.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.Transparent;
            btnBuscar.Location = new Point(302, 75);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(106, 33);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(116, 129);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(14, 23);
            lblNombreCliente.TabIndex = 3;
            lblNombreCliente.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Fuchsia;
            label2.Location = new Point(55, 129);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 4;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Fuchsia;
            label3.Location = new Point(54, 159);
            label3.Name = "label3";
            label3.Size = new Size(176, 27);
            label3.TabIndex = 5;
            label3.Text = "Total Pagado:";
            // 
            // lblTotalPagado
            // 
            lblTotalPagado.AutoSize = true;
            lblTotalPagado.BackColor = Color.Transparent;
            lblTotalPagado.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPagado.ForeColor = Color.Fuchsia;
            lblTotalPagado.Location = new Point(231, 159);
            lblTotalPagado.Name = "lblTotalPagado";
            lblTotalPagado.Size = new Size(82, 27);
            lblTotalPagado.TabIndex = 6;
            lblTotalPagado.Text = "Q.0.00";
            lblTotalPagado.Click += lblTotalPagado_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Fuchsia;
            label4.Location = new Point(55, 187);
            label4.Name = "label4";
            label4.Size = new Size(170, 27);
            label4.TabIndex = 7;
            label4.Text = "No. de Pagos:";
            label4.Click += label4_Click;
            // 
            // lblNumeroPagos
            // 
            lblNumeroPagos.AutoSize = true;
            lblNumeroPagos.BackColor = Color.Transparent;
            lblNumeroPagos.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroPagos.ForeColor = Color.Fuchsia;
            lblNumeroPagos.Location = new Point(231, 187);
            lblNumeroPagos.Name = "lblNumeroPagos";
            lblNumeroPagos.Size = new Size(25, 27);
            lblNumeroPagos.TabIndex = 8;
            lblNumeroPagos.Text = "#";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Violet;
            groupBox1.Controls.Add(dgvHistorialCliente);
            groupBox1.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(192, 0, 192);
            groupBox1.Location = new Point(40, 244);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(791, 191);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Historial de Pagos del Cliente";
            // 
            // dgvHistorialCliente
            // 
            dgvHistorialCliente.AllowUserToResizeRows = false;
            dgvHistorialCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialCliente.BackgroundColor = Color.White;
            dgvHistorialCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialCliente.Columns.AddRange(new DataGridViewColumn[] { Fecha, Descripcion, Monto });
            dgvHistorialCliente.Dock = DockStyle.Fill;
            dgvHistorialCliente.Location = new Point(3, 25);
            dgvHistorialCliente.Name = "dgvHistorialCliente";
            dgvHistorialCliente.ReadOnly = true;
            dgvHistorialCliente.RowHeadersWidth = 51;
            dgvHistorialCliente.Size = new Size(785, 163);
            dgvHistorialCliente.TabIndex = 0;
            dgvHistorialCliente.CellContentClick += dataGridView1_CellContentClick;
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
            dataGridViewCellStyle21.Format = "N2";
            Monto.DefaultCellStyle = dataGridViewCellStyle21;
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Violet;
            btnRegresar.DialogResult = DialogResult.Cancel;
            btnRegresar.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(727, 458);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(106, 33);
            btnRegresar.TabIndex = 10;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // TotalesPorClientecs
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(900, 518);
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
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TotalesPorClientecs";
            StartPosition = FormStartPosition.CenterScreen;
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