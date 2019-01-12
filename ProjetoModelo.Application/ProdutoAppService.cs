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
    public class ProdutoAppService : AppServiceBase<ProjetoModeloContext>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<ProdutoViewModel> BuscarPorNome(string nome)
        {
            return Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoService.BuscarPorNome(nome)); 
        }

        public void Add(ProdutoViewModel produtoViewModel)
        {
            var produto = Mapper.Map<ProdutoViewModel, Produto>(produtoViewModel);
            BeginTransaction();
            _produtoService.Add(produto);
            Commit();
        }

        public ProdutoViewModel GetById(Guid id)
        {
            return Mapper.Map<Produto, ProdutoViewModel>(_produtoService.GetById(id));
        }

        public IEnumerable<ProdutoViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoService.GetAll());
        }

        public void Update(ProdutoViewModel produtoViewModel)
        {
            var produto = Mapper.Map<ProdutoViewModel, Produto>(produtoViewModel);
            BeginTransaction();
            _produtoService.Update(produto);
            Commit();
        }

        public void Remove(ProdutoViewModel produtoViewModel)
        {
            var produto = Mapper.Map<ProdutoViewModel, Produto>(produtoViewModel);
            BeginTransaction();
            _produtoService.Remove(produto);
            Commit();
        }

        public void Dispose()
        {
            _produtoService.Dispose();
        }
    }
}
