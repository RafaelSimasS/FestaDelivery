namespace FestaDelivery
{
    public partial class FormHomeCliente : Form
    {
        private FormCatalogo formCatalogo;
        private FormCarrinho formCarrinho;
        private FormPedidos formPedidos;
        public FormHomeCliente()
        {
            InitializeComponent();
        }

        private void catálogoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formCatalogo == null || formCatalogo.IsDisposed)
            {
                formCatalogo = new FormCatalogo();
                formCatalogo.MdiParent = this;

            }
            formCatalogo.BringToFront();
            formCatalogo.Show();
        }

        private void carrinhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formCarrinho == null || formCarrinho.IsDisposed)
            {
                formCarrinho = new FormCarrinho();
                formCarrinho.MdiParent = this;
            }
            formCarrinho.BringToFront();
            formCarrinho.Show();
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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
