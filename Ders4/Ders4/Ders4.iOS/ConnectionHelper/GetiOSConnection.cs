using Ders4.Helper;
using Ders4.iOS.ConnectionHelper;
using SQLite.Net;
using SQLite.Net.Platform.XamarinIOS;

[assembly: Xamarin.Forms.Dependency(typeof(GetiOSConnection))]
namespace Ders4.iOS.ConnectionHelper
{
    public class GetiOSConnection : ISQLiteConnection
    {
        public SQLiteConnection GetConnection()
        {
            var documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = System.IO.Path.Combine(documentPath, App.DbName);
            var platform = new SQLitePlatformIOS();
            var connection = new SQLiteConnection(platform, path);
            return connection;
        }
    }
}