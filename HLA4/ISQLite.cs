
using SQLite.Net;

namespace HLA4
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
