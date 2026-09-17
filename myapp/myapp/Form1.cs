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
    public partial class Form1 : Form

    {
        List<Persona> personas= new List<Persona>();
        public Form1()
        {
            InitializeComponent();
            personas.Add(new Persona(1,"Luis mota","871379293"));
            personas.Add(new Persona(2, "picazo", "87182881"));
            personas.Add(new Persona(3, "frifri", "8171881821"));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Persona persona in personas)
            {
               // dtgInformacion.Rows.Add(persona.Id, persona.nombre, persona.telefono);
                dtgInformacion.Rows.Add();
                dtgInformacion[0, dtgInformacion.Rows.Count - 1].Value =persona.Id;
                dtgInformacion[1, dtgInformacion.Rows.Count - 1].Value = persona.nombre;
                dtgInformacion[2, dtgInformacion.Rows.Count - 1].Value = persona.telefono;
            }
            //dtgInformacion.DataSource = personas;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dtgInformacion.Rows.Add();
            dtgInformacion[0, dtgInformacion.Rows.Count - 1].Value = dtgInformacion.Rows.Count;
            dtgInformacion[1, dtgInformacion.Rows.Count - 1].Value = txtNom.Text;
            dtgInformacion[2, dtgInformacion.Rows.Count - 1].Value = txtTel.Text;
        }

    }
    }
}
