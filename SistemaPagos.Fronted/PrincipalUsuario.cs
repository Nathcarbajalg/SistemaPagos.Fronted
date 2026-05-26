using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaPagos.Fronted
{
    public partial class PrincipalUsuario : Form
    {
        public PrincipalUsuario()
        {
            InitializeComponent();
        }
        public PrincipalUsuario(string nombre, DateTime expiracion) : this()
        {
            // vacío por ahora
        }
        private void PrincipalUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || !decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("Complete descripción y un monto válido.");
                return;
            }

            // Agregar fila al DataGridView (simulado)
            dgvHistorial.Rows.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), txtDescripcion.Text, monto.ToString("N2"));

            // Actualizar total
            decimal total = 0;
            foreach (DataGridViewRow row in dgvHistorial.Rows)
                if (row.Cells[2].Value != null)
                    total += Convert.ToDecimal(row.Cells[2].Value);
            lblTotalGeneral.Text = $"Total general: Q {total:N2}";

            txtDescripcion.Clear();
            txtMonto.Clear();

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timerSesion.Stop();
            this.Close(); // Cierra la ventana principal
                          // Aquí después mostraremos el login nuevamente

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void lblTiempoRestante_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timerSesion_Tick(object sender, EventArgs e)
        {

        }
    }
}
