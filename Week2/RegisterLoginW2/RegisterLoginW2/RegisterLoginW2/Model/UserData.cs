﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterLoginW2.Model
{
    public class UserData : INotifyPropertyChanged
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Gender { get; set; }
        public string AboutMe { get; set; }
        public bool HasNotifications { get; set; }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
