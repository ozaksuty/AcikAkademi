using AcikAkademi5.Models;
using AcikAkademi5.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AcikAkademi5.Views
{
    public partial class Insert : ContentPage
    {
        public Insert()
        {
            InitializeComponent();
        }

        private async void onSave(object sender, EventArgs e)
        {
            StudentModel model = new StudentModel
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                About = txtAbout.Text,
                BirthDate = dtpckrBirthDate.Date
            };

            ServiceManager manager = new ServiceManager();
            MobileResult result = await manager.Insert(model);
            if (result.Result)
            {
                await DisplayAlert("Success", result.Message, "Ok", "Cancel");
                Navigation.PopModalAsync();
            }
            else
            {
                DisplayAlert("Error", result.Message, "Ok", "Cancel");
            }
        }
    }
}
