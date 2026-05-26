namespace SistemaPagos.Fronted
{
    partial class RegistroUsuario
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
            txtNombre = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            txtIdentificacion = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            txtContrasena = new TextBox();
            txtConfirmarContrasena = new TextBox();
            label7 = new Label();
            btnCrearUsuario = new Button();
            llVolverLogin = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 19);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 0;
            label1.Text = "CREAR NUEVO USUARIO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 58);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingresa tu Nombre: ";
            label2.Click += label2_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(86, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Escribe tu nombre";
            txtNombre.Size = new Size(162, 27);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 60);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 3;
            label3.Text = "Ingresa tu Apellido:";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(468, 81);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Esbribe tu apellido";
            textBox1.Size = new Size(188, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 137);
            label4.Name = "label4";
            label4.Size = new Size(213, 20);
            label4.TabIndex = 5;
            label4.Text = "Ingrea tu No. de Identificación:";
            label4.Click += label4_Click;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(85, 167);
            txtIdentificacion.MaxLength = 12;
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.PlaceholderText = "Escribe tu No. de Identificación";
            txtIdentificacion.Size = new Size(212, 27);
            txtIdentificacion.TabIndex = 6;
            txtIdentificacion.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(466, 135);
            label5.Name = "label5";
            label5.Size = new Size(221, 20);
            label5.TabIndex = 7;
            label5.Text = "Ingresa tu Fecha de Nacimiento:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(469, 162);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 220);
            label6.Name = "label6";
            label6.Size = new Size(164, 20);
            label6.TabIndex = 9;
            label6.Text = "Ingresa una contraseña:";
            label6.Click += label6_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(92, 249);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PlaceholderText = "Contraseña";
            txtContrasena.Size = new Size(125, 27);
            txtContrasena.TabIndex = 10;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Location = new Point(92, 315);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.PlaceholderText = "Confirmar Contraseña";
            txtConfirmarContrasena.Size = new Size(172, 27);
            txtConfirmarContrasena.TabIndex = 11;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            txtConfirmarContrasena.TextChanged += txtConfirmarContrasena_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(87, 287);
            label7.Name = "label7";
            label7.Size = new Size(173, 20);
            label7.TabIndex = 12;
            label7.Text = "Confirmar tu Contraseña:";
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Location = new Point(89, 368);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(109, 29);
            btnCrearUsuario.TabIndex = 13;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = true;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // llVolverLogin
            // 
            llVolverLogin.AutoSize = true;
            llVolverLogin.Location = new Point(88, 400);
            llVolverLogin.Name = "llVolverLogin";
            llVolverLogin.Size = new Size(54, 20);
            llVolverLogin.TabIndex = 14;
            llVolverLogin.TabStop = true;
            llVolverLogin.Text = "Volver ";
            // 
            // RegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(llVolverLogin);
            Controls.Add(btnCrearUsuario);
            Controls.Add(label7);
            Controls.Add(txtConfirmarContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(txtIdentificacion);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroUsuario";
            Text = "RegistroUsuariocs";
            Load += RegistroUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox txtIdentificacion;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox txtContrasena;
        private TextBox txtConfirmarContrasena;
        private Label label7;
        private Button btnCrearUsuario;
        private LinkLabel llVolverLogin;
    }
}