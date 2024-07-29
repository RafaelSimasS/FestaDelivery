using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaDelivery.DTO
{
    public class Carrinho
    {
        private int _clienteId;
        private bool _status;
        private double _precoTotal;

        public int ClienteId
        {
            get { return _clienteId; }
            set { _clienteId = value; }
        }
        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public double PrecoTotal
        {
            get { return _precoTotal; }
            set { _precoTotal = value; }
        }

        public List<ItemCarrinho> Produtos { get; set; } = new List<ItemCarrinho>();

        public Carrinho(int clienteId, bool status, double precoTotal)
        {
            _precoTotal = precoTotal;
            _clienteId = clienteId;
            _status = status;
        }
    }
}
