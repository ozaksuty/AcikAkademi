using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Acikakademi.Views
{
    public class MyContentPage2 : ContentPage
    {
        public MyContentPage2()
        {
            Label lblPage = new Label();
            lblPage.Text = "Marhaba Xamarin!";
            lblPage.FontSize = 30;
            lblPage.HorizontalOptions = LayoutOptions.Center;
            lblPage.VerticalOptions = LayoutOptions.Center;

            Content = lblPage;
        }
    }
}
