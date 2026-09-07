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
        int contador = 0;
        bool bandera = false;
        int minutos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            DateTime tiempo = DateTime.Now;
            lblRelog.Text = tiempo.ToString("HH:mm:ss");
            lblfecha.Text = tiempo.ToString("MM-dd-yyyy");
            contador++;
            if (contador == 60)
            {
                minutos++;
                contador = 0;
            }
            lblEjecucion.Text = "Tiempo de ejecucion " + minutos.ToString()+"minutos llevas en la ventana";
            
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            if (bandera == false)
            {
                bandera= true;
                tmrReloj.Enabled = true;
                btnEncender.Text = "Apagar";
                  
            }
            else
            {
                bandera= false;
                tmrReloj.Enabled = false;
                btnEncender.Text = "Encender";
            }
        }
    }
}
