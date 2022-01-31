using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Enities;
using Shop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(ShopContext context) : base(context) { }

        public async Task<List<Client>> GetAllClientsWithAddress()
        {
            return await _context.Clients.Include(client => client.Address).ToListAsync();
        }

        public async Task<Client> GetByIDWithAddress(int id)
        {
            return await _context.Clients.Include(client => client.Address).Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Client> GetByFullName(string lastName, string firstName)
        {
            return await _context.Clients
                .Where(client => client.LastName.Equals(lastName))
                .Where(client => client.FirstName.Equals(firstName))
                .FirstOrDefaultAsync();
        }
    }
}
