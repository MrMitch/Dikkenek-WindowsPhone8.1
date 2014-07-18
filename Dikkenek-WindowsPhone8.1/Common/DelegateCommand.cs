using System;
using System.Windows.Input;

namespace Dikkenek_WindowsPhone8._1.Common
{
    public class DelegateCommand<T> : ICommand
    {
        private readonly Action<T> _executeAction;
        public Action<T> ExecuteAction
        {
            get { return _executeAction; }
        }

        private readonly Func<bool> _canExecuteAction;
        public Func<bool> CanExecuteAction
        {
            get { return _canExecuteAction; }
        }

        public DelegateCommand(Action<T> executeAction)
            : this(executeAction, null)
        {

        }

        public DelegateCommand(Action<T> executeAction, Func<bool> canExecuteAction)
        {
            if (executeAction == null)
            {
                throw new ArgumentException("executeAction");
            }

            _executeAction = executeAction;
            _canExecuteAction = canExecuteAction;
        }

        public void RaiseCanExecuteChanged()
        {
            var handler = CanExecuteChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        #region ICommand Membres

        public bool CanExecute(object parameter)
        {
            return _canExecuteAction == null || _canExecuteAction();
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _executeAction((T)parameter);
        }

        #endregion
    }
}
