using System;
using System.Collections.Generic;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Domain.Interfaces.Repository.ReadOnly
{
    public interface IFornecedorReadOnlyRepository
    {
        Fornecedor GetById(Guid id);
        IEnumerable<Fornecedor> GetAll(); 
    }
}