using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace myapp
{
    public partial class Form1 : Form
    {
        DateTime tiempo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToLongTimeString();
            if (DateTime.Now.ToLongTimeString() == tiempo.ToLongTimeString())
            {
                //Console.Beep(1000, 200);
                axWindowsMediaPlayer1.URL = @"C:\Users\loren\Downloads\gallo.mp3";
                axWindowsMediaPlayer1.Ctlcontrols.play();

                MessageBox.Show("Alarma sonando");
            }

        }

        private void configurarAlarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrConfigurar ventanaAlarma = new FmrConfigurar();
            if (ventanaAlarma.ShowDialog() == DialogResult.OK) 
                {
                tiempo = ventanaAlarma.hora;
                MessageBox.Show(tiempo.ToLongTimeString());
                }
            }
        }
    }
