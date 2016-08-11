using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Acikakademi.Layouts
{
    public class AbsoluteOrnek : ContentPage
    {
        public AbsoluteOrnek()
        {
            AbsoluteLayout layout = new AbsoluteLayout();

            BoxView blue = new BoxView();
            blue.BackgroundColor = Color.Blue;

            BoxView red = new BoxView();
            red.BackgroundColor = Color.Red;

            red.Opacity = 0.6;

            layout.Children.Add(red, new Rectangle(50, 50, 100, 150));
            layout.Children.Add(blue, new Rectangle(30, 30, 100, 150));

            Content = layout;
        }
    }
}
