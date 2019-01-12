using System;
using System.Collections.Generic;
using AutoMapper;
using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Application.ViewModels;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Services;
using ProjetoModelo.Infra.Data.Context;

namespace ProjetoModelo.Application
{
    public class EnderecoAppService : AppServiceBase<ProjetoModeloContext>, IEnderecoAppService
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoAppService(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        public void Add(EnderecoViewModel enderecoViewModel)
        {
            var endereco = Mapper.Map<EnderecoViewModel, Endereco>(enderecoViewModel);
            BeginTransaction();
            _enderecoService.Add(endereco);
            Commit();
        }

        public EnderecoViewModel GetById(Guid id)
        {
            return Mapper.Map<Endereco, EnderecoViewModel>(_enderecoService.GetById(id));
        }

        public IEnumerable<EnderecoViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Endereco>, IEnumerable<EnderecoViewModel>>(_enderecoService.GetAll());
        }
        
        public void Update(EnderecoViewModel enderecoViewModel)
        {
            var endereco = Mapper.Map<EnderecoViewModel, Endereco>(enderecoViewModel);
            BeginTransaction();
            _enderecoService.Update(endereco);
            Commit();
        }

        public void Remove(EnderecoViewModel enderecoViewModel)
        {
            var endereco = Mapper.Map<EnderecoViewModel, Endereco>(enderecoViewModel);
            BeginTransaction();
            _enderecoService.Remove(endereco);
            Commit();
        }

        public void Dispose()
        {
            _enderecoService.Dispose();
        }
    }
}
