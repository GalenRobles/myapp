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
    public partial class frmPeliculas : Form
    {
        ConexionBD datos = new ConexionBD();

        public frmPeliculas()
        {
            InitializeComponent();
        }

        private void btnPeliculaAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtPeliculaNombre.Text.Trim();
            if (nombre == "")
            {
                MessageBox.Show("Escribe el nombre de la película");
                return;
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO Peliculas(Nombre) VALUES(@nombre)");
            cmd.Parameters.AddWithValue("@nombre", nombre);

            if (datos.Ejecutar(cmd))
            {
                txtPeliculaNombre.Clear();
                txtPeliculaNombre.Focus();
                CargarPeliculas();
            }
            else
            {
                MessageBox.Show("No se pudo agregar la película");
            }
        }

        private void frmPeliculas_Load(object sender, EventArgs e)
        {
            CargarPeliculas();
            dgvPeliculas.AutoGenerateColumns = false;
        }
        private void CargarPeliculas()
        {
            DataSet ds = datos.Informacion("SELECT IdPelicula, Nombre FROM Peliculas ORDER BY Nombre");
            if (ds == null) return;
            dgvPeliculas.DataSource = ds.Tables[0];
        }

        private void btnPeliculaEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPeliculas.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvPeliculas.CurrentRow.Cells["IdPelicula"].Value);

            DataSet ds = datos.Informacion(
                "SELECT COUNT(*) FROM Rentas WHERE IdPelicula = " + id + " AND FechaEntregada IS NULL");
            if (ds == null) return;

            if (Convert.ToInt32(ds.Tables[0].Rows[0][0]) > 0)
            {
                MessageBox.Show("No se puede eliminar: la película está rentada actualmente");
                return;
            }

            if (MessageBox.Show("¿Eliminar esta película y su historial de rentas?", "Confirmar",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            SqlCommand borrarRentas = new SqlCommand("DELETE FROM Rentas WHERE IdPelicula = @id");
            borrarRentas.Parameters.AddWithValue("@id", id);

            SqlCommand borrarPelicula = new SqlCommand("DELETE FROM Peliculas WHERE IdPelicula = @id");
            borrarPelicula.Parameters.AddWithValue("@id", id);

            if (datos.Ejecutar(borrarRentas) && datos.Ejecutar(borrarPelicula))
                CargarPeliculas();
            else
                MessageBox.Show("No se pudo eliminar la película");
        }
    }
    
}
