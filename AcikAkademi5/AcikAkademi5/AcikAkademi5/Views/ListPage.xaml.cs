using AcikAkademi5.Models;
using AcikAkademi5.Provider;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AcikAkademi5.Views
{
    public partial class ListPage : ContentPage
    {
        readonly ServiceManager manager = new ServiceManager();
        readonly IList<StudentModel> model = new ObservableCollection<StudentModel>();

        public ListPage()
        {
            BindingContext = model;
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            this.IsBusy = true;
            try
            {
                model.Clear();
                await Task.Delay(2000);
                var collection = await manager.GetAll();
                foreach (StudentModel item in collection)
                    model.Add(item);
            }
            finally
            {
                this.IsBusy = false;
            }
        }

        private void onNew(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Insert());
        }

        private void onRefresh(object sender, EventArgs e)
        {
            LoadData();
        }

        private void onSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListView lstView = (ListView)sender;
            if (e.SelectedItem != null)
            {
                var selectedStudent = (StudentModel)e.SelectedItem;
                Navigation.PushAsync(new DetailPage(selectedStudent));
            }

            lstView.SelectedItem = null;
        }

        private async void onDelete(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var selectedStudent = (StudentModel)menuItem.CommandParameter;
            var isOk = await DisplayAlert("", "Are you sure?", "Yes", "No");
            if (isOk)
            {
                await manager.Delete(selectedStudent);
                model.Remove(selectedStudent);
            }
        }
    }
}