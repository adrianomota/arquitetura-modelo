using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Specification;

namespace ProjetoModelo.Domain.Specification.Clientes
{
    class ClientePossuiStatusAtivo : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return cliente.Ativo;
        }
    }
}
