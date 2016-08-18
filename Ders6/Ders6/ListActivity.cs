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
    [Activity(Label = "ListActivity")]
    public class ListActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ListPage);

            ListView lstPersons = FindViewById<ListView>(Resource.Id.lstPersons);

            ArrayAdapter<Person> adapter = new ArrayAdapter<Person>
                (this, Android.Resource.Layout.SimpleListItem1,
                 Android.Resource.Id.Text1, MainActivity.persons);

            lstPersons.Adapter = adapter;
            lstPersons.ItemClick += LstPersons_ItemClick;
            lstPersons.FastScrollEnabled = true;
            lstPersons.FastScrollAlwaysVisible = true;
        }

        private void LstPersons_ItemClick(object sender, 
            AdapterView.ItemClickEventArgs e)
        {
            var id = e.Id;
            var parent = e.Parent;
            var position = e.Position; //index number.
            var view = e.View;

            var selectedPerson = MainActivity.persons[position];
            Toast.MakeText(this, selectedPerson.UserName, ToastLength.Long).Show();
        }
    }
}