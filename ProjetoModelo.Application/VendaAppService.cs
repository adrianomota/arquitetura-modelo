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
    public class VendaAppService : AppServiceBase<ProjetoModeloContext>, IVendaAppService
    {
        private readonly IVendaService _vendaService;

        public VendaAppService(IVendaService vendaService)
        {
            _vendaService = vendaService;
        }

        public void Add(VendaViewModel vendaViewModel)
        {
            var venda = Mapper.Map<VendaViewModel, Venda>(vendaViewModel);
            BeginTransaction();
            _vendaService.Add(venda);
            Commit();
        }

        public VendaViewModel GetById(Guid id)
        {
            return Mapper.Map<Venda, VendaViewModel>(_vendaService.GetById(id));
        }

        public IEnumerable<VendaViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Venda>, IEnumerable<VendaViewModel>>(_vendaService.GetAll());
        }

        public void Update(VendaViewModel vendaViewModel)
        {
            var venda = Mapper.Map<VendaViewModel, Venda>(vendaViewModel);
            BeginTransaction();
            _vendaService.Update(venda);
            Commit();
        }

        public void Remove(VendaViewModel vendaViewModel)
        {
            var venda = Mapper.Map<VendaViewModel, Venda>(vendaViewModel);
            BeginTransaction();
            _vendaService.Remove(venda);
            Commit();
        }

        public void Dispose()
        {
            _vendaService.Dispose();
        }
    }
}
