using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Ders4.CustomControls;
using Ders4.Droid.CustomRenderers;

[assembly: ExportRenderer(typeof(CUstomDatePicker), 
    typeof(CustomDatePickerRenderer))]
namespace Ders4.Droid.CustomRenderers
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.DatePicker> e)
        {
            base.OnElementChanged(e);

            CUstomDatePicker datePicker = (CUstomDatePicker)Element;

            if (datePicker != null)
            {
                Control.SetTextColor(datePicker.TextColor.ToAndroid());
            }
        }
    }
}