using System;
using System.Collections.Generic;
using SQLite.Net;
using Xamarin.Forms;

namespace HLA4
{
    public class DataAccess
    {
        SQLiteConnection dbConn;
        public DataAccess()
        {
            dbConn = DependencyService.Get<ISQLite>().GetConnection();
            // create the table(s)
            dbConn.CreateTable<Undergrad>();
        }
        public List<Undergrad> GetAllUndergrad()
        {
            return dbConn.Query<Undergrad>("Select * From [Undergrad]");
        }
        public int SaveUndergrad(Undergrad aUndergrad)
        {
            return dbConn.Insert(aUndergrad);
        }
        public int DeleteUndergrad(Undergrad aUndergrad)
        {
            return dbConn.Delete(aUndergrad);
        }
        public int EditUndergrad(Undergrad aUndergrad)
        {
            return dbConn.Update(aUndergrad);
        }
    }
}
