using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AgendaW3.ViewModels;

namespace AgendaW3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactPage : ContentPage
    {
        AddContactPageViewModel AddContactViewModel = new AddContactPageViewModel();
        public AddContactPage()
        {
            InitializeComponent();
            BindingContext = AddContactViewModel;
        }
    }
}