using System;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Specification;

namespace ProjetoModelo.Domain.Specification.Clientes
{
    class ClienteEstaCadastradoMaisDeCincoAnos : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
    }
}
