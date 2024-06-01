using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.ViewModel
{
    public class ViewModelValidationBase : ViewModelBase, INotifyDataErrorInfo
    {
        #region Private Variables.
        private readonly Dictionary<string, List<string>> _errorsByPropertyName = new();
        #endregion

        #region Public Variables.
        public bool HasErrors => _errorsByPropertyName.Any();

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;
        #endregion

        #region Protected Methods.
        protected virtual void OnErrorsChanged(DataErrorsChangedEventArgs args)
        {
            ErrorsChanged?.Invoke(this, args);
        }

        protected void AddError(string error,
      [CallerMemberName] string? propertyName = null)
        {
            if (propertyName is null) return;

            if (!_errorsByPropertyName.ContainsKey(propertyName))
            {
                _errorsByPropertyName[propertyName] = new List<string>();
            }
            if (!_errorsByPropertyName[propertyName].Contains(error))
            {
                _errorsByPropertyName[propertyName].Add(error);
                OnErrorsChanged(new DataErrorsChangedEventArgs(propertyName));
                RaisePropertyChanged(nameof(HasErrors));
            }
        }

        protected void ClearErrors([CallerMemberName] string? propertyName = null)
        {
            if (propertyName is null) return;

            if (_errorsByPropertyName.ContainsKey(propertyName))
            {
                _errorsByPropertyName.Remove(propertyName);
                OnErrorsChanged(new DataErrorsChangedEventArgs(propertyName));
                RaisePropertyChanged(nameof(HasErrors));
            }
        }
        #endregion

        #region Public Methods.
        public IEnumerable GetErrors(string? propertyName)
        {
            return propertyName is not null &&
                _errorsByPropertyName.ContainsKey(propertyName) ?
                _errorsByPropertyName[propertyName]
                : Enumerable.Empty<string>();
        }
        #endregion
    }
}
