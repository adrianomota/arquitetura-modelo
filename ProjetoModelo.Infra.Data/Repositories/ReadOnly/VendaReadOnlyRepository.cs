using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repository.ReadOnly;

namespace ProjetoModelo.Infra.Data.Repositories.ReadOnly
{
    public class VendaReadOnlyRepository : RepositoryBaseReadOnly, IVendaReadOnlyRepository
    {
        public Venda GetById(Guid id)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var sql = @"Select * From Venda v " +
                          "WHERE v.VendaId ='" + id + "'";

                var venda = cn.Query<Venda>(sql);

                return venda.FirstOrDefault();
            }
        }


        public IEnumerable<Venda> GetAll()
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var sql = @"Select * From Venda v " +
                          "inner join VendaProdutos vp " +
                          "on v.VendaId = vp.VendaId " +
                          "inner join Produto p " +
                          "on vp.ProdutoId = p.ProdutoId " +
                          "inner join Cliente c " +
                          "on v.ClienteId = c.ClienteId ";

                var vendas = cn.Query<Venda, Produto, Cliente, Venda>(
                    sql,
                    (v, p, c) =>
                    {
                        v.ProdutosList.Add(p);
                        v.Cliente = c;

                        return v;
                    }, splitOn: "VendaId, ProdutoId, ClienteId");

                return vendas;
            }
        }
    }
}
