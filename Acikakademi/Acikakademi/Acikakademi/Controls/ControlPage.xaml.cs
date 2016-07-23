using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Acikakademi.Controls
{
    public partial class ControlPage : ContentPage
    {
        public ControlPage()
        {
            InitializeComponent();

            dtPicker.MinimumDate = DateTime.Now.AddYears(-1);
            dtPicker.MaximumDate = DateTime.Now.AddYears(1);
            dtPicker.Date = DateTime.Now;
            dtPicker.Format = "yyyy-MM-dd";
        }

        int i = 0;
        private void OnClicked(object sender, EventArgs e)
        {
            progressBar.ProgressTo(.8, 1250, Easing.SpringIn);
            if (i % 2 == 0)
                activity.IsRunning = true;
            else
                activity.IsRunning = false;
            i++;
        }

        private void onChanged(object sender, EventArgs e)
        {
            Picker pckr = (Picker)sender;
            string name = pckr.Items[pckr.SelectedIndex];
            DisplayAlert("Picker", name, "OK", "CANCEL");
        }

        private void onDateSelected(object sender, DateChangedEventArgs e)
        {
            DisplayAlert("DatePicker", e.NewDate.ToString(), "OK", "CANCEL");
        }

        private void onValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblSliderValue.Text = e.NewValue.ToString();
        }

        private void onStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblSliderValue.Text = e.NewValue.ToString();
        }

        private void onToggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Switch", e.Value.ToString(),
                "OK", "CANCEL");
        }
    }
}
