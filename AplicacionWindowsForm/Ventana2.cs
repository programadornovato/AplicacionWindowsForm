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
        int sel;
        public Ventana2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int n = dgPersonas.Rows.Add();
            dgPersonas.Rows[n].Cells[0].Value = txtNombre.Text;
            dgPersonas.Rows[n].Cells[1].Value = txtApellido.Text;
            dgPersonas.Rows[n].Cells[2].Value = txtEdad.Text;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
        }

        private void dgPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel = e.RowIndex;
            if (sel != -1) {
                string nombre = dgPersonas.Rows[sel].Cells[0].Value.ToString();
                string apellido = dgPersonas.Rows[sel].Cells[1].Value.ToString();
                string edad = dgPersonas.Rows[sel].Cells[2].Value.ToString();
                lblValor.Text = nombre +" "+ apellido + " " + edad;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (sel != -1)
            {
                dgPersonas.Rows.RemoveAt(sel);
            }
        }
    }
}
