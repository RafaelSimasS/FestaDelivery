using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestaDelivery
{
    public partial class FormHome : Form
    {
        private FormCatalogo formCatalogo;
        private FormPedidos formPedidos;

        public FormHome()
        {
            InitializeComponent();
        }

        private void catalogoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formCatalogo == null || formCatalogo.IsDisposed)
            {
                formCatalogo = new FormCatalogo();
                formCatalogo.MdiParent = this;

            }
            formCatalogo.BringToFront();
            formCatalogo.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formPedidos == null || formPedidos.IsDisposed)
            {
                formPedidos = new FormPedidos();
                formPedidos.MdiParent = this;

            }
            formPedidos.BringToFront();
            formPedidos.Show();
        }
    }
}
