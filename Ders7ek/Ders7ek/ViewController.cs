using System;

using UIKit;

namespace Ders7ek
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        //partial void UIButton4_TouchUpInside(UIButton sender)
        //{
        //    new UIAlertView("Test", "Açık Akademi", null, "OK", null).Show();
        //}
    }
}