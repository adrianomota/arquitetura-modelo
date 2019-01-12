using System.Data.Entity;
using ProjetoModelo.Infra.Data.Interfaces;

namespace ProjetoModelo.Infra.Data.Context
{
    public class BaseDbContext : DbContext, IDbContext
    {
        public BaseDbContext(string nameOrConnectionString) 
            :base(nameOrConnectionString)
        {

        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}