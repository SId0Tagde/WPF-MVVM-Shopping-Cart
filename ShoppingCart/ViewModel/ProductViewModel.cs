using ShoppingCart.Command;
using ShoppingCart.Model;
using ShoppingCart.Service;
using ShoppingCart.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.ViewModel
{
    public class ProductViewModel : ViewModelBase
    {
        #region Private Variable.
        #region Dependency
        public ProductItemViewModel SelectedProduct { get; set; }
        public DelegateCommand AddProductCommand { get; set; }
        #endregion
        #endregion

        #region Public Variables.
        public ObservableCollection<ProductItemViewModel> Products { get; } = new();
        #endregion

        #region Constructor.
        public ProductViewModel()
        {
            LoadAsync();
            AddProductCommand = new DelegateCommand(AddProduct);
        }
        #endregion

        #region Public Method.
        public override Task LoadAsync()
        {
            var products = ProductList.productList;
            foreach (var item in products)
            {
                Products.Add(new ProductItemViewModel(item));
            }
            return base.LoadAsync();
        }

        private void AddProduct(object? obj)
        {
            var addProductWindow = new AddProduct();
            var addProductViewModel = new AddProductViewModel();
            addProductWindow.DataContext = addProductViewModel;
            var abc = addProductWindow.ShowDialog();
            if (abc == true)
            {
                if (addProductViewModel.Product != null)
                {
                    Products.Add(new ProductItemViewModel(addProductViewModel.Product)
                    );
                }
            }
        }
        #endregion
    }
}
