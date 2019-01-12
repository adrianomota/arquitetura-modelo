using System;
using System.Collections.Generic;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Domain.Interfaces.Repository.ReadOnly
{
    public interface IProdutoReadOnlyRepository
    {
        Produto GetById(Guid id);
        IEnumerable<Produto> GetAll(); 
    }
}
