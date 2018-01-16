using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticSolutions.Repositories.Entitys
{
    public class Order
    {

        public int OrderId { get; set; }
        public DateTime CreatedDate { get; set; }

        public List<Product> OrderDetails { get; set; }
        public int OrderStatusId { get; set; }
        public string OrderStatusDescription { get; set; }
        public string CreatedBy { get; set; }
        public string Insurance { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }

        public int Total { get; set; }

        public Order()
        {
            OrderDetails = new List<Product>();

        }


    }
}
