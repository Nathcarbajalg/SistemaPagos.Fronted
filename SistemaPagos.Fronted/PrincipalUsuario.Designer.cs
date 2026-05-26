namespace SistemaPagos.Fronted
{
    partial class PrincipalUsuario
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
            lblBienvenida = new Label();
            lblTiempoRestante = new Label();
            groupBox1 = new GroupBox();
            btnRealizarPago = new Button();
            txtMonto = new TextBox();
            txtDescripcion = new TextBox();
            dgvHistorial = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Descripción = new DataGridViewTextBoxColumn();
            lblTotalGeneral = new Label();
            btnCerrarSesion = new Button();
            timerSesion = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(27, 9);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(166, 20);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = " \"Bienvenido, [Usuario]\"";
            lblBienvenida.Click += label1_Click;
            // 
            // lblTiempoRestante
            // 
            lblTiempoRestante.AutoSize = true;
            lblTiempoRestante.Location = new Point(543, 9);
            lblTiempoRestante.Name = "lblTiempoRestante";
            lblTiempoRestante.Size = new Size(172, 20);
            lblTiempoRestante.TabIndex = 3;
            lblTiempoRestante.Text = "Sesión válida por: --:--:--";
            lblTiempoRestante.Click += lblTiempoRestante_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRealizarPago);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Location = new Point(27, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 153);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Realizar nuevo pago";
            // 
            // btnRealizarPago
            // 
            btnRealizarPago.BackColor = Color.Orange;
            btnRealizarPago.Location = new Point(237, 108);
            btnRealizarPago.Name = "btnRealizarPago";
            btnRealizarPago.Size = new Size(129, 29);
            btnRealizarPago.TabIndex = 2;
            btnRealizarPago.Text = "Realizar Pago";
            btnRealizarPago.UseVisualStyleBackColor = false;
            btnRealizarPago.Click += button1_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(187, 38);
            txtMonto.Name = "txtMonto";
            txtMonto.PlaceholderText = "Monto";
            txtMonto.Size = new Size(125, 27);
            txtMonto.TabIndex = 1;
            txtMonto.TextChanged += txtMonto_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(6, 37);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción del Pago";
            txtDescripcion.Size = new Size(160, 27);
            txtDescripcion.TabIndex = 0;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Columns.AddRange(new DataGridViewColumn[] { Fecha, Monto, Descripción });
            dgvHistorial.Location = new Point(12, 254);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(764, 134);
            dgvHistorial.TabIndex = 5;
            dgvHistorial.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            // 
            // Descripción
            // 
            Descripción.HeaderText = "Descripción";
            Descripción.MinimumWidth = 6;
            Descripción.Name = "Descripción";
            // 
            // lblTotalGeneral
            // 
            lblTotalGeneral.AutoSize = true;
            lblTotalGeneral.Location = new Point(437, 57);
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(115, 20);
            lblTotalGeneral.TabIndex = 8;
            lblTotalGeneral.Text = "Total General: Q";
            lblTotalGeneral.Click += label3_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(611, 394);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(151, 29);
            btnCerrarSesion.TabIndex = 9;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += button1_Click_1;
            // 
            // timerSesion
            // 
            timerSesion.Interval = 1000;
            timerSesion.Tick += timerSesion_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 222);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 3;
            label2.Text = "MI HISTORIAL DE PAGOS";
            // 
            // PrincipalUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblTotalGeneral);
            Controls.Add(dgvHistorial);
            Controls.Add(groupBox1);
            Controls.Add(lblTiempoRestante);
            Controls.Add(lblBienvenida);
            Name = "PrincipalUsuario";
            Text = "PrincipalUsuario";
            Load += PrincipalUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Label lblTiempoRestante;
        private GroupBox groupBox1;
        private TextBox txtDescripcion;
        private TextBox txtMonto;
        private Button btnRealizarPago;
        private DataGridView dgvHistorial;
        private Label lblTotalGeneral;
        private Button btnCerrarSesion;
        private System.Windows.Forms.Timer timerSesion;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Descripción;
        private DataGridViewTextBoxColumn Monto;
        private Label label2;
    }
}