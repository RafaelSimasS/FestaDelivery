using FestaDelivery.DTO;

namespace FestaDelivery
{
    public partial class FormShowPedido : Form
    {
        private Pedido _pedido;
        public FormShowPedido(Pedido pedido)
        {
            _pedido = pedido;
            InitializeComponent();
            this.Text = "Festa Delivery: Pedido de " + Program.currentUser.Nome;
            ConfigurarListView();
            CarregarItensPedido();
        }
        private void ConfigurarListView()
        {
            LstItensPedido.View = View.Details;
            LstItensPedido.FullRowSelect = true;
            LstItensPedido.GridLines = true;

            LstItensPedido.Columns.Add("Nome do Produto", 200, HorizontalAlignment.Left);
            LstItensPedido.Columns.Add("Quantidade", 100, HorizontalAlignment.Right);
        }
        private void CarregarItensPedido()
        {
            foreach (ItemPedido itemPedido in _pedido.Produtos)
            {
                Produto? produto = Program.Produtos.FirstOrDefault(p => p.Id == itemPedido.ProdutoId);

                if (produto != null)
                {
                    ListViewItem listItem = new ListViewItem(produto.Nome);
                    listItem.SubItems.Add(itemPedido.Quantidade.ToString());
                    LstItensPedido.Items.Add(listItem);
                }
            }
        }
    }
}
