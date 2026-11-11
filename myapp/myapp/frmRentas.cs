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
    public partial class frmRentas : Form
    {
        ConexionBD datos = new ConexionBD();
        const int MAX_RENTAS = 3;
        public frmRentas()
        {
            InitializeComponent();
        }

        private void frmRentas_Load(object sender, EventArgs e)
        {
            dgvRentasActivas.AutoGenerateColumns = false;

            dtpDevolucion.Format = DateTimePickerFormat.Short;
            dtpDevolucion.MinDate = DateTime.Today;
            dtpDevolucion.Value = DateTime.Today.AddDays(3);

            CargarSocios();
            CargarPeliculasDisponibles();
            CargarRentasSocio();
        }
        private void CargarSocios()
        {
            DataSet ds = datos.Informacion("SELECT IdSocio, Nombre FROM Socios ORDER BY Nombre");
            if (ds == null) return;
            cboSocio.DisplayMember = "Nombre";
            cboSocio.ValueMember = "IdSocio";
            cboSocio.DataSource = ds.Tables[0];
        }

        private void CargarPeliculasDisponibles()
        {
            DataSet ds = datos.Informacion(
                "SELECT IdPelicula, Nombre FROM Peliculas " +
                "WHERE IdPelicula NOT IN (SELECT IdPelicula FROM Rentas WHERE FechaEntregada IS NULL) " +
                "ORDER BY Nombre");
            if (ds == null) return;
            cboPelicula.DisplayMember = "Nombre";
            cboPelicula.ValueMember = "IdPelicula";
            cboPelicula.DataSource = ds.Tables[0];
        }

        // Llena el grid con lo que el socio tiene prestado y actualiza contador/botón
        private void CargarRentasSocio()
        {
            if (cboSocio.SelectedValue == null || cboSocio.SelectedValue is DataRowView)
            {
                dgvRentasActivas.DataSource = null;
                lblContador.Text = "Prestadas: 0/" + MAX_RENTAS;
                btnRentar.Enabled = false;
                return;
            }

            int idSocio = Convert.ToInt32(cboSocio.SelectedValue);
            DataSet ds = datos.Informacion(
                "SELECT r.IdRenta, p.Nombre AS Pelicula, r.FechaRenta, r.FechaDevolucion " +
                "FROM Rentas r INNER JOIN Peliculas p ON p.IdPelicula = r.IdPelicula " +
                "WHERE r.IdSocio = " + idSocio + " AND r.FechaEntregada IS NULL " +
                "ORDER BY r.FechaDevolucion");
            if (ds == null) return;

            DataTable dt = ds.Tables[0];
            dgvRentasActivas.DataSource = dt;
           

            lblContador.Text = "Prestadas: " + dt.Rows.Count + "/" + MAX_RENTAS;
            btnRentar.Enabled = dt.Rows.Count < MAX_RENTAS;
        }

        private void cboSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarRentasSocio();

        }

        private void btnRentar_Click(object sender, EventArgs e)
        {
            if (cboSocio.SelectedValue == null || cboPelicula.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un socio y una pelicula");
                return;
            }

            if (dgvRentasActivas.Rows.Count >= MAX_RENTAS)
            {
                MessageBox.Show("Este socio ya tiene " + MAX_RENTAS + " peliculas.Debe devolver alguna");
                return;
            }

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Rentas(IdSocio, IdPelicula, FechaDevolucion) " +
                "VALUES(@socio, @pelicula, @devolucion)");
            cmd.Parameters.AddWithValue("@socio", Convert.ToInt32(cboSocio.SelectedValue));
            cmd.Parameters.AddWithValue("@pelicula", Convert.ToInt32(cboPelicula.SelectedValue));
            cmd.Parameters.AddWithValue("@devolucion", dtpDevolucion.Value.Date);

            if (datos.Ejecutar(cmd))
            {
                CargarRentasSocio();
                CargarPeliculasDisponibles();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la renta");
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (dgvRentasActivas.CurrentRow == null)
            {
                MessageBox.Show("Selecciona la pelicula que se devuelve");
                return;
            }

            int idRenta = Convert.ToInt32(dgvRentasActivas.CurrentRow.Cells["IdRenta"].Value);
            SqlCommand cmd = new SqlCommand(
                "UPDATE Rentas SET FechaEntregada = GETDATE() WHERE IdRenta = @id");
            cmd.Parameters.AddWithValue("@id", idRenta);

            if (datos.Ejecutar(cmd))
            {
                CargarRentasSocio();
                CargarPeliculasDisponibles();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la devolucion");
            }
        }
    }
    
}
