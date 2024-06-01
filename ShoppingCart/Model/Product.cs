using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    public class Product
    {
        public string productName { get; set; } = null!;
        public int price { get; set; }

        private int _counter;
    }
}