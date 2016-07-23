using Acikakademi.Controls;
using Acikakademi.Layouts;
using Acikakademi.SpecialControls;
using Acikakademi.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Acikakademi
{
    public class App : Application
    {
        public static Page GetMainPage()
        {
            return new MyMasterPage();
        }
        public App()
        {
            MainPage = new MyMasterPage();
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
