using Xamarin.Forms;

namespace Acikakademi.Layouts
{
    public class RelativeOrnek : ContentPage
    {
        public RelativeOrnek()
        {
            RelativeLayout layout = new RelativeLayout();

            BoxView blue = new BoxView();
            blue.BackgroundColor = Color.Blue;

            BoxView red = new BoxView();
            red.BackgroundColor = Color.Red;

            red.Opacity = 0.6;

            layout.Children.Add(blue, Constraint.Constant(50),
                Constraint.Constant(50));

            //layout.Children.Add(red, Constraint.Constant(70),
            //    Constraint.Constant(70));


            layout.Children.Add(red, Constraint.RelativeToParent((parent) =>
            {
                return parent.X + 70;
            }), Constraint.RelativeToView(blue, (parent, toView) =>
            {
                return toView.Y;
            }));

            Content = layout;
        }
    }
}