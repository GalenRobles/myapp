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
    public partial class FrmInformacion : Form
    {
        Datos datos;
        public int id;
        public FrmInformacion()
        {
            InitializeComponent();
        }

        private void FrmInformacion_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
        private void ActualizarGrid()
        {
            datos = new Datos();

            DataSet ds = datos.Informacion("Select * From datos Order by id Asc");

            if (ds != null)
            {

                dtgInformacion.AutoGenerateColumns = false;

                dtgInformacion.Columns[0].DataPropertyName = "Id";
                dtgInformacion.Columns[1].DataPropertyName = "Nombre";
                dtgInformacion.Columns[2].DataPropertyName = "Paterno";
                dtgInformacion.Columns[3].DataPropertyName = "Materno";
                dtgInformacion.Columns[4].DataPropertyName = "Telefono";
                dtgInformacion.Columns[5].DataPropertyName = "Correo";

                dtgInformacion.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudo obtener la informacion de la base de datos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistro ventana = new frmRegistro();
            ventana.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgInformacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FrmInformacion_Activated(object sender, EventArgs e)
        {
           ActualizarGrid();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dtgInformacion.CurrentRow != null)
            {
                frmRegistro actualizar = new frmRegistro(
                    dtgInformacion.CurrentRow.Cells[1].Value.ToString(),
                    dtgInformacion.CurrentRow.Cells[2].Value.ToString(),
                    dtgInformacion.CurrentRow.Cells[3].Value.ToString(),
                    dtgInformacion.CurrentRow.Cells[4].Value.ToString(),
                    dtgInformacion.CurrentRow.Cells[5].Value.ToString(),
                    Convert.ToInt32(dtgInformacion.CurrentRow.Cells[0].Value)
                );
                actualizar.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro de la tabla primero.");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dtgInformacion.CurrentRow != null)
            {
                int id = Convert.ToInt32(dtgInformacion.CurrentRow.Cells[0].Value);
                DialogResult respuesta = MessageBox.Show("¿Estas seguro de que deseas eliminar este registro?",
                                                         "Confirmar eliminacion",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {

                    SqlCommand comando = new SqlCommand("DELETE FROM Datos WHERE Id = @Id");
                    comando.Parameters.AddWithValue("@Id", id);

                    Datos datos = new Datos();
                    bool borrado = datos.Ejecutar(comando);

                    if (borrado)
                    {
                        MessageBox.Show("Registro Eliminado");
                        ActualizarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al intentar eliminar el registro");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro de la tabla primero.");
            }
        }

        private void dtgInformacion_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
