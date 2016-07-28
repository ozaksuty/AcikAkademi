using Ders3.Data;
using System;
using Xamarin.Forms;

namespace Ders3.Views
{
    public partial class SanalSiniflar : ContentPage
    {
        public SanalSiniflar()
        {
            InitializeComponent();
            lstMVA.BindingContext = MVAFactory.BindingWithGrouping();
            txtSearch.TextColor = Device.OnPlatform(Color.Black, Color.White, Color
                .Default);
        }

        private async void onSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            ListView lv = (ListView)sender;
            var selectedMVA = (MVAFactory.MVA)e.SelectedItem;
            bool isOk = await DisplayAlert(selectedMVA.PublishDate.ToString("yyyy-MM-dd")
                + " " + selectedMVA.Title, selectedMVA.Description, "Detay", "Vaçgeç");

            if (isOk)
            {
                Navigation.PushAsync(new Detail(selectedMVA));
                //Navigation.PushModalAsync(new Detail(selectedMVA));
            }

            lv.SelectedItem = null;
        }

        private void onRefresh(object sender, EventArgs e)
        {
            MVAFactory.RefreshCount++;
            lstMVA.BindingContext = MVAFactory.BindingWithGrouping();
            lstMVA.IsRefreshing = false;
        }

        private void onTextChanged(object sender, TextChangedEventArgs e)
        {
            lstMVA.BindingContext = MVAFactory.BindingWithGrouping(e.NewTextValue);
        }

        private void onMenuItemClicked(object sender, EventArgs e)
        {
            DisplayAlert("Güncelle", "Menu Item", "Tamam", "Vazgeç");
        }
    }
}