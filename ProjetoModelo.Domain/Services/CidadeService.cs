using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repository;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class CidadeService : ServiceBase<Cidade>, ICidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;

        public CidadeService(ICidadeRepository cidadeRepository)
            : base(cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }
    }
}
