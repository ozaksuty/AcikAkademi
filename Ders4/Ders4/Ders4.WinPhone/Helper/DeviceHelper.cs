using Ders4.Helper;
using Ders4.WinPhone.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace Ders4.WinPhone.Helper
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "Ders4.WinPhone ortamı çalıştırıldı!";
        }
    }
}