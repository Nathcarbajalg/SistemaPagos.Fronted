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
            btnGuardar = new Button();
            label4 = new Label();
            txtNuevaContrasena = new TextBox();
            label3 = new Label();
            txtConfirmarContrasena = new TextBox();
            button1 = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 21);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 0;
            label1.Text = "RECUPERAR CONTRASEÑA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 56);
            label2.Name = "label2";
            label2.Size = new Size(285, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese su número de identificación (CUI):";
            label2.Click += label2_Click;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(53, 82);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.PlaceholderText = "CUI";
            txtIdentificacion.Size = new Size(173, 27);
            txtIdentificacion.TabIndex = 2;
            txtIdentificacion.TextChanged += textBox1_TextChanged;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(343, 75);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 29);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar ";
            btnEnviar.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(52, 118);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(21, 20);
            lblMensaje.TabIndex = 4;
            lblMensaje.Text = "\"\"";
            lblMensaje.Click += lblMensaje_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNuevaContrasena);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(55, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 205);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nueva Contraseña";
            groupBox1.Visible = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(8, 171);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar\r\n";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 2;
            label4.Text = "Confirmar Contraseña";
            // 
            // txtNuevaContrasena
            // 
            txtNuevaContrasena.Location = new Point(14, 61);
            txtNuevaContrasena.Name = "txtNuevaContrasena";
            txtNuevaContrasena.PlaceholderText = "Escribe tu nueva contraseña";
            txtNuevaContrasena.Size = new Size(204, 27);
            txtNuevaContrasena.TabIndex = 1;
            txtNuevaContrasena.UseSystemPasswordChar = true;
            txtNuevaContrasena.TextChanged += textBox1_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 31);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 0;
            label3.Text = "Nueva Contraseña";
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Location = new Point(69, 296);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.PlaceholderText = "Confirma tu contraseña";
            txtConfirmarContrasena.Size = new Size(179, 27);
            txtConfirmarContrasena.TabIndex = 6;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(55, 389);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button2_Click;
            // 
            // RecuperarPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            Controls.Add(txtConfirmarContrasena);
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
        private Label label3;
        private TextBox txtNuevaContrasena;
        private Label label4;
        private TextBox txtConfirmarContrasena;
        private Button btnGuardar;
        private Button button1;
        private Button btnCancelar;
    }
}