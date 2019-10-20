using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopAppPractice3
{
    public class Product
    {
        public string id { set; get; }
        public int quantity { set; get; }

        public Product(string id, int quantity)
        {
            this.id = id;
            this.quantity = quantity;
        }
    }
    
}
