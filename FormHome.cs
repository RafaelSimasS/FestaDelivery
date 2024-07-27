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
    }
}
