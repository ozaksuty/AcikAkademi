using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Ders6
{
    [Activity(Label = "InsertActivity")]
    public class InsertActivity : Activity
    {
        EditText txtUserName;
        EditText txtPassword;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.InsertPerson);

            txtUserName = FindViewById<EditText>(Resource.Id.txtInsertUser);
            txtPassword = FindViewById<EditText>(Resource.Id.txtInsertPassword);

            Button btnInsert = FindViewById<Button>(Resource.Id.btnInsert);

            btnInsert.Click += BtnInsert_Click;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            MainActivity.persons.Add(new Person
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            });

            Toast.MakeText(this, txtUserName.Text + " eklendi.", ToastLength.Short).Show();
        }
    }
}