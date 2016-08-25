using System;

using UIKit;

namespace Ders7ek3
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            UIButton btn = new UIButton
            {
                Frame = new CoreGraphics.CGRect(50, 100, 150,
                50),
                BackgroundColor = UIColor.Red
            };

            btn.SetTitle("First Page", UIControlState.Normal);

            View.Add(btn);

            btn.TouchUpInside += (object sender, EventArgs e) =>
            {
                SecondViewController controller =
                this.Storyboard.InstantiateViewController("SecondViewController")
                as SecondViewController;

                controller.Name = "Yiğit";
                controller.Surname = "Özaksüt";

                this.NavigationController.PushViewController(controller, true);
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}