namespace SistemaPagos.Fronted
{
    partial class RecuperarPassword
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
            label1 = new Label();
            label2 = new Label();
            txtIdentificacion = new TextBox();
            btnEnviar = new Button();
            lblMensaje = new Label();
            groupBox1 = new GroupBox();
            txtConfirmarContrasena = new TextBox();
            btnGuardar = new Button();
            label4 = new Label();
            txtNuevaContrasena = new TextBox();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(236, 9);
            label1.Name = "label1";
            label1.Size = new Size(355, 28);
            label1.TabIndex = 0;
            label1.Text = "RECUPERAR CONTRASEÑA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 192);
            label2.Location = new Point(52, 56);
            label2.Name = "label2";
            label2.Size = new Size(385, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese su número de identificación (CUI):";
            label2.Click += label2_Click;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(55, 79);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.PlaceholderText = "CUI";
            txtIdentificacion.Size = new Size(173, 27);
            txtIdentificacion.TabIndex = 2;
            txtIdentificacion.TextChanged += textBox1_TextChanged;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.Fuchsia;
            btnEnviar.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEnviar.ForeColor = Color.White;
            btnEnviar.Location = new Point(451, 97);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 29);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar ";
            btnEnviar.UseVisualStyleBackColor = false;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(52, 118);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(23, 20);
            lblMensaje.TabIndex = 4;
            lblMensaje.Text = "\"\"";
            lblMensaje.Click += lblMensaje_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtConfirmarContrasena);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNuevaContrasena);
            groupBox1.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(192, 0, 192);
            groupBox1.Location = new Point(55, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 205);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nueva Contraseña";
            groupBox1.Visible = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Location = new Point(0, 109);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.PlaceholderText = "Confirma tu Contraseña";
            txtConfirmarContrasena.Size = new Size(167, 28);
            txtConfirmarContrasena.TabIndex = 4;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            txtConfirmarContrasena.TextChanged += txtConfirmarContrasena_TextChanged_1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Fuchsia;
            btnGuardar.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(-2, 157);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar\r\n";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 75);
            label4.Name = "label4";
            label4.Size = new Size(210, 20);
            label4.TabIndex = 2;
            label4.Text = "Confirmar Contraseña";
            // 
            // txtNuevaContrasena
            // 
            txtNuevaContrasena.Location = new Point(0, 26);
            txtNuevaContrasena.Name = "txtNuevaContrasena";
            txtNuevaContrasena.PlaceholderText = "Escribe tu nueva contraseña";
            txtNuevaContrasena.Size = new Size(204, 28);
            txtNuevaContrasena.TabIndex = 1;
            txtNuevaContrasena.UseSystemPasswordChar = true;
            txtNuevaContrasena.TextChanged += textBox1_TextChanged_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Fuchsia;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(620, 386);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 29);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += button2_Click;
            // 
            // RecuperarPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(lblMensaje);
            Controls.Add(btnEnviar);
            Controls.Add(txtIdentificacion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RecuperarPassword";
            Text = "RecuperarPassword";
            Load += RecuperarPassword_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIdentificacion;
        private Button btnEnviar;
        private Label lblMensaje;
        private GroupBox groupBox1;
        private TextBox txtNuevaContrasena;
        private Label label4;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtConfirmarContrasena;
    }
}