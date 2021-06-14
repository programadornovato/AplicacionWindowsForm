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
            int conCheck = 0;
            int conRad = 0;
            if (chkTenis.Checked == true) {
                total = total + 1000;
                conCheck++;
            }
            if (chkCamisa.Checked == true) {
                total = total + 500;
                conCheck++;
            }
            if (radTarjeta.Checked == true) {
                pasarela = "Pago con Tarjeta ";
                conRad++;
            }
            if (radPaypal.Checked == true) {
                pasarela = "Pago con Paypal ";
                conRad++;
            }
            if (conCheck > 0 && conRad > 0)
            {
                lblResultado.Text = pasarela + total;
            }
            else {
                lblResultado.Text = "Humano debes seleccionar por lo menos un producto y una pasarela";
            }
            
        }

        private void btnRegresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formulario1 f1 = new Formulario1();
            f1.Show();
        }
    }
}
