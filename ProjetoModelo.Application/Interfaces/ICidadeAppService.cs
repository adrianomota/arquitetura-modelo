using System;
using System.Collections.Generic;
using ProjetoModelo.Application.ViewModels;

namespace ProjetoModelo.Application.Interfaces
{
    public interface ICidadeAppService : IDisposable
    {
        void Add(CidadeViewModel cidadeViewModel);
        CidadeViewModel GetById(Guid id);
        IEnumerable<CidadeViewModel> GetAll();
        void Update(CidadeViewModel cidadeViewModel);
        void Remove(CidadeViewModel cidadeViewModel);
    }
}
