using Shop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        IClientRepository Client { get; }

        ISessionTokenRepository SessionToken { get; }

        Task SaveAsync();
    }
}
