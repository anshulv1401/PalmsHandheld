using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace PalmsHandheld.ViewModel.Command
{
    public class LogoutCommand : ICommand
    {
        public RegisterVM ViewModel { get; set; }
        
        public LogoutCommand(RegisterVM viewModel)
        {
            ViewModel = viewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModel.Logout();
        }
    }
}
