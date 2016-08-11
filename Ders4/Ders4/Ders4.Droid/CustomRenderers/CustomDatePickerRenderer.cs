using Ders4.CustomControls;
using Ders4.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

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