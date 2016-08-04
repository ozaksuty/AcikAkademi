using Ders4.Models;

using Xamarin.Forms;

namespace Ders4.Views
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Student _student)
        {
            InitializeComponent();
            Padding = new Thickness(Device.OnPlatform(20, 0, 0));
            lblName.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            lblSurname.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));

            lblName.Text = _student.Name;
            lblSurname.Text = _student.Surname;
        }
    }
}
