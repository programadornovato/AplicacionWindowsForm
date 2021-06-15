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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Nuevo") {
                Ventana2 v2 = new Ventana2();
                v2.MdiParent = this;
                v2.Show();
            }
            if (e.ClickedItem.Text == "Cerrar") {
                this.Close();
            }
        }
    }
}
