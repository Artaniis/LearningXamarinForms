using AgendaW3.Models;
using AgendaW3.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AgendaW3.ViewModels
{
    public class ContactsPageViewModel
    {
        public ObservableCollection<Contact> MyContacts { get; set; } = new ObservableCollection<Contact>();

        public ICommand OnAddCommand { get; set; }
        public ICommand OnDeleteCommand { get; set; }
        //{
        //    get
        //    {

        //    }
        //    set
        //    {

        //    }
        //}

        Contact _itemSelected;
        public Contact ItemSelected
        {
            get
            {
                return _itemSelected;
            }
            set
            {
                _itemSelected = value;

                if (_itemSelected != null)
                {
                    App.Current.MainPage.DisplayAlert($"{value.Name}" , "Would you like to call the number\n" + $"{value.Number}" , "Yes" , "No");
                }
            }
        }

        public ContactsPageViewModel()
        {
            MyContacts.Add(new Contact() { Name = "Juan", Number = "8092223333" });
            MyContacts.Add(new Contact() { Name = "aksjd", Number = "022992929" });
            MyContacts.Add(new Contact() { Name = "Maria", Number = "322323424" });
            MyContacts.Add(new Contact() { Name = "Pedro", Number = "234234234" });
            MyContacts.Add(new Contact() { Name = "Lucas", Number = "454545454" });

            OnAddCommand = new Command(OnAdd);
            OnDeleteCommand = new Command(OnDelete);

            MessagingCenter.Subscribe<AddContactPageViewModel, Contact>(this, "Contact", (sender, param) =>
            {
                MyContacts.Add(param);
            });
        }

        void OnAdd()
        {
            App.Current.MainPage.Navigation.PushAsync(new AddContactPage());
        }

        void OnDelete()
        {
            MessagingCenter.Subscribe<ContactsPage, Contact>(this, "DeleteContact", (sender, param) =>
            {
                MyContacts.Remove(param);
            });
        }
    }
}
