using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repository;
using ProjetoModelo.Infra.Data.Context;

namespace ProjetoModelo.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente, ProjetoModeloContext>, IClienteRepository
    {

    }
}
