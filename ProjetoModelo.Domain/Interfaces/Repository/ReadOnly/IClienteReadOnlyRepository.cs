using System;
using System.Collections.Generic;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Domain.Interfaces.Repository.ReadOnly
{
    public interface IClienteReadOnlyRepository
    {
        Cliente GetById(Guid id);
        IEnumerable<Cliente> GetAll();
    }
}
