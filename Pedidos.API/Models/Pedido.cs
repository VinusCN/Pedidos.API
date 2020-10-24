using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.API.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        public string Status { get; set; }

        public List<Produto> Produtos { get; set; }

    }
}
