using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Ders6
{
    [Activity(Label = "Ders6", MainLauncher = true, Icon = "@drawable/icon",
        ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class MainActivity : Activity
    {
        public static List<Person> persons = new List<Person>();

        Button btnLogin;
        EditText txtUserName;
        EditText txtPassword;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            txtUserName = FindViewById<EditText>(Resource.Id.txtUserName);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);

            Button btnGoToInsertPage = FindViewById<Button>(Resource.Id.btnGoToInsertPage);
            btnGoToInsertPage.Click += BtnGoToInsertPage_Click;

            Button btnGoToListPage = FindViewById<Button>(Resource.Id.btnGoToListPage);
            btnGoToListPage.Click += BtnGoToListPage_Click;

            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnGoToListPage_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(ListActivity));
        }

        private void BtnGoToInsertPage_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(InsertActivity));
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //TODO
            //Toast.MakeText(this, txtUserName.Text, ToastLength.Long).Show();
            //StartActivity(typeof(LoginActivity));

            var intent = new Intent(this, typeof(LoginActivity));

            //intent.PutExtra("username", txtUserName.Text);
            //intent.PutExtra("password", txtPassword.Text);

            Person _person = new Person
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            };

            intent.PutExtra("person", _person.ToJson());


            StartActivity(intent);
        }
    }
}

