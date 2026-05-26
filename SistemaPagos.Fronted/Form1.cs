using SistemaPagos.Fronted.Models;
using System.Drawing;
namespace SistemaPagos.Fronted
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            {
                // Fondo del formulario
                this.BackColor = Color.FromArgb(230, 220, 255);

                // Labels
                label1.ForeColor = Color.FromArgb(90, 44, 120);
                label2.ForeColor = Color.FromArgb(90, 44, 120);

                // Links
                llOlvideContrasena.LinkColor = Color.MediumPurple;
                llCrearUsuario.LinkColor = Color.MediumPurple;

                // Caja de texto
                txtIdentificacion.BackColor = Color.White;
                txtContrasena.BackColor = Color.White;
            }
        }


        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void llCrearUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUsuario frm = new RegistroUsuario();
            frm.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void AbrirPrincipal(string rol, string nombre, DateTime expiracion)
        {
            if (rol == "Admin")
            {
                PrincipalAdmin admin = new PrincipalAdmin(nombre, expiracion);
                admin.Show();
            }
            else
            {
                PrincipalUsuario user = new PrincipalUsuario(nombre, expiracion);
                user.Show();
            }
            this.Hide();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text.Trim();
            string contrasena = txtContrasena.Text;

            if (string.IsNullOrEmpty(identificacion) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            using (var context = new AppDbContext())
            {
                var usuario = context.Usuarios.FirstOrDefault(u => u.Identificacion == identificacion);
                if (usuario == null || usuario.Contrasena != contrasena)
                {
                    MessageBox.Show("Identificación o contraseña incorrectos.");
                    return;
                }

                // Login exitoso
                DateTime expiracion = DateTime.Now.AddHours(1);
                SesionHelper.GuardarSesion(usuario.Identificacion, usuario.Rol, $"{usuario.Nombre} {usuario.Apellido}", expiracion);
                AbrirPrincipal(usuario.Rol, $"{usuario.Nombre} {usuario.Apellido}", expiracion);
            }

        }

        private void llOlvideContrasena_LinkClicked(object sender, EventArgs e)
        {
            RecuperarPassword frm = new RecuperarPassword();
            frm.ShowDialog(); // Ventana modal
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

      
private void btnVerContrasena_Click(object sender, EventArgs e)
        {
            // Cambiar el modo de caracteres de contraseña
            if (txtContrasena.UseSystemPasswordChar)
            {
                txtContrasena.UseSystemPasswordChar = false;
                btnVerContrasena.Text = "🙈"; // Ojo cerrado (ocultando)
            }
            else
            {
                txtContrasena.UseSystemPasswordChar = true;
                btnVerContrasena.Text = "👁️"; // Ojo abierto (mostrando)
            }
        }
    }
    }
