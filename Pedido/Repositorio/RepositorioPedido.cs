using System;
using System.Collections.Generic;

namespace Pedido
{
    public class RepositorioPedido
    {
        
        public List<Pedido> _listaPedido = new List<Pedido>{
            new Pedido{ Id=01, NomeCliente="João",Email="joao@everis.com",
                        Cpf="387497666777", ValorTotal=12345.78, DataPedido=DateTime.Now.ToLocalTime() },
            
        };

    }
}