using FestaDelivery.DTO;

namespace FestaDelivery
{
    public partial class FormAdicionarProduto : Form
    {
        private Produto _novoProduto;
        public Produto NovoProduto
        {
            get { return _novoProduto; }
            private set { _novoProduto = value; }
        }
        public FormAdicionarProduto()
        {
            InitializeComponent();
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

            bool nomeExiste = Program.Produtos.Any(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (nomeExiste)
            {
                MessageBox.Show("Já existe um produto com o mesmo nome.");
                return;
            }
            // Criar o novo produto
            NovoProduto = new Produto(
                Program.Produtos.Count > 0 ? Program.Produtos.Max(p => p.Id) + 1 : 1, // Gerar um novo ID
                categoria,
                nome,
                descricao,
                precoUni,
                quantidade
            );

            // Fechar o formulário e retornar OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
