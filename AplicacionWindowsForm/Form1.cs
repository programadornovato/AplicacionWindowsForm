using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionWindowsForm
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "programadornovato" && txtPass.Text == "123")
            {
                //MessageBox.Show("Humano valido");
                Ventana2 v2 = new Ventana2();
                v2.Show();
                this.Hide();
            }
            else {
                txtUsuario.Text = "programadornovato";
                txtPass.Text = "123";
                MessageBox.Show("Humano invalido");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
