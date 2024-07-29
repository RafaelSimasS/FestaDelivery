namespace FestaDelivery.DTO
{
    public class ItemCarrinho
    {
        private int _carrinhoId;
        private int _produtoId;
        private int _quantidade;
        public int CarrinhoId
        {
            get { return _carrinhoId; }
            set { _carrinhoId = value; }
        }

        public int ProdutoId
        {
            get { return _produtoId; }
            set { _produtoId = value; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        public ItemCarrinho(int carrinhoId, int produtoId, int quantidade)
        {
            _carrinhoId = carrinhoId;
            _produtoId = produtoId;
            _quantidade = quantidade;
        }
    }
}
