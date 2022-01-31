using Shop.Enities;
using Shop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        Task<Client> GetByFullName(string lastName, string firstName);
        Task<List<Client>> GetAllClientsWithAddress();

        Task<Client> GetByIDWithAddress(int id);
    }
}
