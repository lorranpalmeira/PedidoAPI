using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pedido;
using Xunit;

namespace PedidoTestes
{
    public class PedidioTeste
    {

        private PedidoController  _pedidoController;
        public PedidioTeste()
        {
            _pedidoController = new PedidoController();
        }

         [Fact]
        public async Task PedidoGet()
        {
            // Act
            IActionResult actionResult = await _pedidoController.ListaPedido();

            // Assert
            Assert.NotNull(actionResult);

            OkObjectResult result = actionResult as OkObjectResult;

            Assert.NotNull(result);

            Assert.Equal(200, result.StatusCode);
        }
        
    }
}