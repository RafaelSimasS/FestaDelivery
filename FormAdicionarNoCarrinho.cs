using FestaDelivery.DTO;

namespace FestaDelivery
{
    public partial class FormAdicionarNoCarrinho : Form
    {
        private Produto _produto;
        public FormAdicionarNoCarrinho(Produto produto)
        {
            InitializeComponent();
            _produto = produto;
            CarregarDadosProduto();
        }
        private void CarregarDadosProduto()
        {
            LblNomeProduto.Text = _produto.Nome;
            LblPrecoProduto.Text = _produto.PrecoUni.ToString("C");
            LblQuantidadeDisponivel.Text = _produto.Quantidade.ToString();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtQuantidade.Text, out int quantidadeDesejada))
            {
                if (quantidadeDesejada <= 0)
                {
                    MessageBox.Show("Quantidade deve ser maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (quantidadeDesejada > _produto.Quantidade)
                {
                    MessageBox.Show("Quantidade desejada maior que a disponível.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var carrinho = Program.Carrinhos.FirstOrDefault(c => c.ClienteId == Program.currentUser.Id);
                if (carrinho == null)
                {
                    carrinho = new Carrinho(Program.currentUser.Id, true, 0);
                    Program.Carrinhos.Add(carrinho);
                }

                var itemCarrinho = carrinho.Produtos.FirstOrDefault(i => i.ProdutoId == _produto.Id);
                if (itemCarrinho == null)
                {
                    itemCarrinho = new ItemCarrinho(carrinho.ClienteId, _produto.Id, quantidadeDesejada);
                    carrinho.Produtos.Add(itemCarrinho);
                }
                else
                {
                    itemCarrinho.Quantidade += quantidadeDesejada;
                }

                _produto.Quantidade -= quantidadeDesejada;
                carrinho.PrecoTotal += quantidadeDesejada * _produto.PrecoUni;

                MessageBox.Show("Produto adicionado ao carrinho com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Quantidade inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
