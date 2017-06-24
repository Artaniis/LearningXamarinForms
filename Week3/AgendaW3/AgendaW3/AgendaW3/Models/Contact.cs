using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaW3.Models
{
    public class Contact : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
