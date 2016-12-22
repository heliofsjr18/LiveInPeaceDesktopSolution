using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveInPeaceLibrary.ConnectionLayer;
using LiveInPeaceLibrary.BasicLayer;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace LiveInPeaceLibrary.DataLayer
{
    public interface IDAOUserType
    {
        void insert(UserType userType);
        void delete(UserType userType);
        UserType query(UserType userType);
        List<UserType> list();
    }
}
