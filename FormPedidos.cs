using FestaDelivery.DTO;

namespace FestaDelivery
{
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();
            ConfigurarListView();
            CarregarPedidos();
        }
        private void ConfigurarListView()
        {
            LstPedidos.View = View.Details;
            LstPedidos.FullRowSelect = true;
            LstPedidos.GridLines = true;

            LstPedidos.Columns.Add("ID", 50, HorizontalAlignment.Left);
            LstPedidos.Columns.Add("Cliente ID", 100, HorizontalAlignment.Left);
            LstPedidos.Columns.Add("Data", 100, HorizontalAlignment.Left);
            LstPedidos.Columns.Add("Preço Total", 100, HorizontalAlignment.Right);
            LstPedidos.Columns.Add("Status", 100, HorizontalAlignment.Left);
        }
        private void CarregarPedidos()
        {
            LstPedidos.Items.Clear();

            var pedidosFiltrados = Program.currentUser.Tipo == "Cliente" ?
            Program.Pedidos.Where(p => p.ClienteId == Program.currentUser.Id) :
            Program.Pedidos;

            foreach (Pedido pedido in pedidosFiltrados)
            {
                // Buscar o nome do cliente na lista de usuários
                string nomeCliente = Program.Users.FirstOrDefault(user => user.Id == pedido.ClienteId)?.Nome ?? "Desconhecido";

                ListViewItem item = new ListViewItem(pedido.Id.ToString());
                item.SubItems.Add(nomeCliente);
                item.SubItems.Add(pedido.Data.ToString("dd/MM/yyyy")); // Formatação de data
                item.SubItems.Add(pedido.PrecoTotal.ToString("C")); // Formatação de moeda
                item.SubItems.Add(pedido.Status);

                item.Tag = pedido; // Salvar a referência do objeto Pedido no item
                LstPedidos.Items.Add(item);
            }
        }

        private void LstPedidos_DoubleClick(object sender, EventArgs e)
        {
            if (LstPedidos.SelectedItems.Count != 1)
            {
                return;
            }
            ListViewItem selectedItem = LstPedidos.SelectedItems[0];
            if (selectedItem.Tag == null)
            {
                return;
            }

            Pedido pedido = (Pedido)selectedItem.Tag;
            if (Program.currentUser.Tipo == "Admin")
            {
                using (FormEditPedido formEdit = new FormEditPedido(pedido))
                {
                    if (formEdit.ShowDialog() == DialogResult.OK)
                    {
                        // Atualize o item no ListView
                        selectedItem.SubItems[4].Text = pedido.Status;
                    }
                }
            }
            else if (Program.currentUser.Tipo == "Cliente")
            {
                using (FormShowPedido formShow = new FormShowPedido(pedido))
                {
                    formShow.ShowDialog();
                }
            }

        }
    }

}
