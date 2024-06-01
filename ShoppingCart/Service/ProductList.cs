using ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Service
{
    internal static class ProductList
    {
        public static ObservableCollection<Product> productList = new()
            {
                new Product() { productName = "ABC",price = 12},
                new Product() { productName = "DEF",price = 22},
                new Product() { productName = "GHI",price = 32},
                new Product() { productName = "JKL",price = 42},
                new Product() { productName = "MNO",price = 52},
            };
    }
}
