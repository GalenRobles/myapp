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
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnProceso_Click(object sender, EventArgs e)
        {
           // string nombre=txtbox.Text;
            //MessageBox.Show(nombre);
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int a, b = 0;
            a = int.Parse(txtNumero1.Text);
            b = Convert.ToInt32(txtNumero2.Text);
            MessageBox.Show("la suma es :" + (a + b).ToString());
            txtNumero3.Text = (a + b).ToString();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
           txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero3.Clear();
        }
    }
}
