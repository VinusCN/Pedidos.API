using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pedidos.API.Data;
using Pedidos.API.Dtos;
using Pedidos.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly PedidosContext _context;
        public PedidosController(PedidosContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PedidoDto pedidoDto)
        {
            var pedido = new Pedido
            {
                Status = pedidoDto.Status,
                Produtos = pedidoDto.Lines.Select(x => new Produto { Product = x.Product, Quantity = x.Quantity }).ToList()
            };

            _context.Pedidos.Add(pedido);

            _context.SaveChanges();

            return Ok();
        }

        [HttpPost("receber/{id}")]
        public IActionResult Post([FromRoute] int id)
        {
            var pedido = _context.Pedidos.Find(id);
            if (pedido == null) 
            {
                return NotFound();
            }
            pedido.Status = "Recebido";

            _context.SaveChanges();

            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<List<PedidoDto>>> Get()
        {

            var pedidos = _context.Pedidos.Include(p => p.Produtos).ToList();

            var pedidosDto = pedidos.Select(x => new List<PedidoDto>
            {
                new PedidoDto
                {
                    Id = x.Id,
                    Status = x.Status,
                    Lines = x.Produtos.Select(y => new ProdutoDto
                    {
                        Id = y.Id,
                        Product = y.Product,
                        Quantity = y.Quantity
                    }).ToList()
                }
            });

            return pedidosDto.ToList();
        }
    }
}
