using FestaDelivery.DTO;

namespace FestaDelivery
{
    public partial class FormEditProduto : Form
    {
        private Produto produto;
        public FormEditProduto(Produto produto)
        {
            InitializeComponent();
            this.produto = produto;
            PreencherCampos();
        }
        private void PreencherCampos()
        {
            TxtCategoria.Text = produto.Categoria;
            TxtNome.Text = produto.Nome;
            TxtDescricao.Text = produto.Descricao;
            TxtPrecoUni.Text = produto.PrecoUni.ToString();
            TxtQuantidade.Text = produto.Quantidade.ToString();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string categoria = TxtCategoria.Text;
            string nome = TxtNome.Text;
            string descricao = TxtDescricao.Text;
            double precoUni;
            int quantidade;

            // Verificar se os campos de texto podem ser convertidos corretamente
            if (!double.TryParse(TxtPrecoUni.Text, out precoUni))
            {
                MessageBox.Show("O preço unitário deve ser um número válido.");
                return;
            }

            if (!int.TryParse(TxtQuantidade.Text, out quantidade))
            {
                MessageBox.Show("A quantidade deve ser um número válido.");
                return;
            }

            // Verificar se o nome do produto já existe na lista, exceto o produto atual
            bool nomeExiste = Program.Produtos.Any(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase) && p != produto);

            if (nomeExiste)
            {
                MessageBox.Show("Já existe um produto com o mesmo nome.");
                return;
            }

            // Atualizar as propriedades do produto
            produto.Categoria = categoria;
            produto.Nome = nome;
            produto.Descricao = descricao;
            produto.PrecoUni = precoUni;
            produto.Quantidade = quantidade;

            // Fechar o formulário e retornar OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnExcluirProd_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza de que deseja excluir este produto?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                // Remover o produto da lista
                Program.Produtos.Remove(produto);

                // Fechar o formulário com um status que indica exclusão
                this.DialogResult = DialogResult.Ignore; // Ou outro valor que você achar apropriado
                this.Close();
            }
        }
    }
}
