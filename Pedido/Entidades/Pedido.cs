using System;

namespace Pedido
{
    public class Pedido
    {
        public int Id { get; set; }

        public string NomeCliente { get; set; }


        public string Email { get; set; }

        public string Cpf { get; set; }

        public double ValorTotal { get; set; }

        public DateTime DataPedido { get; set; }


    }
}