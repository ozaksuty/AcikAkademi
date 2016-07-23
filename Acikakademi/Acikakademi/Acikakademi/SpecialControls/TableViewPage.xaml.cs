using Xamarin.Forms;

namespace Acikakademi.SpecialControls
{
    public partial class TableViewPage : ContentPage
    {
        public TableViewPage()
        {
            InitializeComponent();

            var section = new TableSection("Ring") {
                new SwitchCell {Text = "New Voice Mail"},
                new SwitchCell {Text = "New Mail", On = true}
            };
        }
    }
}