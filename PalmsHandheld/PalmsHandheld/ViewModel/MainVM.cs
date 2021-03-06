﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PalmsHandheld.Model;
using PalmsHandheld.ViewModel.Commands;

namespace PalmsHandheld.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private User user;

        public User User
        {
            get { return user; }
            set
            {
                user = value;
                OnPropertyChanged("User");
            }
        }

        public LoginCommand LoginCommand { get; set; }

        public RegisterNavigationCommand RegisterNavigationCommand { get; set; }

        private string email;

        public string Email
        {
            get {return email; }
            set
            {
                email = value;
                User = new User()
                {
                    Email = this.Email,
                    Password = this.password
                };
                OnPropertyChanged("Email");
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                User = new User()
                {
                    Email = this.Email,
                    Password = this.password
                };
                OnPropertyChanged("Password");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainVM()
        {
            User = new User();
            LoginCommand = new LoginCommand(this);
            RegisterNavigationCommand = new RegisterNavigationCommand(this);
        }

        public async void Login()
        {
            bool canLogin = await User.Login(User.Email, User.Password);

            if (canLogin)
                await App.Current.MainPage.Navigation.PushAsync(new HomePage());
            else
                await App.Current.MainPage.DisplayAlert("Error", "Email or Password is incorrect", "Ok");
        }

        public async void Navigate()
        {
            await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }
    }
}
