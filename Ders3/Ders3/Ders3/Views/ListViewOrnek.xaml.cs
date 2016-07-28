using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Ders3.Views
{
    public class AcikAkademi
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }

    public partial class ListViewOrnek : ContentPage
    {
        public ListViewOrnek()
        {
            InitializeComponent();

            List<AcikAkademi> akademi = new List<AcikAkademi>();
            akademi.Add(new AcikAkademi { ID = 1, Name = "Yiğit", ImageUrl = "logo.png" });
            akademi.Add(new AcikAkademi { ID = 2, Name = "Mustafa", ImageUrl = "logo.png" });
            akademi.Add(new AcikAkademi { ID = 3, Name = "Aydın", ImageUrl = "logo.png" });

            //lstView.ItemsSource = akademi;
            //BindingContext = akademi;
            lstView.BindingContext = akademi;
        }

        private void onSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            AcikAkademi selected = (AcikAkademi)e.SelectedItem;
            DisplayAlert("Açık Akademi", selected.Name, "OK");

            ListView lstView = (ListView)sender;
            lstView.SelectedItem = null;
        }

        private void onClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DisplayAlert("Button", btn.CommandParameter.ToString(), "OK");
        }
    }
}
