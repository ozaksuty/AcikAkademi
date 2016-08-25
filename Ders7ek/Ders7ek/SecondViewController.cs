using Foundation;
using System;
using UIKit;

namespace Ders7ek
{
    public partial class SecondViewController : UIViewController
    {
        public SecondViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.View.BackgroundColor = UIColor.Yellow;

            string[] data = new string[] { "yiðit", "serkan", "ibrahim" };

            UITableView tableView = new UITableView
            {
                Frame = new CoreGraphics.CGRect(0, 20, View.Bounds.Width,
                View.Bounds.Height),
                Source = new TableSource(data)
            };

            View.AddSubview(tableView);
        }
    }
}