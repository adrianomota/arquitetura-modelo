using System.Collections.Generic;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.ValueObjects;

namespace ProjetoModelo.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        ValidationResult AdicionarCliente(Cliente cliente);
    }
}
