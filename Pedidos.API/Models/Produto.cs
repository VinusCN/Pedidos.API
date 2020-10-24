using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.API.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Product { get; set; }

        public int Quantity { get; set; }

        public int PedidoId { get; set; }

        public Pedido Pedido { get; set; }

    }
}
