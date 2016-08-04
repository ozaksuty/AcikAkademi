using Ders4.CustomControls;
using Ders4.WinPhone.CustomRenderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinRT;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace Ders4.WinPhone.CustomRenderer
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.PlaceholderText = "Xamarin WinPhone";
                Control.Background = new SolidColorBrush(Windows.UI.Color.
                    FromArgb(100, 200, 150, 100));

                Control.GotFocus += Control_GotFocus;
                Control.LostFocus += Control_LostFocus;
            }
        }

        private void Control_LostFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Control.FontFamily = new FontFamily("Arial");
            Control.Text = "LostFocus Event Çalıştı!";
        }

        private void Control_GotFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Control.FontFamily = new FontFamily("Calibri");
            Control.Text = "GotFocus Event Çalıştı!";
        }
    }
}
