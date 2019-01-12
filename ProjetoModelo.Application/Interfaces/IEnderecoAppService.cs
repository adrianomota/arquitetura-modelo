using System;
using System.Collections.Generic;
using ProjetoModelo.Application.ViewModels;

namespace ProjetoModelo.Application.Interfaces
{
    public interface IEnderecoAppService : IDisposable
    {
        void Add(EnderecoViewModel enderecoViewModel);
        EnderecoViewModel GetById(Guid id);
        IEnumerable<EnderecoViewModel> GetAll();
        void Update(EnderecoViewModel enderecoViewModel);
        void Remove(EnderecoViewModel enderecoViewModel);
    }
}
