using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveInPeaceLibrary.ConnectionLayer
{
    class ConnectionClass : IConnectionClass
    {
        String sqlInitConnection;
        SqlConnection connection;
        public SqlConnection connect()
        {
            try
            {
                if (DBInit.IntegratedSecurity == "T")
                    sqlInitConnection = @"Data Source=" + DBInit.URL + ";Initial Catalog=" + DBInit.DBName + ";User ID=" + DBInit.User + ";Password=" + DBInit.Password + ";Integrated Security=sspi" + ";";
                else
                    sqlInitConnection = @"Data Source=" + DBInit.URL + ";Initial Catalog=" + DBInit.DBName + ";User ID=" + DBInit.User + ";Password=" + DBInit.Password + ";";

                connection = new SqlConnection(sqlInitConnection);
                connection.Open();

                return connection;
            }
            catch (InvalidOperationException invalidEx)
            {
                throw invalidEx;
            }
            catch (SqlException sqlEx)
            {
                throw sqlEx;
            }
        }

        public void disconnect(SqlConnection connection)
        {
            connection.Close();
            connection.Dispose();
        }
    }
}
