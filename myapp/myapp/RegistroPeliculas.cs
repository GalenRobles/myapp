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
        ConexionBD datos;
        bool updateMode = false;
        int id;
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            datos = new ConexionBD();
            if (updateMode == false)
            {
                bool f = datos.ejecutar("INSERT INTO peliculas(titulo, genero, copias_disponibles) VALUES('"
            + txtTitulo.Text + "', '"
            + txtGenero.Text + "', "
             + TxtCantidad.Text + ")");
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
                SqlCommand comando = new SqlCommand("Update Datos Set titulo=@titulo," +
                    "genero=@genero,copias_disponibles=@copias_disponibles Where id_peliculas=@id_peliculas");
                comando.Parameters.AddWithValue("@titulo", txtTitulo.Text);
                comando.Parameters.AddWithValue("@genero", txtGenero.Text);
                comando.Parameters.AddWithValue("@copias_disponibles", TxtCantidad.Text);
                comando.Parameters.AddWithValue("@id_peliculas", id);
               
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


        public frmRegistro(string titulo, string genero, string copias_disponibles, int id)
        {
            InitializeComponent();
            txtTitulo.Text = titulo;
            txtGenero.Text = genero;
            TxtCantidad.Text = copias_disponibles;
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

        private void CmbMunic_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
           
         
        }
        
    }
}
