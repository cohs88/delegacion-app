using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace AdministradorDelegacion.BLL
{
    class Personal
    {
        public DataTable GetList()
        {
            DataTable dt = new DataTable();
            DBConnection dbconnectionObj = new DBConnection();
            string query = @"
select id, nombre from personal
";
            dt = dbconnectionObj.Select(query, null);
            return dt;
        }
    }
}
