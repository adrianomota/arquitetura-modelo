using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repository;
using ProjetoModelo.Domain.Interfaces.Services;

namespace ProjetoModelo.Domain.Services
{
    public class EstadoService : ServiceBase<Estado>, IEstadoService
    {
        private readonly IEstadoRepository _estadoRepository;

        public EstadoService(IEstadoRepository estadoRepository)
            :base(estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }
    }
}
