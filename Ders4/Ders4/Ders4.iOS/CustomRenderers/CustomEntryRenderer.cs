using Ders4.CustomControls;
using Ders4.iOS.CustomRenderers;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(CustomEntry), 
    typeof(CustomEntryRenderer))]
namespace Ders4.iOS.CustomRenderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BackgroundColor = UIKit.UIColor.Black;
                Control.TextColor = UIKit.UIColor.Blue;
            }
        }
    }
}