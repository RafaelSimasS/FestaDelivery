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
            else
            {
                formCatalogo.Close(); // Fecha o formulário se já estiver aberto
                formCatalogo.Dispose(); // Libera recursos do formulário fechado
                formCatalogo = new FormCatalogo(); // Cria um novo formulário
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
            else
            {
                formCarrinho.Close(); // Fecha o formulário se já estiver aberto
                formCarrinho.Dispose(); // Libera recursos do formulário fechado
                formCarrinho = new FormCarrinho(); // Cria um novo formulário
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
            else
            {
                formPedidos.Close(); // Fecha o formulário se já estiver aberto
                formPedidos.Dispose(); // Libera recursos do formulário fechado
                formPedidos = new FormPedidos(); // Cria um novo formulário
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
