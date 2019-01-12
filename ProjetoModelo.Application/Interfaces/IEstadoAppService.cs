using System;
using System.Collections.Generic;
using ProjetoModelo.Application.ViewModels;

namespace ProjetoModelo.Application.Interfaces
{
    public interface IEstadoAppService : IDisposable
    {
        void Add(EstadoViewModel estadoViewModel);
        EstadoViewModel GetById(Guid id);
        IEnumerable<EstadoViewModel> GetAll();
        void Update(EstadoViewModel estadoViewModel);
        void Remove(EstadoViewModel estadoViewModel);
    }
}
