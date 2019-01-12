using System;
using System.Collections.Generic;
using ProjetoModelo.Application.ViewModels;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Application.Interfaces
{
    public interface IProdutoAppService : IDisposable
    {
        void Add(ProdutoViewModel produtoViewModel);
        ProdutoViewModel GetById(Guid id);
        IEnumerable<ProdutoViewModel> GetAll();
        void Update(ProdutoViewModel produtoViewModel);
        void Remove(ProdutoViewModel produtoViewModel);
        IEnumerable<ProdutoViewModel> BuscarPorNome(string nome);
    }
}
