using Foundation;
using System;
using UIKit;

namespace Ders7ek3
{
    public partial class SecondViewController : UIViewController
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public SecondViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            UIButton btn = new UIButton
            {
                Frame = new CoreGraphics.CGRect(50, 100, 150,
                50),
                BackgroundColor = UIColor.Blue
            };
            btn.SetTitle("Second Page", UIControlState.Normal);

            btn.TouchUpInside += (object sender, EventArgs e) =>
            {
                new UIAlertView(Name, Surname, null, "Ok", null).Show();
            };

            View.Add(btn);
        }
    }
}