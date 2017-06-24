using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using AgendaW3.Models;

namespace AgendaW3.ViewModels
{
    class AddContactPageViewModel
    {
        public ICommand OnAddNewCommand { get; set; }

        public Contact MyNewContact { get; set; } = new Contact();

        public AddContactPageViewModel()
        {
            OnAddNewCommand = new Command(OnAddNew);
        }

        void OnAddNew()
        {
            if (string.IsNullOrEmpty(MyNewContact.Name) || string.IsNullOrEmpty(MyNewContact.Number))
            {
                App.Current.MainPage.DisplayAlert("Error", "Fields cannot be empty", "Ok");
            }
            else
            {
                App.Current.MainPage.DisplayAlert(":)", "Successfully added contact!", "Ok");
                MessagingCenter.Send<AddContactPageViewModel, Contact>(this, "Contact", MyNewContact);
            }
        }
    }
}
