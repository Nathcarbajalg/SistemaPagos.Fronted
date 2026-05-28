using SistemaPagos.Fronted.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;
namespace SistemaPagos.Fronted
#nullable disable
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void TxtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números y teclas de control (backspace, delete, etc.)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en la identificación.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            // 1. VALIDAR CAMPOS OBLIGATORIOS
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese su nombre.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text)) // Apellido
            {
                MessageBox.Show("Por favor, ingrese su apellido.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
            {
                MessageBox.Show("Por favor, ingrese su número de identificación (12 dígitos).", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentificacion.Focus();
                return;
            }

            if (txtIdentificacion.Text.Length != 12)
            {
                MessageBox.Show("La identificación debe tener exactamente 12 dígitos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentificacion.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Por favor, ingrese una contraseña.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return;
            }

            if (txtContrasena.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Contraseña débil",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return;
            }

            if (txtContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmarContrasena.Focus();
                return;
            }

            // Validar edad mínima 18 años
            int edad = CalcularEdad(dateTimePicker1.Value);
            if (edad < 18)
            {
                MessageBox.Show("Debe ser mayor de 18 años para registrarse.", "Edad mínima no cumplida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker1.Focus();
                return;
            }

            // 2. CREAR OBJETO USUARIO
            var nuevoUsuario = new Usuario
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = textBox1.Text.Trim(),
                Identificacion = txtIdentificacion.Text.Trim(),
                FechaNacimiento = dateTimePicker1.Value,
                Contrasena = EncriptarContrasena(txtContrasena.Text), // Encriptar contraseña
                Rol = "Usuario", // Por defecto, todos los nuevos usuarios son "Usuario"
                FechaRegistro = DateTime.Now
            };

            // 3. GUARDAR EN BASE DE DATOS
            // Deshabilitar botón mientras se procesa
            btnCrearUsuario.Enabled = false;
            btnCrearUsuario.Text = "Registrando...";

            try
            {
                using (var context = new AppDbContext())
                {
                    // Verificar si la identificación ya existe
                    bool existeUsuario = await context.Usuarios
                        .AnyAsync(u => u.Identificacion == nuevoUsuario.Identificacion);

                    if (existeUsuario)
                    {
                        MessageBox.Show("Ya existe un usuario registrado con esta identificación.\nPor favor, verifique sus datos.",
                            "Usuario duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Guardar en la base de datos
                    context.Usuarios.Add(nuevoUsuario);
                    int registrosAfectados = await context.SaveChangesAsync();

                    if (registrosAfectados > 0)
                    {
                        // 4. MOSTRAR MENSAJE DE ÉXITO
                        MessageBox.Show(
                            $"¡USUARIO CREADO EXITOSAMENTE!\n\n" +
                            $"Datos registrados:\n" +
                            $"• Nombre: {nuevoUsuario.Nombre} {nuevoUsuario.Apellido}\n" +
                            $"• Identificación: {nuevoUsuario.Identificacion}\n" +
                            $"• Rol: {nuevoUsuario.Rol}\n" +
                            $"• Fecha de registro: {nuevoUsuario.FechaRegistro:dd/MM/yyyy HH:mm}\n\n" +
                            $"Ya puede iniciar sesión con sus credenciales.",
                            "Registro Completado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // Limpiar campos después del registro exitoso
                        LimpiarCampos();

                        // Preguntar si desea ir al login
                        DialogResult resultado = MessageBox.Show(
                            "¿Desea ir a la pantalla de inicio de sesión ahora?",
                            "Redireccionar",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el usuario. Intente nuevamente.",
                            "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                // Error específico de base de datos
                string errorMessage = dbEx.InnerException?.Message ?? dbEx.Message;
                MessageBox.Show($"Error de base de datos:\n{errorMessage}\n\n" +
                    "Verifique que la base de datos esté disponible y la conexión sea correcta.",
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Error general
                MessageBox.Show($"Error al registrar el usuario:\n{ex.Message}\n\n" +
                    "Detalle técnico: " + ex.InnerException?.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Restaurar botón
                btnCrearUsuario.Enabled = true;
                btnCrearUsuario.Text = "Crear Usuario";
            }
        }

        // Método para calcular la edad exacta
        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime hoy = DateTime.Now;
            int edad = hoy.Year - fechaNacimiento.Year;
            if (fechaNacimiento > hoy.AddYears(-edad))
                edad--;
            return edad;
        }

        // Método para encriptar la contraseña (usando BCrypt)
        private string EncriptarContrasena(string contrasena)
        {
            // Necesitas instalar el paquete: Install-Package BCrypt.Net-Next
            // Si no quieres usar BCrypt, usa este método simple (menos seguro):
            // return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(contrasena));

            // Método recomendado con BCrypt:
            return BCrypt.Net.BCrypt.HashPassword(contrasena);
        }

        // Método para limpiar todos los campos
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            textBox1.Clear();
            txtIdentificacion.Clear();
            txtContrasena.Clear();
            txtConfirmarContrasena.Clear();
            dateTimePicker1.Value = DateTime.Now.AddYears(-18);
            txtNombre.Focus();
        }

        // Evento para el LinkLabel Volver al Login
        private void llVolverLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        // Eventos existentes (puedes dejarlos vacíos o eliminarlos si no los usas)
        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            // Configuración inicial ya está en ConfigurarControles()
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void txtConfirmarContrasena_TextChanged(object sender, EventArgs e) { }
    }
}