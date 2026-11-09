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
    public partial class RegistroSocios : Form
    {
        ConexionBD conexionBD;
        bool updateMode = false;
        int id;
        public RegistroSocios()
        {
            InitializeComponent();
        }

        private void RegistroSocios_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexionBD = new ConexionBD();

            if (!DateTime.TryParseExact(maskedTextBox1.Text.Trim(), "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out DateTime fechaParsed))
            {
                MessageBox.Show("Ingresa una fecha válida con formato dd/mm/aaaa.", "Fecha incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBox1.Focus();
                return;
            }

            if (updateMode == false)
            {
                SqlCommand comando = new SqlCommand(
                    "INSERT INTO Socios (nombre, telefono, correo, fecha_registro) " +
                    "VALUES (@nombre, @telefono, @correo, @fecha_registro)"
                );

                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNom.Text.Trim();
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = txtTele.Text.Trim();
                comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = txtCorreo.Text.Trim();

                // Asignar como fecha nativa
                comando.Parameters.Add("@fecha_registro", SqlDbType.Date).Value = fechaParsed;

                bool f = conexionBD.Ejecutar(comando);
                if (f)
                {
                    MessageBox.Show("Registro agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el registro");
                }
            }
            else
            {
                SqlCommand comando = new SqlCommand(
                    "UPDATE Socios SET nombre = @nombre, telefono = @telefono, correo = @correo, fecha_registro = @fecha_registro " +
                    "WHERE id = @id"
                );

                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNom.Text.Trim();
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = txtTele.Text.Trim();
                comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = txtCorreo.Text.Trim();

                comando.Parameters.Add("@fecha_registro", SqlDbType.Date).Value = fechaParsed;
                comando.Parameters.Add("@id", SqlDbType.Int).Value = id;

                bool f = conexionBD.Ejecutar(comando);
                if (f)
                {
                    MessageBox.Show("Registro actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro");
                }
            }
            }
        public RegistroSocios(string nombre, string telefono, string correo, string fecha_registro, int id)
        {
            InitializeComponent();
            txtNom.Text = nombre;
            txtTele.Text = telefono;
            txtCorreo.Text = correo;
            maskedTextBox1.Text = fecha_registro;
            btnAgregar.Text = "Actualiza";
            updateMode = true;
            this.id = id;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } }

