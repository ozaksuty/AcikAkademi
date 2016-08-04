using Ders4.Helper;
using Ders4.iOS.Helper;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace Ders4.iOS.Helper
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "Ders4.iOS ortamı çalıştırıldı!";
        }
    }
}