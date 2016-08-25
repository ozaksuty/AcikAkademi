using System;

using UIKit;

namespace Ders7ek2
{
    public partial class SecondViewController : UIViewController
    {
        public SecondViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            UILabel lbl = new UILabel(new CoreGraphics.CGRect(0, 20, View.Bounds.Width,
                35))
            {
                Text = "Açık Akademi",
                TextColor = UIColor.Red
            };

            View.AddSubview(lbl);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

