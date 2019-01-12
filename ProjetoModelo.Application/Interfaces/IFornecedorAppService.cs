using System;
using System.Collections.Generic;
using ProjetoModelo.Application.ViewModels;

namespace ProjetoModelo.Application.Interfaces
{
    public interface IFornecedorAppService : IDisposable
    {
        void Add(FornecedorViewModel fornecedorViewModel);
        FornecedorViewModel GetById(Guid id);
        IEnumerable<FornecedorViewModel> GetAll();
        void Update(FornecedorViewModel fornecedorViewModel);
        void Remove(FornecedorViewModel fornecedorViewModel);
    }
}
