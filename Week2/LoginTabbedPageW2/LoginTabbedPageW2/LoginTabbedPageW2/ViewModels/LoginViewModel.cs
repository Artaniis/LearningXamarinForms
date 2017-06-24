using LoginTabbedPageW2.Models;
using LoginTabbedPageW2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginTabbedPageW2.ViewModels
{
    public class LoginViewModel
    {
        public UserData User { get; set; } = new UserData();
        public ICommand OnLoginCommand { get; set; }
        public LoginViewModel()
        {
            OnLoginCommand = new Command(OnLogin);
        }

        void OnLogin()
        {
            if (string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(User.Password))
                App.Current.MainPage.DisplayAlert("Error", "Fields cannot be empty", "Ok");
            else
                App.Current.MainPage.Navigation.PushAsync(new HomePage());
        }
    }
}
