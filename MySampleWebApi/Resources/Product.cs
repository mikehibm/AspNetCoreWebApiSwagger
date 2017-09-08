using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySampleWebApi.Resources
{
    public class Product
    {
        public long id { get; set; }
        public string ProdCd { get; set; }
        public string ProdName { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
