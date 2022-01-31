using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Enities.DTOs
{
    public class CreateClientDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address Address { get; set; }
    }
}
