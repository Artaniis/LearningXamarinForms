﻿using AgendaW3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AgendaW3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AgendaW3.MainPage();
            MainPage = new NavigationPage(new ContactsPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
