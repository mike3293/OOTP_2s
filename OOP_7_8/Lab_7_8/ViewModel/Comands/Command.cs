using System;
using System.Windows.Input;

namespace Lab_7_8.ViewModel.Comands
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action _execute;

        public Command(Action execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute?.Invoke();
        }
    }
}
