using System;
using System.Collections.Generic;
using ProjetoModelo.Application.ViewModels;

namespace ProjetoModelo.Application.Interfaces
{
    public interface IVendaAppService : IDisposable
    {
        void Add(VendaViewModel vendaViewModel);
        VendaViewModel GetById(Guid id);
        IEnumerable<VendaViewModel> GetAll();
        void Update(VendaViewModel vendaViewModel);
        void Remove(VendaViewModel vendaViewModel);
    }
}
