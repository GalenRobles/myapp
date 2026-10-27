using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.Globalization;
using System.IO;

namespace myapp
{
    public partial class Form1 : Form
    {
        List<Estado> registros = new List<Estado>();
        String ruta = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ruta = ofd.FileName;
                var reader = new StreamReader(ruta);
                var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

                registros = csv.GetRecords<Estado>().ToList();

                dtg.Rows.Clear(); 

                
                DataTable dtData = new DataTable();
                dtData.Columns.Add("Id", typeof(int));
                dtData.Columns.Add("Nombre", typeof(string));

                foreach (var registro in registros)
                {
                    
                    dtg.Rows.Add(registro.Id, registro.Nombre);

                    
                    dtData.Rows.Add(registro.Id, registro.Nombre);
                }

                ConexionDB db = new ConexionDB();
                bool exito = db.InsertarMasivo(dtData, "Estados");

                if (exito)
                {
                    MessageBox.Show("Archivo CSV cargado en pantalla y guardado en SQL Server");
                }
                else
                {
                    MessageBox.Show("Hubo un error al guardar en la base de datos");
                }

                csv.Dispose();
                reader.Close();
            }
        }
        

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCargarMunicipios_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string ruta = ofd.FileName;

                var config = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = false
                };

                var reader = new StreamReader(ruta);
                var csv = new CsvReader(reader, config);

                List<Municipio> registros = csv.GetRecords<Municipio>().ToList();

                dtg.Rows.Clear();

                DataTable dtData = new DataTable();
                dtData.Columns.Add("Id", typeof(int));
                dtData.Columns.Add("Nombre", typeof(string));
                dtData.Columns.Add("IdEstado", typeof(int));

                int idContador = 1;

                foreach (var registro in registros)
                {
                    dtg.Rows.Add(idContador, registro.Nombre, registro.IdEstado);
                    dtData.Rows.Add(idContador, registro.Nombre, registro.IdEstado);

                    idContador++; 
                }

                ConexionDB db = new ConexionDB();
                bool exito = db.InsertarMasivo(dtData, "Municipios");

                if (exito)
                {
                    MessageBox.Show("Archivo CSV cargado y municipios guardados en SQL Server");
                }
                else
                {
                    MessageBox.Show("Hubo un error al guardar en la base de datos");
                }

                csv.Dispose();
                reader.Close();
            }
        }
    }
}
