using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repository.ReadOnly;

namespace ProjetoModelo.Infra.Data.Repositories.ReadOnly
{
    public class FornecedorReadOnlyRepository : RepositoryBaseReadOnly, IFornecedorReadOnlyRepository
    {
        public Fornecedor GetById(Guid id)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var sql = @"Select * From Fornecedor v " +
                          "WHERE v.FornecedorId ='" + id + "'";

                var fornecedor = cn.Query<Fornecedor>(sql);

                return fornecedor.FirstOrDefault();
            }
        }


        public IEnumerable<Fornecedor> GetAll()
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var sql = @"Select * From Fornecedor v ";

                var fornecedor = cn.Query<Fornecedor>(sql);

                return fornecedor;
            }
        }
    }
}
