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
        public Ventana2()
        {
            InitializeComponent();
            lblResultado.Text = "";
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            float total = 0;
            string pasarela = "";
            int conProd = 0;
            int conPas = 0;
            if (lisProductos.Text == "Tenis") {
                total = total + 1000;
                conProd++;
            }
            if (lisProductos.Text == "Camisas") {
                total = total + 500;
                conProd++;
            }
            if (comPasarelas.Text == "Tarjeta") {
                pasarela = "Pago con Tarjeta ";
                conPas++;
            }
            if (comPasarelas.Text == "Paypal") {
                pasarela = "Pago con Paypal ";
                conPas++;
            }
            if (conProd > 0 && conPas > 0)
            {
                lblResultado.Text = pasarela + total;
            }
            else {
                lblResultado.Text = "Humano selecciona un producto y una pasarela";
            }
        }

        private void btnRegresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formulario1 f1 = new Formulario1();
            f1.Show();
        }

        private void lisProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgProductos.ImageLocation= "C:/Users/eugenio/Pictures/C#/"+ lisProductos.Text+".png";
        }

        private void comPasarelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgPasarelas.ImageLocation = "C:/Users/eugenio/Pictures/C#/" + comPasarelas.Text + ".png";
        }
    }
}
