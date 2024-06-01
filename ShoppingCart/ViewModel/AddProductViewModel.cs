using ShoppingCart.Command;
using ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ShoppingCart.ViewModel
{
    class AddProductViewModel : ViewModelBase
    {
        #region Public Variables.
        public Product Product { get; set; }
        public DelegateCommand SaveCommand { get; set; }
        public bool isProductSaved { get; set; }
        #endregion

        #region Constructor.
        public AddProductViewModel()
        {
            Product = new Product();
            SaveCommand = new DelegateCommand(SaveNewProduct);
        }
        #endregion

        #region Private Methods.
        private void SaveNewProduct(object? obj)
        {
            isProductSaved = true;
            if (obj is Window window)
            {
                window.DialogResult = true;
                window.Close();
            }
        }
        #endregion
    }
}
