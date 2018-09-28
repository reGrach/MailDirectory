using System;
using System.Diagnostics;
using System.Windows.Input;

namespace MailDirectory.ViewModel
{

    //Класс с передаваемым объектом для реализации страничной навигации
    //RelayCommand обеспечивает передачу команд и ее исполнение

    public class RelayCommand<T> : ICommand
    {
        #region fields

        private readonly Action<T> _execute = null;
        private readonly Predicate<object> _canExecute = null;

        #endregion

        #region constructors
        public RelayCommand(Action<T> execute)
            : this(execute, null)
        {
        }

        public RelayCommand(Action<T> execute, Predicate<object> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException("execute");
            _canExecute = canExecute;
        }
        #endregion

        #region ICommand Implementation
        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            if (parameter is T)
            {
                var typedParameter = (T)parameter;
                _execute(typedParameter);
            }
        }
        #endregion
    }

    public class RelayCommand : ICommand
    {
        #region fields

        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;

        #endregion

        #region constructors

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        #endregion

        #region ICommand Implementation
        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        #endregion
    }
}
