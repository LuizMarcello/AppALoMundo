﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAloMundo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Pagina2();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
