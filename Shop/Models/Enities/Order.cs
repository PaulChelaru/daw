using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Enities
{
    public class Order
    {
        public int Id { get; set; }
        public double Price { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }

    }
}
