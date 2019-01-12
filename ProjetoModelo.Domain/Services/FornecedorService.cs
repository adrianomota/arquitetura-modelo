using System;
using System.Collections.Generic;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repository;
using ProjetoModelo.Domain.Interfaces.Repository.ReadOnly;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class FornecedorService : ServiceBase<Fornecedor>, IFornecedorService
    {
        private readonly IFornecedorReadOnlyRepository _fornecedorReadOnlyRepository;
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(
            IFornecedorReadOnlyRepository fornecedorReadOnlyRepository, 
            IFornecedorRepository fornecedorRepository)
            : base(fornecedorRepository)
        {
            _fornecedorReadOnlyRepository = fornecedorReadOnlyRepository;
            _fornecedorRepository = fornecedorRepository;
        }

        public override IEnumerable<Fornecedor> GetAll()
        {
            return _fornecedorReadOnlyRepository.GetAll();
        }

        public override Fornecedor GetById(Guid id)
        {
            return _fornecedorReadOnlyRepository.GetById(id);
        }
    }
}