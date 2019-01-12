using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repository.ADO;

namespace ProjetoModelo.Infra.Data.Repositories.ADO
{
    public class ClienteADORepository : BaseADORepository, IClienteADORepository
    {
        public IEnumerable<Cliente> GetAll()
        {
            var query = "SELECT * FROM CLIENTE ";
            var clienteList = new List<Cliente>();

            using (IDataReader reader = Connection.ExecuteReader(CommandType.Text, query))
            {
                while (reader.Read())
                {
                    var cliente = new Cliente();
                    cliente.ClienteId = Guid.Parse(reader["ClienteId"].ToString());
                    cliente.Nome = reader["Nome"].ToString();

                    clienteList.Add(cliente);
                }
            }

            return clienteList;
        }
    }
}
