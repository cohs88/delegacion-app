using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace AdministradorDelegacion.BLL
{
    class Rol
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Rol()
        {
            this.id = 0;
            this.nombre = "";
        }

        public Rol(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public DataTable Get()
        {
            DataTable dt = new DataTable();
            DBConnection dbconnectionObj = new DBConnection();
            string query = @"
select id, nombre from roles
";
            dt = dbconnectionObj.Select(query, null);
            return dt;
        }
    }
}
