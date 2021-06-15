using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AplicacionWindowsForm
{
    public partial class Ventana2 : Form
    {
        int con = 0;
        public Ventana2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pbCarga.Minimum = 0;
            pbCarga.Maximum = 100;
            if (con < 100)
            {
                con++;
            }
            pbCarga.Value = con;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lblPosicion.Text = "X="+e.X+" Y="+e.Y;
            pbCarga.Minimum = 0;
            pbCarga.Maximum = 100;
            if (con < 100) {
                con++;
            }
            pbCarga.Value = con;
        }
    }
}
