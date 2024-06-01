using ShoppingCart.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ShoppingCart.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region Private Variables.
        private ViewModelBase? _selectedViewModel;
        #endregion

        #region Constructor.
        public MainViewModel(ProductViewModel ProductViewModel)
        {
            SelectedViewModel = ProductViewModel;
        }
        #endregion

        #region Public Properties
        public ViewModelBase? SelectedViewModel
        {
            get => _selectedViewModel;
            set
            {
                _selectedViewModel = value;
                RaisePropertyChanged(nameof(SelectedViewModel));
            }
        }
        #endregion
    }
}
