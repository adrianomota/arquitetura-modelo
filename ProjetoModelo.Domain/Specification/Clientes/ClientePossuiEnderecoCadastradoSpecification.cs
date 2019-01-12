using System.Linq;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Specification;

namespace ProjetoModelo.Domain.Specification.Clientes
{
    public class ClientePossuiEnderecoCadastradoSpecification : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return cliente.EnderecoList != null && cliente.EnderecoList.Any();
        }
    }
}
