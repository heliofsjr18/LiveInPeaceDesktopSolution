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
    public interface IDAOWarning
    {
        void insert(Warning warning);
        void delete(Warning warning);
        Warning query(Warning warning);
        List<Warning> list();
    }
}
