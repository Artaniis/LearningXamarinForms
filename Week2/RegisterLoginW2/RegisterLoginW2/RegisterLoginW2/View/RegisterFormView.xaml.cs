using SimpleBindingForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RegisterLoginW2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterFormView : ContentPage
    {
        public RegisterFormView()
        {
            InitializeComponent();
            this.BindingContext = new RegisterViewModel();
        }
    }
}