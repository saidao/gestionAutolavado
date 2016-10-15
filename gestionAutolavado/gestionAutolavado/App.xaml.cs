﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace gestionAutolavado
{
    public partial class App : Application
    {
        public static object Navigator { get; internal set; }

        public App()
        {
            InitializeComponent();
            MainPage = new Pages.MasterPage();
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
