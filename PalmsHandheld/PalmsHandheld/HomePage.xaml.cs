using PalmsHandheld.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PalmsHandheld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
        RegisterVM viewModel;

        public HomePage ()
		{
			InitializeComponent ();
            viewModel = new RegisterVM();
            BindingContext = viewModel;
        }
	}
}