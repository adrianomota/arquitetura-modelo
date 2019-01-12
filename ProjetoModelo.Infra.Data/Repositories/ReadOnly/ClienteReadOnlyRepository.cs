using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repository.ReadOnly;
using ProjetoModelo.Domain.ValueObjects;

namespace ProjetoModelo.Infra.Data.Repositories.ReadOnly
{
    public class ClienteReadOnlyRepository : RepositoryBaseReadOnly, IClienteReadOnlyRepository
    {
        public Cliente GetById(Guid id)
        {
            using (IDbConnection cn = Connection)
            {
                var sql = @"Select * From Cliente c " +
                          "Inner join EnderecosCliente ec " +
                          "On c.ClienteId = ec.ClienteId " +
                          "Inner join Endereco e " +
                          "On e.EnderecoId = ec.EnderecoId " +
                          "Inner join Estado s " +
                          "On s.EstadoId = e.EstadoId " +
                          "Inner join Cidade cl " +
                          "On cl.EstadoId = s.EstadoId " +
                          "WHERE c.ClienteId='" + id +"'";

                cn.Open();

                var clientes = cn.Query<Cliente, EnderecosCliente, Endereco, Estado, Cidade, Cliente>(
                    sql,
                    (c, ec, e, st, ci) =>
                    {
                        e.EstadoId = st.EstadoId;
                        e.CidadeId = ci.CidadeId;
                        e.Estado = st;
                        e.Cidade = ci;

                        if (c.EnderecoList != null)
                            c.EnderecoList.Add(e);

                        return c;

                    }, splitOn: "ClienteId, EnderecoId, EstadoId, CidadeId");

                    return clientes.FirstOrDefault();
            }
        }
        
        public IEnumerable<Cliente> GetAll()
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var sql = @"Select * From Cliente c " +
                          "Inner join EnderecosCliente ec " +
                          "On c.ClienteId = ec.ClienteId " +
                          "Inner join Endereco e " +
                          "On e.EnderecoId = ec.EnderecoId " +
                          "Inner join Estado s " +
                          "On s.EstadoId = e.EstadoId " +
                          "Inner join Cidade cl " +
                          "On cl.EstadoId = s.EstadoId ";

                var clientes = cn.Query<Cliente, EnderecosCliente, Endereco, Estado, Cidade, Cliente>(
                    sql,
                    (c, ec, e, st, ci) =>
                    {
                        e.EstadoId = st.EstadoId;
                        e.CidadeId = ci.CidadeId;
                        e.Estado = st;
                        e.Cidade = ci;

                        if (c.EnderecoList != null)
                            c.EnderecoList.Add(e);

                        return c;

                    }, splitOn: "ClienteId, EnderecoId, EstadoId, CidadeId");

                return clientes;
            }
        }
    }
}
