using LoginTabbedPageW2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginTabbedPageW2.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public DateTime Time { get; set; }
        public ICommand OnMoreInfoCommand { get; set; }
        public UserData User { get; set; } = new UserData();
        public HomeViewModel()
        {
            this.Time = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.Time = DateTime.Now;
                return true;
            });

            OnMoreInfoCommand = new Command(OnMoreInfo);

            //User.Email = Settings.Email;
        }

        void OnMoreInfo()
        {
            Device.OpenUri(new Uri("http://www.mytime.net.au/"));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
