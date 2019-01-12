using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Application.Validation;
using ProjetoModelo.Application.ViewModels;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Services;
using ProjetoModelo.Infra.Data.Context;

namespace ProjetoModelo.Application
{
    public class ClienteAppService : AppServiceBase<ProjetoModeloContext>, IClienteAppService
    {
        private readonly IClienteService _clienteService;
        private readonly IEnderecoService _enderecoService;

        public ClienteAppService(IClienteService clienteService, IEnderecoService enderecoService)
        {
            _clienteService = clienteService;
            _enderecoService = enderecoService;
        }

        public ValidationAppResult Add(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            var cliente = Mapper.Map<ClienteEnderecoViewModel, Cliente>(clienteEnderecoViewModel);
            var endereco = Mapper.Map<ClienteEnderecoViewModel, Endereco>(clienteEnderecoViewModel);

            BeginTransaction();

            cliente.EnderecoList.Add(endereco);

            var result = _clienteService.AdicionarCliente(cliente);
            if (!result.IsValid)
                return DomainToApplicationResult(result);

            _enderecoService.Add(endereco);
            
            Commit();

            return DomainToApplicationResult(result);
        }

        public ClienteViewModel GetById(Guid id)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteService.GetById(id));
        }

        public IEnumerable<ClienteViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteService.GetAll());
        }

        public void Update(ClienteViewModel clienteViewModel)
        {
            var cliente = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);

            BeginTransaction();
            _clienteService.Update(cliente);
            Commit();
        }

        public void Remove(ClienteViewModel clienteViewModel)
        {
            var cliente = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);

            BeginTransaction();
            _clienteService.Remove(cliente);
            Commit();
        }

        public void Dispose()
        {
            _clienteService.Dispose();
        }
    }
}
