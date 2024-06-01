using ShoppingCart.Command;
using ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.ViewModel
{
    public class ProductItemViewModel : ViewModelValidationBase
    {
        #region Private Variables.
        private int _counter;
        #region Dependency.
        private readonly Product _model;
        public DelegateCommand AddCommand { get; }
        public DelegateCommand RemoveCommand { get; }
        #endregion
        #endregion

        #region Constructor.
        public ProductItemViewModel(Product model) : base()
        {
            _model = model;
            AddCommand = new DelegateCommand(Add);
            RemoveCommand = new DelegateCommand(Remove);
        }
        #endregion

        #region Public Variables.
        public string productName
        {
            get
            {
                return _model.productName;
            }
            set
            {
                if (_model.productName != value)
                {
                    _model.productName = value;
                    RaisePropertyChanged(nameof(productName));
                }
                if (string.IsNullOrEmpty(_model.productName))
                {
                    AddError("Product Name is required", value);
                }
                else
                {
                    ClearErrors();
                }
            }
        }
        public int price
        {
            get
            {
                return _model.price;
            }
            set
            {
                if (_model.price != value)
                {
                    _model.price = value;
                    RaisePropertyChanged(nameof(price));
                }
                if ((decimal)value <= 0)
                {
                    AddError("Price can't be less than zero", nameof(price));
                }
                else
                {
                    ClearErrors();
                }
            }
        }

        public int Counter
        {
            get
            { return _counter; }
            set
            {
                _counter = value;
                RaisePropertyChanged(nameof(Counter));
                if ((decimal)value < 0)
                {
                    AddError("Counter can't be less than zero", nameof(Counter));
                }
                else
                {
                    ClearErrors(nameof(Counter));
                }
            }
        }
        #endregion

        #region Private Methods.
        private void Remove(object? obj)
        {
            var counter = (int)obj;
            if(counter > 0)
            Counter--;
        }

        private void Add(object? obj)
        {
            var counter = (int)obj;
            if(counter >= 0)
            Counter++;
        }
        #endregion
    }
}
