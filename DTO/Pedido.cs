namespace FestaDelivery.DTO
{
    internal class Pedido
    {
        private int _id;
        private int _clienteId;
        private DateTime _data;
        private double _precoTotal;
        private string _status;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int ClienteId
        {
            get { return _clienteId; }
            set { _clienteId = value; }
        }

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public double PrecoTotal
        {
            get { return _precoTotal; }
            set { _precoTotal = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public List<ItemPedido> Produtos { get; set; } = new List<ItemPedido>();

        public Pedido(int id, int clienteId, DateTime data, double precoTotal, string status)
        {
            _id = id;
            _clienteId = clienteId;
            _data = data;
            _precoTotal = precoTotal;
            _status = status;
        }
    }
}
