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
    public partial class DetailPage : ContentPage
    {
        public DetailPage(StudentModel model)
        {
            InitializeComponent();
            txtName.Text = model.Name;
            txtSurname.Text = model.Surname;
            txtAbout.Text = model.About;
            dtpckrBirthDate.Date = model.BirthDate;
            BindingContext = model;
        }

        private async void onUpdate(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            var updatedStudent = (StudentModel)myButton.CommandParameter;
            StudentModel model = new StudentModel
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                About = txtAbout.Text,
                BirthDate = dtpckrBirthDate.Date,
                StudentID = updatedStudent.StudentID
            };

            ServiceManager manager = new ServiceManager();
            MobileResult result = await manager.Update(model);
            if (result.Result)
            {
                await DisplayAlert("Success", result.Message, "OK", "CANCEL");
                await Navigation.PopAsync();
            }
        }
    }
}
