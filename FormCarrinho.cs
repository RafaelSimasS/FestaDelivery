using FestaDelivery.DTO;
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
    public partial class FormCarrinho : Form
    {
        public FormCarrinho()
        {
            InitializeComponent();
            ConfigurarListView();
            CarregarCarrinho();
        }
        private void ConfigurarListView()
        {
            // Configurar o ListView para mostrar detalhes
            LstCarrinho.View = View.Details;
            LstCarrinho.FullRowSelect = true;
            LstCarrinho.GridLines = true;

            LstCarrinho.Columns.Add("ID", 50, HorizontalAlignment.Left);
            LstCarrinho.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            LstCarrinho.Columns.Add("Quantidade", 100, HorizontalAlignment.Right);
            LstCarrinho.Columns.Add("Preço Unitário", 100, HorizontalAlignment.Right);
        }
        private void CarregarCarrinho()
        {
            var carrinho = Program.Carrinhos.FirstOrDefault(c => c.ClienteId == Program.currentUser.Id);

            if (carrinho == null)
            {
                MessageBox.Show("Carrinho não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var item in carrinho.Produtos)
            {
                var produto = Program.Produtos.FirstOrDefault(p => p.Id == item.ProdutoId);

                if (produto != null)
                {
                    ListViewItem listItem = new ListViewItem(produto.Id.ToString());
                    listItem.SubItems.Add(produto.Nome);
                    listItem.SubItems.Add(item.Quantidade.ToString());
                    listItem.SubItems.Add(produto.PrecoUni.ToString("C"));
                    listItem.Tag = item; // Salvar a referência do objeto ItemCarrinho no item
                    LstCarrinho.Items.Add(listItem);
                }
            }
        }

        private void fecharCarrinhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja fechar o carrinho e criar um novo pedido?", "Fechar Carrinho", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var carrinho = Program.Carrinhos.FirstOrDefault(c => c.ClienteId == Program.currentUser.Id);

                if (carrinho == null || !carrinho.Produtos.Any())
                {
                    MessageBox.Show("Carrinho vazio ou não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Criar um novo Pedido
                var novoPedido = new Pedido(
                    id: Program.Pedidos.Any() ? Program.Pedidos.Max(p => p.Id) + 1 : 1,
                    clienteId: Program.currentUser.Id,
                    data: DateTime.Now,
                    precoTotal: carrinho.Produtos.Sum(p => Program.Produtos.First(prod => prod.Id == p.ProdutoId).PrecoUni * p.Quantidade),
                    status: "Pendente"
                );

                foreach (var itemCarrinho in carrinho.Produtos)
                {
                    novoPedido.Produtos.Add(new ItemPedido(novoPedido.Id, itemCarrinho.ProdutoId, itemCarrinho.Quantidade));
                }

                // Adicionar o novo pedido à lista de pedidos
                Program.Pedidos.Add(novoPedido);

                // Limpar o carrinho do cliente
                carrinho.Produtos.Clear();

                // Atualizar o ListView
                LstCarrinho.Items.Clear();

                MessageBox.Show("Pedido criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
