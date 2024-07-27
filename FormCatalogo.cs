using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FestaDelivery
{
    public partial class FormCatalogo : Form
    {
        public FormCatalogo()
        {
            InitializeComponent();
            ConfigurarListView();
            CarregarProdutos();
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

                LstCatalogo.Items.Add(item);
            }
        }
    }
}
