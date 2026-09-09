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
        bool save = false;
        int contador = 0;
        bool escribio = false;
        string path;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofpAbrir.ShowDialog() == DialogResult.OK)
            {
                path = ofpAbrir.FileName;
                save = true;
                rctTexto.LoadFile(ofpAbrir.FileName, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem.Enabled = false;
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (save == false)
            {
                if(sfdGuardar.ShowDialog() == DialogResult.OK)
                {
                    path = sfdGuardar.FileName;
                    save = true;   
                }
            }
            if (save == true)
            {
                contador = 0;
                escribio= false;
                tiempoGuardar.Enabled = false;
                rctTexto.SaveFile(path, RichTextBoxStreamType.PlainText);
            }

        }

        private void rctTexto_TextChanged(object sender, EventArgs e)
        {
            if (escribio == false)
            {
                contador = 0;
            }
            escribio = true;
            guardarToolStripMenuItem.Enabled = true;
            tiempoGuardar.Enabled = true;

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdGuardar.ShowDialog() == DialogResult.OK)
            {
                path = sfdGuardar.FileName;
                rctTexto.SaveFile(path, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem.Enabled = true;
                contador = 0;
                escribio = false;
                tiempoGuardar.Enabled = false;
                save = true;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctTexto.Clear();
            rctTexto.Focus();
            path = "";
            save= false;
            escribio = false;
            contador=0;
            tiempoGuardar.Enabled= false;
            
            //guardarToolStripMenuItem.Enabled=true;
        }

        private void tiempoGuardar_Tick(object sender, EventArgs e)
        {
            DateTime tiempo = DateTime.Now;
            if (save == true)
            {
                if (escribio == true)
                {
                    contador++;
                    if (contador == 30)
                    {
                        contador = 0;
                        rctTexto.SaveFile(path, RichTextBoxStreamType.PlainText);
                        escribio= false;
                        tiempoGuardar.Enabled=false;
                        MessageBox.Show("Se guardo en automatico tu nota");

                    }
                }
   

            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}

