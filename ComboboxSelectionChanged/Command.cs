using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ComboboxSelectionChangedIssue
{
    public class Command : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private readonly Action execute;
        private readonly Func<bool> canExecute;

        public Command(Action execute, Func<bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return canExecute?.Invoke() ?? true;
        }

        public void Execute(object? parameter)
        {
            if (CanExecute(parameter))
            {
                try
                {
                    execute();
                }
                catch { }
            }
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
