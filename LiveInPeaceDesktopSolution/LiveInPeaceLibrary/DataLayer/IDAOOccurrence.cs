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
    public interface IDAOOccurrence
    {
        void insert(Occurrence occurrence);
        void delete(Occurrence occurrence);
        Occurrence query(Occurrence occurrence);
        List<Occurrence> list();
    }
}