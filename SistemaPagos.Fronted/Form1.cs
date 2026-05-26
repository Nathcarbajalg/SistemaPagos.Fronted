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
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
            {
                MessageBox.Show("Ingrese su número de identificación.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentificacion.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Ingrese su contraseña.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return;
            }

            // Por ahora, simulamos un login exitoso (sin llamar a la API)
            // En la versión final, aquí iría la llamada a /api/auth/login

            // Simulación: si la identificación es "admin" y contraseña "123", entra como admin; si no, como usuario normal
            if (txtIdentificacion.Text == "admin" && txtContrasena.Text == "123")
            {
                // Abrir pantalla de administrador
                PrincipalAdmin frmAdmin = new PrincipalAdmin();
                frmAdmin.Show();
                this.Hide(); // ocultar el login
            }
            else
            {
                // Abrir pantalla de usuario normal
                PrincipalUsuario frmUser = new PrincipalUsuario();
                frmUser.Show();
                this.Hide();
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
    }
}