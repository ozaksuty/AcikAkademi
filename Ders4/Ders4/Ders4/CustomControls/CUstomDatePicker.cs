using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ders4.CustomControls
{
    public class CUstomDatePicker : DatePicker
    {
        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create<CUstomDatePicker, Color>(p => p.TextColor, Color.Red);

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }
    }
}
