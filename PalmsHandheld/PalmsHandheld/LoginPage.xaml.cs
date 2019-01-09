using System;
using System.Linq;
using PalmsHandheld.ViewModel;
using Xamarin.Forms;

namespace PalmsHandheld
{
    public partial class LoginPage : ContentPage
    {
        MainVM viewModel;

        public LoginPage()
        {
            InitializeComponent();

            var assembly = typeof(LoginPage);
            viewModel = new MainVM();
            BindingContext = viewModel;
            //iconImage.Source = ImageSource.FromResource("PalmsHandheld.Assets.Images.github.png", assembly);
            emailEntry.Text = "system";
            passwordEntry.Text = "admin";
        }
    }
}
