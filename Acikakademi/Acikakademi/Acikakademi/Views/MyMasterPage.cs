using Acikakademi.MasterSayfalar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Acikakademi.Views
{
    public class MyMasterPage : MasterDetailPage
    {
        public MyMasterPage()
        {
            Title = "Açık Akademi";
            Master = new MyMenu();
            Detail = new NavigationPage(new MyDetail());
        }
    }
}