using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticSolutions.Repositories.Entitys
{
    public class Product
    {
        public int ProductId { get; set; }

        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public string ProductType { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int ReqWork { get; set; }

    }
}
