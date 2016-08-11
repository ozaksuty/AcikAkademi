using AcikAkademi5.Views;
using Xamarin.Forms;

namespace AcikAkademi5
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new ListPage());
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
