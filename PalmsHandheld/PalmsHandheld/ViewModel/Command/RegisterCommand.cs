using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using PalmsHandheld.Model;
using PalmsHandheld.ViewModel;

namespace PalmsHandheld.ViewModel.Commands
{
    public class RegisterCommand : ICommand
    {
        public RegisterVM ViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public RegisterCommand(RegisterVM viewModel)
        {
            ViewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            var user = (User)parameter;

            if (user != null)
            {
                if (user.Password == user.ConfirmPassword)
                {
                    if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
                        return false;
                    return true;
                }
                return false;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            User user = (User)parameter;
            ViewModel.Register(user);
        }
    }
}
