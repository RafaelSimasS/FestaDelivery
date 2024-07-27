namespace FestaDelivery.DTO
{
    internal class Produto
    {
        private int _id;
        private string _categoria;
        private string _nome;
        private string _descricao;
        private double _precoUni;
        private int _quantidade;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public double PrecoUni
        {
            get { return _precoUni; }
            set { _precoUni = value; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        public List<ItemPedido> Pedidos { get; set; } = new List<ItemPedido>();

        public Produto(int id, string categoria, string nome, string descricao, double precoUni, int quantidade)
        {
            _id = id;
            _categoria = categoria;
            _nome = nome;
            _descricao = descricao;
            _precoUni = precoUni;
            _quantidade = quantidade;
        }
    }
}
