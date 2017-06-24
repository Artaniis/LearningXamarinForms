using LoginTabbedPageW2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using LoginTabbedPageW2.Views;

namespace LoginTabbedPageW2.ViewModels
{
    public class SignUpViewModel
    {
        public UserData User { get; set; } = new UserData();
        public ICommand OnSignUpCommand { get; set; }
        public SignUpViewModel()
        {
            OnSignUpCommand = new Command(OnSignUp);
        }

        void OnSignUp()
        {
            if (string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(User.Password) || string.IsNullOrEmpty(User.FirstName))
                App.Current.MainPage.DisplayAlert("Error", "Fields cannot be empty", "Ok");
            else
            {
                App.Current.MainPage.Navigation.PushAsync(new HomePage());
                //Settings.Email = User.Email;
            }

        }
    }
}
