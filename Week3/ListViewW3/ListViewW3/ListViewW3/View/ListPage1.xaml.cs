using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewW3.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage1 : ContentPage
    {
        ViewModel.ListPageViewModel listPageViewModel = new ViewModel.ListPageViewModel();

        public ListPage1()
        {
            BindingContext = listPageViewModel;
            InitializeComponent();
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MiLista.SelectedItem = null;
        }
    }
}