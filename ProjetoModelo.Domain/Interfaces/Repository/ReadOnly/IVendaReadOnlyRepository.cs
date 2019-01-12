using System;
using System.Collections.Generic;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Domain.Interfaces.Repository.ReadOnly
{
    public interface IVendaReadOnlyRepository
    {
        Venda GetById(Guid id);
        IEnumerable<Venda> GetAll(); 
    }
}