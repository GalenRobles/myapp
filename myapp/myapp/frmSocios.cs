using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myapp
{
    public partial class frmSocios : Form
    {
        ConexionBD datos = new ConexionBD();
        public frmSocios()
        {
            InitializeComponent();
        }

        private void btnSocioAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtSocioNombre.Text.Trim();
            if (nombre == "")
            {
                MessageBox.Show("escribe el nombre del socio");
                return;
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO Socios(Nombre) VALUES(@nombre)");
            cmd.Parameters.AddWithValue("@nombre", nombre);

            if (datos.Ejecutar(cmd))
            {
                txtSocioNombre.Clear();
                txtSocioNombre.Focus();
                CargarSocios();
            }
            else
            {
                MessageBox.Show("No se pudo agregar el socio");
            }
        }

        private void frmSocios_Load(object sender, EventArgs e)
        {
            dgvSocios.ReadOnly = true;
            dgvSocios.AutoGenerateColumns = false;
            CargarSocios();
        }
        private void CargarSocios()
        {
            DataSet ds = datos.Informacion("SELECT IdSocio, Nombre FROM Socios ORDER BY Nombre");
            if (ds == null) return;
            dgvSocios.DataSource = ds.Tables[0];
        }

        private void btnSocioEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSocios.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvSocios.CurrentRow.Cells["IdSocio"].Value);

            DataSet ds = datos.Informacion(
                "SELECT COUNT(*) FROM Rentas WHERE IdSocio = " + id + " AND FechaEntregada IS NULL");
            if (ds == null) return;

            int pendientes = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            if (pendientes > 0)
            {
                MessageBox.Show("No se puede eliminar: el socio tiene " + pendientes +
                                " película(s) sin devolver");
                return;
            }

            if (MessageBox.Show("¿Eliminar este socio y su historial de rentas?", "Confirmar",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            SqlCommand borrarRentas = new SqlCommand("DELETE FROM Rentas WHERE IdSocio = @id");
            borrarRentas.Parameters.AddWithValue("@id", id);

            SqlCommand borrarSocio = new SqlCommand("DELETE FROM Socios WHERE IdSocio = @id");
            borrarSocio.Parameters.AddWithValue("@id", id);

            if (datos.Ejecutar(borrarRentas) && datos.Ejecutar(borrarSocio))
                CargarSocios();
            else
                MessageBox.Show("No se pudo eliminar el socio");
        }

    }
}
