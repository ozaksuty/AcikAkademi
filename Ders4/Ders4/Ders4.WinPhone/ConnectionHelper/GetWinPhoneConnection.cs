using Ders4.Helper;
using Ders4.WinPhone.ConnectionHelper;
using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using Windows.Storage;

[assembly: Xamarin.Forms.Dependency(typeof(GetWinPhoneConnection))]
namespace Ders4.WinPhone.ConnectionHelper
{
    public class GetWinPhoneConnection : ISQLiteConnection
    {
        public SQLiteConnection GetConnection()
        {
            var path = System.IO.Path.Combine(ApplicationData.Current.LocalFolder.Path,
                Ders4.App.DbName);
            var platform = new SQLitePlatformWinRT();
            var connection = new SQLiteConnection(platform, path);
            return connection;
        }
    }
}