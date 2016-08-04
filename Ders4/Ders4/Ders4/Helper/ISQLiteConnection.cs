using SQLite.Net;

namespace Ders4.Helper
{
    public interface ISQLiteConnection
    {
        SQLiteConnection GetConnection();
    }
}