using Ders4.Helper;
using Ders4.Views;
using Xamarin.Forms;

namespace Ders4
{
    public class App : Application
    {
        public static string DbName { get; set; } = "Ders4.db3";
        public App()
        {
            //string deviceName = DependencyService.Get<IDeviceHelper>()
            //    .GetDeviceName();

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
