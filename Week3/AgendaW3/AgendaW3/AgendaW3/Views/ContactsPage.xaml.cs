using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AgendaW3.Views;
using AgendaW3.ViewModels;
using AgendaW3.Models;

namespace AgendaW3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        ContactsPageViewModel ContactViewModel = new ContactsPageViewModel();

        public ContactsPage()
        {
            InitializeComponent();
            BindingContext = ContactViewModel;
        }

        private void MyContactList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MyContactList.SelectedItem = null;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var MI = (MenuItem)sender;

            Contact Con = (Contact)MI.CommandParameter;
            
            MessagingCenter.Send<ContactsPage, Contact>(this, "DeleteContact", Con);
        }
    }
}