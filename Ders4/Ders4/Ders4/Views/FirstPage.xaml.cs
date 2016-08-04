using Ders4.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Ders4.Views
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage(string deviceName)
        {
            InitializeComponent();
            Label lblDeviceName = new Label
            {
                Text = deviceName,
            };

            CustomEntry myEntry = new CustomEntry();

            CUstomDatePicker picker = new CUstomDatePicker();
            picker.TextColor = Device.OnPlatform(Color.Black,
                Color.White, Color.Blue);

            Content = new StackLayout
            {
                Children =
                {
                    lblDeviceName,
                    myEntry,
                    picker
                }
            };
        }
    }
}