using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Default Access Modifier => Internal
    public class Product
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
