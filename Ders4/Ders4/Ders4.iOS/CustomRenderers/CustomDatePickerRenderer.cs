using Ders4.CustomControls;
using Ders4.iOS.CustomRenderers;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CUstomDatePicker), 
    typeof(CustomDatePickerRenderer))]
namespace Ders4.iOS.CustomRenderers
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);

            CUstomDatePicker picker = (CUstomDatePicker)Element;
            if (picker != null)
            {
                Control.TextColor = picker.TextColor.ToUIColor();
            }
        }
    }
}