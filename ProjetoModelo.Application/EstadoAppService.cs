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
    public class EstadoAppService : AppServiceBase<ProjetoModeloContext>, IEstadoAppService
    {
        private readonly IEstadoService _estadoService;

        public EstadoAppService(IEstadoService estadoService)
        {
            _estadoService = estadoService;
        }

        public void Add(EstadoViewModel estadoViewModel)
        {
            var estado = Mapper.Map<EstadoViewModel, Estado>(estadoViewModel);
            BeginTransaction();
            _estadoService.Add(estado);
            Commit();
        }

        public EstadoViewModel GetById(Guid id)
        {
            return Mapper.Map<Estado, EstadoViewModel>(_estadoService.GetById(id));
        }

        public IEnumerable<EstadoViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Estado>, IEnumerable<EstadoViewModel>>(_estadoService.GetAll());
        }

        public void Update(EstadoViewModel estadoViewModel)
        {
            var estado = Mapper.Map<EstadoViewModel, Estado>(estadoViewModel);
            BeginTransaction();
            _estadoService.Update(estado);
            Commit();
        }

        public void Remove(EstadoViewModel estadoViewModel)
        {
            var estado = Mapper.Map<EstadoViewModel, Estado>(estadoViewModel);
            BeginTransaction();
            _estadoService.Remove(estado);
            Commit();
        }

        public void Dispose()
        {
            _estadoService.Dispose();
        }
    }
}
