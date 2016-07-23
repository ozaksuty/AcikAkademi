using Acikakademi2.Views;
using Xamarin.Forms;

namespace Acikakademi2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new ThemePage(); 
        }
    }
}
