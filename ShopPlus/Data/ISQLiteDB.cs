using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopPlus.Data
{
    public interface ISQLiteDB
    {
        string SQLiteLocalPath(string bancoDados);
    }
}
