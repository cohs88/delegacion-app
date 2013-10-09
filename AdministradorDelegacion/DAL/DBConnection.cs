using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using System.Configuration;

/*
namespace GestionEscolar.DAL
{*/
    public class DBConnection
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataSet ds = new DataSet();
        public DBConnection()
        {
            this.connection = new SqlConnection(ConfigurationManager.AppSettings["connection"]);
        }
        public SqlConnection OpenConn()
        {
            try
            {
                if (this.connection.State == ConnectionState.Closed || this.connection.State == ConnectionState.Broken)
                {
                    this.connection.Open();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return this.connection;
        }
        public SqlConnection CloseConn()
        {
            if (this.connection.State == ConnectionState.Open)
            {
                this.connection.Close();
            }
            return this.connection;
        }
        public DataTable Select(string query, params SqlParameter[] parametros)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["connection"]))
            {
                try
                {
                    cn.Open();
                }
                catch (Exception)
                {
                    
                    throw;
                }
                
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    if (parametros != null)
                    {
                        foreach (SqlParameter param in parametros)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
                    {
                        adap.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public DataSet SelectDS(string query, params SqlParameter[] parametros)
        {
            DataSet dt = new DataSet();

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["connection"]))
            {
                try
                {
                    cn.Open();
                }
                catch (Exception)
                {

                    throw;
                }

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    if (parametros != null)
                    {
                        foreach (SqlParameter param in parametros)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
                    {
                        adap.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public void NonQuery(string query, params SqlParameter[] parametros)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["connection"]))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    if (parametros != null)
                    {
                        foreach (SqlParameter param in parametros)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Inserta registro y retorna el identificador
        /// </summary>
        /// <param name="query">consulta</param>
        /// <param name="parametros">parametros</param>
        /// <returns></returns>
        public int Insert(string query, params SqlParameter[] parametros)
        {
            int id = 0;
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["connection"]))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    if (parametros != null)
                    {
                        foreach (SqlParameter param in parametros)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    try
                    {
                        id = int.Parse(cmd.ExecuteScalar().ToString());
                    }
                    catch (Exception)
                    {

                    }
                    
                }
            }
            return id;
        }

        

    }
/*}*/
