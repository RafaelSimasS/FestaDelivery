using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FestaDelivery.DTO
{
    internal class ItemPedido
    {
        private int _pedidoId;
        private int _produtoId;
        private int _quantidade;
        public int PedidoId
        {
            get { return _pedidoId; }
            set { _pedidoId = value; }
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

        public ItemPedido(int pedidoId, int produtoId, int quantidade)
        {
            _pedidoId = pedidoId;
            _produtoId = produtoId;
            _quantidade = quantidade;
        }
    }
}
