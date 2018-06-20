using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pedido
{

    [Route("api/[controller]")]
    public class PedidoController : Controller
    {
        private RepositorioPedido _pedido;
        public PedidoController()
        {
           _pedido = new RepositorioPedido();
        }

        [HttpPost]
        [Route("Pedido")]
        public async Task<IActionResult> Pedido([FromBody]Pedido pedido)
        {
            _pedido._listaPedido.Add(pedido);

            return Ok("Pedido Adicionado");
        }

        [HttpGet]
        [Route("Pedido")]
        public async Task<IActionResult> ListaPedido()
        {
            var listaPedidos =_pedido._listaPedido.ToList();

            return Ok(listaPedidos);
        }

         [HttpPut]
        [Route("Pedido")]
        public async Task<IActionResult> AlteraPedido([FromBody] Pedido pedido)
        {
            var pedidos =_pedido._listaPedido.ToList();

            pedidos.Where(x => x.Id == pedido.Id);

            return Ok(pedidos);
        }



        
    }
}