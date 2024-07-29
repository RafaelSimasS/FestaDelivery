using FestaDelivery.DTO;

namespace FestaDelivery
{
    public partial class FormCatalogo : Form
    {
        public FormCatalogo()
        {
            InitializeComponent();
            ConfigurarListView();
            CarregarProdutos();

            if (Program.currentUser.Tipo != "Admin")
            {
                adicionarProdutoToolStripMenuItem.Visible = false;
            }
        }

        private void ConfigurarListView()
        {
            // Configurar o ListView para mostrar detalhes
            LstCatalogo.View = View.Details;
            LstCatalogo.FullRowSelect = true;
            LstCatalogo.GridLines = true;

            LstCatalogo.Columns.Add("ID", 50, HorizontalAlignment.Left);
            LstCatalogo.Columns.Add("Categoria", 100, HorizontalAlignment.Left);
            LstCatalogo.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            LstCatalogo.Columns.Add("Descrição", 200, HorizontalAlignment.Left);
            LstCatalogo.Columns.Add("Preço Unitário", 100, HorizontalAlignment.Right);
            LstCatalogo.Columns.Add("Quantidade", 100, HorizontalAlignment.Right);
        }
        private void CarregarProdutos()
        {
            foreach (var produto in Program.Produtos)
            {
                ListViewItem item = new ListViewItem(produto.Id.ToString());
                item.SubItems.Add(produto.Categoria);
                item.SubItems.Add(produto.Nome);
                item.SubItems.Add(produto.Descricao);
                item.SubItems.Add(produto.PrecoUni.ToString("C"));
                item.SubItems.Add(produto.Quantidade.ToString());

                item.Tag = produto; // Salve a referência do objeto Produto no item
                LstCatalogo.Items.Add(item);
            }
        }

        private void LstCatalogo_DoubleClick(object sender, EventArgs e)
        {
            if (LstCatalogo.SelectedItems.Count != 1)
            {
                return;
            }
            ListViewItem selectedItem = LstCatalogo.SelectedItems[0];
            if (selectedItem.Tag == null)
            {
                return;
            }
            Produto produto = (Produto)selectedItem.Tag;
            if (Program.currentUser.Tipo == "Admin")
            {
                using (FormEditProduto formEdit = new FormEditProduto(produto))
                {
                    // Remover MdiParent antes de chamar ShowDialog
                    formEdit.MdiParent = null; // Remover o MDI pai
                    DialogResult resultado = formEdit.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        // Atualize o item no ListView
                        selectedItem.SubItems[1].Text = produto.Categoria;
                        selectedItem.SubItems[2].Text = produto.Nome;
                        selectedItem.SubItems[3].Text = produto.Descricao;
                        selectedItem.SubItems[4].Text = produto.PrecoUni.ToString("C");
                        selectedItem.SubItems[5].Text = produto.Quantidade.ToString();
                    }
                    else if (resultado == DialogResult.Ignore) // Ou outro valor definido para exclusão
                    {
                        // Remova o item do ListView
                        LstCatalogo.Items.Remove(selectedItem);
                    }
                }
            }
            else if (Program.currentUser.Tipo == "Cliente")
            {
                using (FormAdicionarNoCarrinho formAdicionar = new FormAdicionarNoCarrinho(produto))
                {
                    if (formAdicionar.ShowDialog() == DialogResult.OK)
                    {
                        // Atualize o item no ListView
                        selectedItem.SubItems[5].Text = produto.Quantidade.ToString();
                    }
                }
            }
        }

        private void adicionarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormAdicionarProduto formAdd = new FormAdicionarProduto())
            {
                // Exibir o formulário e aguardar a conclusão
                if (formAdd.ShowDialog() == DialogResult.OK)
                {
                    // Obter o produto adicionado do formulário
                    Produto novoProduto = formAdd.NovoProduto;

                    // Adicionar o produto à lista e atualizar o ListView
                    Program.Produtos.Add(novoProduto);
                    AdicionarProdutoNoListView(novoProduto);
                }
            }
        }
        private void AdicionarProdutoNoListView(Produto produto)
        {
            ListViewItem item = new ListViewItem(produto.Id.ToString());
            item.SubItems.Add(produto.Categoria);
            item.SubItems.Add(produto.Nome);
            item.SubItems.Add(produto.Descricao);
            item.SubItems.Add(produto.PrecoUni.ToString("C"));
            item.SubItems.Add(produto.Quantidade.ToString());

            item.Tag = produto; // Salve a referência do objeto Produto no item
            LstCatalogo.Items.Add(item);
        }
    }
}
