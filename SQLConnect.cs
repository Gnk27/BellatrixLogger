using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BellatrixLogger
{
    public class SQLConnect
    {
        private SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        public void Conectar()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.ConnectionString = @"data source = ENVYM4; initial catalog = TI; Integrated Security = true;";
                try
                {
                    conn.Open();
                }
                catch (Exception ex) { }
            }
        }

        public void Desconectar()
        {
            conn.Close();
        }

        public DataTable Seleccionar(string query)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            return table;
        }

        public void Insertar(string query)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            cmd.ExecuteNonQuery();
        }
    }
}