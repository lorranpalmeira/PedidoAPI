using System;
using System.ComponentModel.DataAnnotations;

namespace Pedido
{
    public class Pedido
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Nome é requerido")]
        public string NomeCliente { get; set; }

        [EmailAddress(ErrorMessage = "Email Inválido")]
        public string Email { get; set; }

        public string Cpf { get; set; }

        public double ValorTotal { get; set; }

        public DateTime DataPedido { get; set; }


    }
}