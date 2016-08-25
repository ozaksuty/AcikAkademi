using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace Ders7
{
    [Register("UniversalView")]
    public class UniversalView : UIView
    {
        public UniversalView()
        {
            Initialize();
        }

        public UniversalView(RectangleF bounds) : base(bounds)
        {
            Initialize();
        }

        void Initialize()
        {
            BackgroundColor = UIColor.Red;
        }
    }

    [Register("MyViewController")]
    public class MyViewController : UIViewController
    {
        public MyViewController()
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            //View = new UniversalView();

            base.ViewDidLoad();

            View.BackgroundColor = UIColor.Brown;

            UITextField myText = new UITextField(new CoreGraphics.CGRect(0, 28,
                View.Bounds.Width, 35))
            {
                KeyboardType = UIKeyboardType.Default,
                BorderStyle = UITextBorderStyle.RoundedRect,
                Placeholder = "Açýk Akademi"
            };

            UIButton myButton = new UIButton(UIButtonType.Custom)
            {
                Frame = new CoreGraphics.CGRect(0, 70, View.Bounds.Width, 45),
                BackgroundColor = UIColor.Red,
                
            };
            myButton.SetTitle("My Buttom", UIControlState.Normal);

            UILabel myLabel = new UILabel(new CoreGraphics.CGRect(20, 145, 100, 20))
            {
                TextColor = UIColor.Blue
            };

            myButton.TouchUpInside += (s, e) =>
            {
                myLabel.Text = myText.Text;
            };

            View.AddSubviews(myText, myButton, myLabel);
        }
    }
}