using Shop.Data;
using Shop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly ShopContext _context;
        private IUserRepository _user;
        private IClientRepository _client;
        private ISessionTokenRepository _sessionToken;
        public RepositoryWrapper(ShopContext context)
        {
            _context = context;
        }

        public IUserRepository User
        {
            get
            {
                if (_user == null) _user = new UserRepository(_context);
                return _user;
            }
        }

        public IClientRepository Client
        {
            get
            {
                if (_client == null) _client = new ClientRepository(_context);
                return _client;
            }

        }

        public ISessionTokenRepository SessionToken
        {
            get
            {
                if (_sessionToken == null) _sessionToken = new SessionTokenRepository(_context);
                return _sessionToken;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
