using Microsoft.AspNetCore.Identity;
using Shop.Enities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Enities
{
    public class User : IdentityUser<int>
    {
        public User() : base() { }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
