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
        bool updateMode = false;
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
                bool f = datos.ejecutar("Insert Into Datos(nombre,paterno,materno,telefono,correo,idEstado,idMunicipio) Values('"
                + txtNom.Text + "','" + txtPate.Text + "','" + txtMate.Text
                + "','" + maskTel.Text + "','" + txtcorreo.Text + "',"
                + CmbEstado.SelectedValue + "," + CmbMunic.SelectedValue + ")");
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
                    "correo=@correo,IdEstado=@IdEstado,IdMunicipio=@IdMunicipio Where id=@id");
                comando.Parameters.AddWithValue("@nombre", txtNom.Text);
                comando.Parameters.AddWithValue("@paterno", txtPate.Text);
                comando.Parameters.AddWithValue("@materno", txtMate.Text);
                comando.Parameters.AddWithValue("@telefono", maskTel.Text);
                comando.Parameters.AddWithValue("@correo", txtcorreo.Text);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@IdEstado", CmbEstado.SelectedValue);
                comando.Parameters.AddWithValue("@IdMunicipio", CmbMunic.SelectedValue);
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


        public frmRegistro(string nombre, string paterno, string materno, string telefono, string correo, int id)
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
            datos = new Datos();
            DataSet dsEstado;
            DataSet dsMuni;

            dsEstado = datos.Informacion("Select * from Estados");
            if (dsEstado != null && dsEstado.Tables.Count > 0)
            {
               
                CmbEstado.DisplayMember = "Nombre";
                CmbEstado.ValueMember = "Id";
                CmbEstado.DataSource = dsEstado.Tables[0];

            }
        }

        private void CmbMunic_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                CambioMunicipio(Convert.ToInt32(CmbEstado.SelectedValue));
         
        }
        private void CambioMunicipio(int idEstado)
        {
            datos = new Datos();
            DataSet dsMuni;

            dsMuni = datos.Informacion("Select * from Municipios where IdEstado =" + idEstado);
            if (dsMuni != null && dsMuni.Tables.Count > 0)
            {
                
                CmbMunic.DisplayMember = "Nombre";
                CmbMunic.ValueMember = "Id";
                CmbMunic.DataSource = dsMuni.Tables[0];

            }
        }
    }
}
