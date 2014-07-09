using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SemiTransparentModalPage.Base
{
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Predicate<object> _canExecute;

        public RelayCommand(Action execute)
            : this(execute, null)
        {
        }

        public RelayCommand(Action execute, Predicate<object> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameters)
        {
            return _canExecute == null || _canExecute(parameters);
        }

        public void RaiseCanExecuteChanged()
        {
            var tmpHandle = CanExecuteChanged;
            if (tmpHandle != null)
                tmpHandle(this, new EventArgs());
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameters)
        {
            _execute();
        }
    }
}
