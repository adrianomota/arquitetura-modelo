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
    public class FornecedorAppService : AppServiceBase<ProjetoModeloContext>, IFornecedorAppService
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorAppService(IFornecedorService fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }

        public void Add(FornecedorViewModel fornecedorViewModel)
        {
            var fornecedor = Mapper.Map<FornecedorViewModel, Fornecedor>(fornecedorViewModel);
            BeginTransaction();
            _fornecedorService.Add(fornecedor);
            Commit();
        }

        public FornecedorViewModel GetById(Guid id)
        {
            return Mapper.Map<Fornecedor, FornecedorViewModel>(_fornecedorService.GetById(id));
        }

        public IEnumerable<FornecedorViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Fornecedor>, IEnumerable<FornecedorViewModel>>(_fornecedorService.GetAll());
        }

        public void Update(FornecedorViewModel fornecedorViewModel)
        {
            var fornecedor = Mapper.Map<FornecedorViewModel, Fornecedor>(fornecedorViewModel);
            BeginTransaction();
            _fornecedorService.Update(fornecedor);
            Commit();
        }

        public void Remove(FornecedorViewModel fornecedorViewModel)
        {
            var fornecedor = Mapper.Map<FornecedorViewModel, Fornecedor>(fornecedorViewModel);
            BeginTransaction();
            _fornecedorService.Remove(fornecedor);
            Commit();
        }

        public void Dispose()
        {
            _fornecedorService.Dispose();
        }
    }
}
