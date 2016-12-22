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
    public interface IDAOFine
    {
        void insert(Fine fine);
        void delete(Fine fine);
        Fine query(Fine fine);
        List<Fine> list();
    }
}
