namespace SistemaPagos.Fronted
{
    partial class PrincipalAdmin
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            groupBox3 = new GroupBox();
            txtMonto = new TextBox();
            btnRealizarPago = new Button();
            txtDescripcion = new TextBox();
            lblClienteEncontrado = new Label();
            btnBuscarCliente = new Button();
            txtBuscarCliente = new TextBox();
            lblBienvenida = new Label();
            lblTiempoRestante = new Label();
            timerSesion = new System.Windows.Forms.Timer(components);
            dgvHistorial = new DataGridView();
            IdPago = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            IdentificacionCliente = new DataGridViewTextBoxColumn();
            NombreCliente = new DataGridViewTextBoxColumn();
            lblTotalGeneral = new Label();
            btnTotalPorCliente = new Button();
            btnHistorialGeneral = new Button();
            btnCerrarSesion = new Button();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gabriola", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(397, -9);
            label1.Name = "label1";
            label1.Size = new Size(282, 68);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE PAGOS";
            label1.Click += label1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtMonto);
            groupBox3.Controls.Add(btnRealizarPago);
            groupBox3.Controls.Add(txtDescripcion);
            groupBox3.Controls.Add(lblClienteEncontrado);
            groupBox3.Controls.Add(btnBuscarCliente);
            groupBox3.Controls.Add(txtBuscarCliente);
            groupBox3.Location = new Point(87, 62);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(356, 222);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Realizar un nuevo pago";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(182, 95);
            txtMonto.Name = "txtMonto";
            txtMonto.PlaceholderText = "Monto";
            txtMonto.Size = new Size(121, 27);
            txtMonto.TabIndex = 8;
            txtMonto.TextChanged += txtMonto_TextChanged;
            // 
            // btnRealizarPago
            // 
            btnRealizarPago.Location = new Point(184, 149);
            btnRealizarPago.Name = "btnRealizarPago";
            btnRealizarPago.Size = new Size(119, 29);
            btnRealizarPago.TabIndex = 7;
            btnRealizarPago.Text = "Ingresar Pago";
            btnRealizarPago.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(10, 95);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción del Pago";
            txtDescripcion.Size = new Size(171, 27);
            txtDescripcion.TabIndex = 6;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // lblClienteEncontrado
            // 
            lblClienteEncontrado.AutoSize = true;
            lblClienteEncontrado.ForeColor = Color.FromArgb(0, 0, 192);
            lblClienteEncontrado.Location = new Point(6, 65);
            lblClienteEncontrado.Name = "lblClienteEncontrado";
            lblClienteEncontrado.Size = new Size(167, 20);
            lblClienteEncontrado.TabIndex = 5;
            lblClienteEncontrado.Text = "Cliente no seleccionado";
            lblClienteEncontrado.Click += label2_Click;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(207, 24);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(94, 29);
            btnBuscarCliente.TabIndex = 4;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(6, 26);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.PlaceholderText = "No. de Identificación (CUI)";
            txtBuscarCliente.Size = new Size(195, 27);
            txtBuscarCliente.TabIndex = 3;
            txtBuscarCliente.TextChanged += textBox1_TextChanged;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(242, 39);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(134, 20);
            lblBienvenida.TabIndex = 6;
            lblBienvenida.Text = "Bienvenido, Admin";
            lblBienvenida.Click += label4_Click;
            // 
            // lblTiempoRestante
            // 
            lblTiempoRestante.AutoSize = true;
            lblTiempoRestante.Location = new Point(714, 46);
            lblTiempoRestante.Name = "lblTiempoRestante";
            lblTiempoRestante.Size = new Size(126, 20);
            lblTiempoRestante.TabIndex = 7;
            lblTiempoRestante.Text = "Sesión válida por:";
            // 
            // timerSesion
            // 
            timerSesion.Interval = 1000;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Columns.AddRange(new DataGridViewColumn[] { IdPago, Fecha, Descripcion, Monto, IdentificacionCliente, NombreCliente });
            dgvHistorial.Location = new Point(473, 77);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(633, 188);
            dgvHistorial.TabIndex = 8;
            dgvHistorial.CellContentClick += dgvHistorial_CellContentClick;
            // 
            // IdPago
            // 
            IdPago.DataPropertyName = "IdPago";
            IdPago.HeaderText = "Id Pago";
            IdPago.MinimumWidth = 6;
            IdPago.Name = "IdPago";
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            // 
            // IdentificacionCliente
            // 
            IdentificacionCliente.DataPropertyName = "IdentificacionCliente";
            IdentificacionCliente.HeaderText = "No. Identificación (CUI)";
            IdentificacionCliente.MinimumWidth = 6;
            IdentificacionCliente.Name = "IdentificacionCliente";
            // 
            // NombreCliente
            // 
            NombreCliente.DataPropertyName = "NombreCliente";
            NombreCliente.HeaderText = "Cliente";
            NombreCliente.MinimumWidth = 6;
            NombreCliente.Name = "NombreCliente";
            // 
            // lblTotalGeneral
            // 
            lblTotalGeneral.AutoSize = true;
            lblTotalGeneral.Location = new Point(485, 310);
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(115, 20);
            lblTotalGeneral.TabIndex = 9;
            lblTotalGeneral.Text = "Total General: Q";
            // 
            // btnTotalPorCliente
            // 
            btnTotalPorCliente.Location = new Point(91, 328);
            btnTotalPorCliente.Name = "btnTotalPorCliente";
            btnTotalPorCliente.Size = new Size(157, 29);
            btnTotalPorCliente.TabIndex = 10;
            btnTotalPorCliente.Text = "Ver total por cliente";
            btnTotalPorCliente.UseVisualStyleBackColor = true;
            btnTotalPorCliente.Click += btnTotalPorCliente_Click;
            // 
            // btnHistorialGeneral
            // 
            btnHistorialGeneral.Location = new Point(91, 361);
            btnHistorialGeneral.Name = "btnHistorialGeneral";
            btnHistorialGeneral.Size = new Size(169, 29);
            btnHistorialGeneral.TabIndex = 11;
            btnHistorialGeneral.Text = "Ver historial de pagos";
            btnHistorialGeneral.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(991, 389);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(117, 29);
            btnCerrarSesion.TabIndex = 12;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // PrincipalAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnHistorialGeneral);
            Controls.Add(btnTotalPorCliente);
            Controls.Add(lblTotalGeneral);
            Controls.Add(dgvHistorial);
            Controls.Add(lblTiempoRestante);
            Controls.Add(lblBienvenida);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Name = "PrincipalAdmin";
            Text = "PrincipalAdmin";
            Load += PrincipalAdmin_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ColorDialog colorDialog1;
        private GroupBox groupBox3;
        private TextBox txtBuscarCliente;
        private Button btnBuscarCliente;
        private Label lblClienteEncontrado;
        private Label lblBienvenida;
        private Label lblTiempoRestante;
        private System.Windows.Forms.Timer timerSesion;
        private TextBox txtDescripcion;
        private Button btnRealizarPago;
        private TextBox txtMonto;
        private DataGridView dgvHistorial;
        private DataGridViewTextBoxColumn IdPago;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn IdentificacionCliente;
        private DataGridViewTextBoxColumn NombreCliente;
        private Label lblTotalGeneral;
        private Button btnTotalPorCliente;
        private Button btnHistorialGeneral;
        private Button btnCerrarSesion;
    }
}