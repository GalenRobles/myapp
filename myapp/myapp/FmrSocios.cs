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
    public partial class FmrSocios : Form
    {
        ConexionBD ConexionBD;
        public int id;
        public FmrSocios()
        {
            InitializeComponent();
        }

        private void FmrSocios_Load(object sender, EventArgs e)
        {
            ActualizarGrid();

        }
        private void ActualizarGrid()
        {
            ConexionBD = new ConexionBD();

            DataSet ds = ConexionBD.Informacion("Select * From Socios Order by id_socio Asc");

            if (ds != null)
            {

                dtgInformacion.AutoGenerateColumns = false;

                dtgInformacion.Columns[0].DataPropertyName = "id_socio";
                dtgInformacion.Columns[1].DataPropertyName = "nombre";
                dtgInformacion.Columns[2].DataPropertyName = "telefono";
                dtgInformacion.Columns[3].DataPropertyName = "correo";
                dtgInformacion.Columns[4].DataPropertyName = "fecha_registro";


                dtgInformacion.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudo obtener la informacion de la base de datos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroSocios ventana = new RegistroSocios();
            ventana.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void CMS_Opening(object sender, CancelEventArgs e)
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
                  
                    Convert.ToInt32(dtgInformacion.CurrentRow.Cells[0].Value)

                );
                actualizar.Show();


            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro de la tabla primero");
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

                    SqlCommand comando = new SqlCommand("DELETE FROM Socios WHERE id_socio = @id_socio");
                    comando.Parameters.AddWithValue("@id_socio", id);

                    ConexionBD datos = new ConexionBD();
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
                MessageBox.Show("Por favor, selecciona un registro de la tabla primero");
            }
        }

        private void dtgInformacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FmrSocios_Activated(object sender, EventArgs e)
        {
            ActualizarGrid();

        }
    }
}
