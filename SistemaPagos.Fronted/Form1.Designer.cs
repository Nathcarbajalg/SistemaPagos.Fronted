namespace SistemaPagos.Fronted
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtIdentificacion = new TextBox();
            label3 = new Label();
            txtContrasena = new TextBox();
            btnIngresar = new Button();
            llOlvideContrasena = new LinkLabel();
            label4 = new Label();
            llCrearUsuario = new LinkLabel();
            btnVerContrasena = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Bahnschrift Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(487, 20);
            label1.Name = "label1";
            label1.Size = new Size(171, 41);
            label1.TabIndex = 0;
            label1.Text = "Iniciar Sesión";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(487, 83);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 1;
            label2.Text = "No. de Identificación (CUI)";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(467, 106);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(204, 27);
            txtIdentificacion.TabIndex = 2;
            txtIdentificacion.TextChanged += txtIdentificacion_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 161);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            label3.Click += label3_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(487, 184);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(171, 27);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            txtContrasena.TextChanged += txtContrasena_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(519, 226);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(94, 29);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // llOlvideContrasena
            // 
            llOlvideContrasena.AutoSize = true;
            llOlvideContrasena.Location = new Point(495, 268);
            llOlvideContrasena.Name = "llOlvideContrasena";
            llOlvideContrasena.Size = new Size(151, 20);
            llOlvideContrasena.TabIndex = 6;
            llOlvideContrasena.TabStop = true;
            llOlvideContrasena.Text = "Olvidé mi Contraseña";
            llOlvideContrasena.LinkClicked += llOlvideContrasena_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(495, 311);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 7;
            label4.Text = "¿No tienes usuario?";
            label4.Click += label4_Click;
            // 
            // llCrearUsuario
            // 
            llCrearUsuario.AutoSize = true;
            llCrearUsuario.Location = new Point(504, 331);
            llCrearUsuario.Name = "llCrearUsuario";
            llCrearUsuario.Size = new Size(119, 20);
            llCrearUsuario.TabIndex = 8;
            llCrearUsuario.TabStop = true;
            llCrearUsuario.Text = "Crear mi Usuario";
            llCrearUsuario.LinkClicked += llCrearUsuario_LinkClicked;
            // 
            // btnVerContrasena
            // 
            btnVerContrasena.FlatStyle = FlatStyle.Flat;
            btnVerContrasena.Location = new Point(663, 183);
            btnVerContrasena.Name = "btnVerContrasena";
            btnVerContrasena.Size = new Size(42, 31);
            btnVerContrasena.TabIndex = 9;
            btnVerContrasena.Text = "👁️";
            btnVerContrasena.UseVisualStyleBackColor = true;
            btnVerContrasena.Click += btnVerContrasena_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1184, 459);
            Controls.Add(btnVerContrasena);
            Controls.Add(llCrearUsuario);
            Controls.Add(label4);
            Controls.Add(llOlvideContrasena);
            Controls.Add(btnIngresar);
            Controls.Add(txtContrasena);
            Controls.Add(label3);
            Controls.Add(txtIdentificacion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIdentificacion;
        private Label label3;
        private TextBox txtContrasena;
        private Button btnIngresar;
        private LinkLabel llOlvideContrasena;
        private Label label4;
        private LinkLabel llCrearUsuario;
        private Button btnVerContrasena;
    }
}