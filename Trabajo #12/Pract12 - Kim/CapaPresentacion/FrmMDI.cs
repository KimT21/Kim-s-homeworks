using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LogicaNegocio;
using Entidad;

namespace CapaPresentacion
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void factuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ClickClientes(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ClickProductos(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ClickFacturacion(object sender, EventArgs e)
        {
            FrmFacturacion frm = new FrmFacturacion();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
