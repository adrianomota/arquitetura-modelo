using System.Collections.Generic;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repository;
using ProjetoModelo.Domain.Interfaces.Repository.ReadOnly;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class VendaService : ServiceBase<Venda>, IVendaService
    {
        private readonly IVendaReadOnlyRepository _vendaReadOnlyRepository;
        private readonly IVendaRepository _vendaRepository;

        public VendaService(
            IVendaReadOnlyRepository vendaReadOnlyRepository, 
            IVendaRepository vendaRepository)
            : base(vendaRepository)
        {
            _vendaReadOnlyRepository = vendaReadOnlyRepository;
            _vendaRepository = vendaRepository;
        }

        public override IEnumerable<Venda> GetAll()
        {
            return _vendaReadOnlyRepository.GetAll();
        }
    }
}
