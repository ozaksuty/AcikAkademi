using Ders4.Models;
using SQLite.Net;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Ders4.Helper
{
    public class SQLiteManager
    {
        SQLiteConnection _sqlconnection;

        public SQLiteManager()
        {
            _sqlconnection = DependencyService.Get<ISQLiteConnection>().GetConnection();
            _sqlconnection.CreateTable<Student>();
        }

        #region CRUD
        public int Insert(Student s)
        {
            return _sqlconnection.Insert(s);
        }

        public int Update(Student s)
        {
            return _sqlconnection.Update(s);
        }

        public int Delete(int Id)
        {
            return _sqlconnection.Delete<Student>(Id);
        }

        public IEnumerable<Student> GetAll()
        {
            //return (from i in _sqlconnection.Table<Student>() select i);
            return _sqlconnection.Table<Student>();
        }

        public Student Get(int Id)
        {
            return _sqlconnection.Table<Student>().Where(x => x.Id == Id).FirstOrDefault();
        }

        public void Dispose()
        {
            _sqlconnection.Dispose();
        }
        #endregion
    }
}