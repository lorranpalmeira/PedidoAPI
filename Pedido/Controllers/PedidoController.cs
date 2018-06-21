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
            if(ModelState.IsValid){
                _pedido._listaPedido.Add(pedido);
                return Ok("Pedido Adicionado");
            }else{
                return BadRequest("Erro ao inserir");
            }
                
            
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
            
            var obj = _pedido._listaPedido.FirstOrDefault(x => x.Id == pedido.Id);

            if(ModelState.IsValid){
                obj.NomeCliente = pedido.NomeCliente;
            obj.Cpf = pedido.Cpf;
            obj.Email = pedido.Email;

            return Ok("pedido alterado com sucesso");
            }else{
                return BadRequest("Erro ao alterar");
            }
            
        }



        
    }
}