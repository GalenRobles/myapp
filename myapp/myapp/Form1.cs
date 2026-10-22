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
            uta = ofd.FileName;
            var reader = new StreamReader(ruta);
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            registros = csv.GetRecords<Estado>().ToList();

            dtg.Rows.Clear(); // Limpiar el DataGridView antes de cargar nuevos

            // Preparar el DataTable para enviarlo a la clase Datos
            DataTable dtData = new DataTable();
            dtData.Columns.Add("Id", typeof(int));
            dtData.Columns.Add("Nombre", typeof(string));

            foreach (var registro in registros)
            {
                // Llenar el DataGridView visual (solo 2 columnas ahora)
                dtg.Rows.Add(registro.Id, registro.Nombre);

                // Llenar el DataTable en memoria
                dtData.Rows.Add(registro.Id, registro.Nombre);
            }

            // Mandar a llamar a tu clase Datos para insertar
            Datos db = new Datos();
            bool exito = db.InsertarMasivo(dtData, "Estados"); // Aquí indicas la tabla destino

            if (exito)
            {
                MessageBox.Show("Archivo CSV cargado en pantalla y guardado en SQL Server.");
            }
            else
            {
                MessageBox.Show("Hubo un error al guardar en la base de datos.");
            }

            csv.Dispose();
            reader.Close();
        }
        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
