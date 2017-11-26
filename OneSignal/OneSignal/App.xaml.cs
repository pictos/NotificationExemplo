using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace OneSignal
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new OneSignal.MainPage();

            Com.OneSignal.OneSignal.Current.StartInit("a5fd6eb9-1d6d-470e-9a28-5eef4038788a").EndInit();
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
