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
    public partial class frmRegistro : Form
    {
        Datos datos;
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            datos= new Datos();
            bool f= datos.Insertar(txtNom.Text, txtPate.Text, txtMate.Text, maskTel.Text, txtcorreo.Text);


            if (f == true)
            {
                MessageBox.Show("Registros agregado correctamente ");
                this.Close();
            }
        }
    }
}
