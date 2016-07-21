using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Acikakademi2.Views
{
    public partial class ThemePage : ContentPage
    {
        public ThemePage()
        {
            InitializeComponent();
        }

        private void onClicked(object sender, EventArgs e)
        {
            Application.Current.Resources["DefaultTitle"] =
                Application.Current.Resources["NewTitle"];

            Application.Current.Resources["DefaultButton"] =
                Application.Current.Resources["NewButton"];

            Application.Current.Resources["DefaultBackground"] =
                Application.Current.Resources["NewBackground"];

            Application.Current.Resources["DefaultContent"] =
                Application.Current.Resources["NewContent"];
        }
    }

}
