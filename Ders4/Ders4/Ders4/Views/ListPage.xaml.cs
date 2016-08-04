using Ders4.Helper;
using Ders4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Ders4.Views
{
    public partial class ListPage : ContentPage
    {
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width > height)
            {
                //ImageSource.FromFile(.....);
            }
            else
            {
                //ImageSource.FromFile(.....);
            }
        }

        SQLiteManager manager;
        public ListPage()
        {
            InitializeComponent();
            Padding = new Thickness(Device.OnPlatform(20, 0, 0));
            List<Student> studentList = new List<Student>();
            manager = new SQLiteManager();
            studentList = manager.GetAll().ToList();
            lstStudents.BindingContext = studentList;
        }

        private void onMenuInsert(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertPage());
        }

        private void onMenuRefresh(object sender, EventArgs e)
        {
            RefreshData();
        }

        private async void onMenuDelete(object sender, EventArgs e)
        {
            var selectedMenuItem = (MenuItem)sender;
            var selectedStudent = manager.Get(Convert.ToInt32(selectedMenuItem
                .CommandParameter.ToString()));
            bool isOk = await DisplayAlert("UYARI", selectedStudent.Name + " silinecek", "OK", "CANCEL");
            if (isOk)
            {
                int isDeleted = manager.Delete(Convert.ToInt32(selectedMenuItem.CommandParameter.ToString()));
                if (isDeleted > 0)
                {
                    DisplayAlert("BAŞARILI", "SİLİNDİ", "OK");
                    RefreshData();
                }
                else
                {
                    DisplayAlert("BAŞARISIZ", "SİLİNEMEDİ", "OK");
                }
            }
        }

        private void onMenuDetail(object sender, EventArgs e)
        {
            var selectedMenuItem = (MenuItem)sender;
            var selectedStudent = manager.Get(Convert.ToInt32(selectedMenuItem
                .CommandParameter.ToString()));

            Navigation.PushAsync(new DetailPage(selectedStudent));
        }

        private void RefreshData()
        {
            List<Student> studentList = new List<Student>();
            studentList = manager.GetAll().ToList();
            lstStudents.BindingContext = studentList;
        }
    }
}
