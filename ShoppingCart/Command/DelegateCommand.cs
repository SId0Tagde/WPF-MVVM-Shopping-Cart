using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShoppingCart.Command
{
    public class DelegateCommand : ICommand
    {
        #region Private Variables.
        private readonly Action<object?> _execute;
        private readonly Func<object?, bool>? _canExecute;
        #endregion

        #region Public Properties.
        public event EventHandler? CanExecuteChanged;
        #endregion

        #region Constructors.
        public DelegateCommand(Action<object?> execute, Func<object?, bool>? canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        #endregion

        #region Public Methods.
        public bool CanExecute(object? parameter) => _canExecute is null || _canExecute(parameter);
        public void Execute(object? parameter) => _execute(parameter);
        #endregion
    }
}
