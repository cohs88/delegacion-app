using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace AdministradorDelegacion.BLL
{
    class Usuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string pwd { get; set; }
        public int empleado_id { get; set; }
        public int rol_id { get; set; }

        public Usuario()
        {
            this.id = 0;
            this.usuario = "";
            this.pwd = "";
            this.empleado_id = 0;
            this.rol_id = 0;
        }

        public Usuario(int id, string usuario, string pwd, int empleado_id, int rol_id)
        {
            this.id = id;
            this.usuario = usuario;
            this.pwd = pwd;
            this.empleado_id = empleado_id;
            this.rol_id = rol_id;
        }

        public bool Login(string usuario, string pwd)
        {
            DBConnection dbconnectionObj = new DBConnection();
            string query = "select usuario from usuarios where usuario = @usuario and pwd = HashBytes('MD5', cast(@pwd as varchar)) ";

            DataTable dt = dbconnectionObj.Select(query, 
                new SqlParameter("@usuario", usuario), 
                new SqlParameter("@pwd", pwd));

            return dt.Rows.Count > 0 ? true : false;
        }

        public void FillSession(string usuario)
        {
            DBConnection dbconnectionObj = new DBConnection();
            string query = @"select
u.id as usuario_id,
u.usuario as usuario,
p.id as empleado_id,
p.num_placa,
p.nombre as nombre_personal,
p.delegacion_id
from 
usuarios as u inner join personal as p on u.empleado_id = p.id
where u.usuario = @usuario";

            DataTable dt = dbconnectionObj.Select(query,
                new SqlParameter("@usuario", usuario)
                );
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Sesion.usuario_id = int.Parse(row["usuario_id"].ToString());
                    Sesion.empleado_id = int.Parse(row["empleado_id"].ToString());
                    Sesion.nombre_personal = row["nombre_personal"].ToString();
                    Sesion.num_placa = row["num_placa"].ToString();
                    Sesion.delegacion_id = int.Parse(row["delegacion_id"].ToString());
                }
            }
        }
    }
}
