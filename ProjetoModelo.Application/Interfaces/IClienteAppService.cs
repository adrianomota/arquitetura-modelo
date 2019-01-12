using System;
using System.Collections.Generic;
using ProjetoModelo.Application.Validation;
using ProjetoModelo.Application.ViewModels;

namespace ProjetoModelo.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {
        ValidationAppResult Add(ClienteEnderecoViewModel clienteViewModel);
        ClienteViewModel GetById(Guid id);
        IEnumerable<ClienteViewModel> GetAll();
        void Update(ClienteViewModel clienteViewModel);
        void Remove(ClienteViewModel clienteViewModel);
    }
}
