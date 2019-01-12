using ProjetoModelo.Infra.Data.Interfaces;

namespace ProjetoModelo.Application.Interfaces
{
    public interface IAppServiceBase<TContext> where TContext : IDbContext
    {
        void BeginTransaction();
        void Commit();
    }
}