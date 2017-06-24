using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using RegisterLoginW2.Model;
using RegisterLoginW2;

namespace SimpleBindingForm
{
	public class RegisterViewModel 
	{
		public UserData User { get; set; }

		public ICommand OnCommand { get; set; }

		public RegisterViewModel()
		{
			User = new UserData();

			User.FirstName = "Maria";
			User.LastName = "Perez";
			User.Email = "mariaperez@gmail.com";

			OnCommand = new Command(OnSelected);
		}


		async void OnSelected() 
		{
			await App.Current.MainPage.DisplayAlert("Hello", "Hello", "Ok");

			User.FirstName = string.Empty;
		
		}
	}
}
