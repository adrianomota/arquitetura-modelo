using System;
using System.Collections.Generic;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repository;
using ProjetoModelo.Domain.Interfaces.Repository.ReadOnly;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IProdutoReadOnlyRepository _produtoReadOnlyRepository;

        public ProdutoService(
            IProdutoRepository produtoRepository, 
            IProdutoReadOnlyRepository produtoReadOnlyRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
            _produtoReadOnlyRepository = produtoReadOnlyRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }

        public override IEnumerable<Produto> GetAll()
        {
            return _produtoReadOnlyRepository.GetAll();
        }

        public override Produto GetById(Guid id)
        {
            return _produtoReadOnlyRepository.GetById(id);
        }
    }
}
