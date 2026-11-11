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

            ChlistPelis.DataSource = ds.Tables[0];
            ChlistPelis.DisplayMember = "Nombre";
            ChlistPelis.ValueMember = "IdPelicula";
        }

        private void CargarRentasSocio()
        {
            if (cboSocio.SelectedValue == null || cboSocio.SelectedValue is DataRowView)
            {
                dgvRentasActivas.DataSource = null;
                lblContador.Text = "Películas activas: 0";
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

            lblContador.Text = "Películas activas: " + dt.Rows.Count;
            btnRentar.Enabled = (dt.Rows.Count == 0);
        }

        private void cboSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarRentasSocio();

        }

        private void btnRentar_Click(object sender, EventArgs e)
        {
            if (cboSocio.SelectedValue == null || cboSocio.SelectedValue is DataRowView)
            {
                MessageBox.Show("Selecciona un socio");
                return;
            }
            if (dgvRentasActivas.Rows.Count > 0)
            {
                MessageBox.Show("El socio ya cuenta con una renta activa debe devolver sus peliculas antes de iniciar otra renta");
                return;
            }
            if (ChlistPelis.CheckedItems.Count == 0)
            {
                MessageBox.Show("Selecciona al menos una película para rentar");
                return;
            }

            int idSocio = Convert.ToInt32(cboSocio.SelectedValue);
            DateTime fechaDev = dtpDevolucion.Value.Date;
            int exitosas = 0;

            foreach (DataRowView item in ChlistPelis.CheckedItems)
            {
                int idPelicula = Convert.ToInt32(item["IdPelicula"]);

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Rentas(IdSocio, IdPelicula, FechaRenta, FechaDevolucion) " +
                    "VALUES(@socio, @pelicula, GETDATE(), @devolucion)");

                cmd.Parameters.AddWithValue("@socio", idSocio);
                cmd.Parameters.AddWithValue("@pelicula", idPelicula);
                cmd.Parameters.AddWithValue("@devolucion", fechaDev);

                if (datos.Ejecutar(cmd))
                {
                    exitosas++;
                }
            }

            if (exitosas > 0)
            {
                MessageBox.Show($"Renta registrada con éxito ({exitosas} película(s)).");
                CargarRentasSocio();
                CargarPeliculasDisponibles();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la renta.");
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

        private void ChlistPelis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
