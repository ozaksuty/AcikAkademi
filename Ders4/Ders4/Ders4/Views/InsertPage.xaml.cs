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
    public partial class InsertPage : ContentPage
    {
        public InsertPage()
        {
            InitializeComponent();
        }

        private void onInsert(object sender, EventArgs e)
        {
            SQLiteManager manager = new SQLiteManager();
            Student _student = new Student();
            _student.Name = txtName.Text;
            _student.Surname = txtSurname.Text;
            _student.RegisterDate = DateTime.Now;

            int isInserted = manager.Insert(_student);
            if (isInserted > 0)
            {
                DisplayAlert("BAŞARILI", _student.Name + " eklendi.", "OK");
            }
            else
            {
                DisplayAlert("BAŞARISIZ", _student.Name + " eklenemedi.", "OK");
            }
        }
    }
}
