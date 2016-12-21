using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace LiveInPeaceLibrary.ConnectionLayer
{
    interface IConnectionClass
    {
        SqlConnection connect();
        void disconnect(SqlConnection connection);
    }
}
