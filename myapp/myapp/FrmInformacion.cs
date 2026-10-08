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
            datos= new Datos();
            DataSet ds = datos.Informacion("SELECT * FROM datos");
            if (ds!=null)
            {
                dtgInformacion.DataSource=ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar informacion", "sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistro ventana = new frmRegistro();
            ventana.Show();
        }
    }
}
