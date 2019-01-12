
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Specification;
using ProjetoModelo.Domain.Validation.Documentos;

namespace ProjetoModelo.Domain.Specification.Clientes
{
    public class ClientePossuiCPFValido : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return CPFValidation.Validar(cliente.CPF);
        }
    }
}
