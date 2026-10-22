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
    public partial class frmRegistro : Form
    {
        Datos datos;
        bool updateMode=false;
         int id;
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            datos = new Datos();
            if (updateMode == false)
            {
                bool f = datos.ejecutar("Insert Into Datos(nombre,paterno,materno," +
                "telefono,correo)Values('"
                + txtNom.Text + "','" + txtPate.Text + "','" + txtMate.Text
                + "','" + maskTel.Text + "','" + txtcorreo.Text + "')");
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
                SqlCommand comando = new SqlCommand("Update Datos Set nombre=@nombre," +
                    "paterno=@paterno,materno=@materno,telefono=@telefono," +
                    "correo=@correo Where id=@id");
                comando.Parameters.AddWithValue("@nombre", txtNom.Text);
                comando.Parameters.AddWithValue("@paterno", txtPate.Text);
                comando.Parameters.AddWithValue("@materno", txtMate.Text);
                comando.Parameters.AddWithValue("@telefono", maskTel.Text);
                comando.Parameters.AddWithValue("@correo", txtcorreo.Text);
                comando.Parameters.AddWithValue("@id", id);
                bool f = datos.Ejecutar(comando);
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

        
        public frmRegistro(string nombre, string paterno,string materno,string telefono,string correo,int id)
        {
            InitializeComponent();
            txtNom.Text = nombre;
            txtPate.Text = paterno;
            txtMate.Text = materno;
            txtcorreo.Text = correo;
            maskTel.Text = telefono;
            btnAgregar.Text = "Actualiza";
            updateMode = true;
            this.id = id;

        }
      

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
