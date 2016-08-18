
using Android.App;
using Android.OS;
using Android.Widget;
using Newtonsoft.Json;

namespace Ders6
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LoginPage);

            //string userName = Intent.GetStringExtra("username");
            //string password = Intent.GetStringExtra("password");

            var _person = Intent.GetStringExtra("person");
            Person selectedPerson = Helper.FromJson<Person>(_person);

            Title = selectedPerson.UserName;

            TextView tView = FindViewById<TextView>(Resource.Id.lblUserName);
            tView.Text = selectedPerson.UserName;
        }
    }
}