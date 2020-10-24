using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.API.Dtos
{
    public class PedidoDto
    {

        public int Id { get; set; }

        public string Status { get; set; }

        public List<ProdutoDto> Lines { get; set; }

    }
}
