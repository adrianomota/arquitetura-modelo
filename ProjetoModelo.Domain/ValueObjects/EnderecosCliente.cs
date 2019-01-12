using System;

namespace ProjetoModelo.Domain.ValueObjects
{
    public class EnderecosCliente
    {
        public Guid EnderecoId { get; set; }
        public Guid ClienteId { get; set; }
    }
}
