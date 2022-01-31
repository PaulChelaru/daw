using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Enities.DTOs
{
    public class ClientDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Order> Orders { get; set; }
        public Address Address { get; set; }

        public ClientDTO(Client client)
        {
            this.Id = client.Id;
            this.FirstName = client.FirstName;
            this.LastName = client.LastName;
            this.Orders = new List<Order>();
            this.Address = client.Address;
        }
    }
}
