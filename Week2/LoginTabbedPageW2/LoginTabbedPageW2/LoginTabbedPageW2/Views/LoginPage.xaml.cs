using System;
using System.Collections.Generic;
using System.Linq;
using LoginTabbedPageW2.Views;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LoginTabbedPageW2.ViewModels;

namespace LoginTabbedPageW2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        async void Handle_Tapped(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}