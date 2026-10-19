using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            DataSet ds = datos.Informacion("Select * From datos");

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
    }
}
