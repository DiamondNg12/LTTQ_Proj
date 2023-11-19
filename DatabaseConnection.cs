﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LTTQ_Proj
{
    internal class DatabaseConnection
    {
        string connectionString;
        SqlConnection con;

        public DatabaseConnection()
        {
            string key = "connectionString";
            connectionString = ConfigurationManager.AppSettings[key];
            con = new SqlConnection(connectionString);
        }

        public void openConnection()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
          //  con.Dispose();
        }

        public DataTable dataTable(string selectQuery)
        {
            this.openConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, con);
            dataAdapter.Fill(dt);
            this.closeConnection();
            return dt;
        }

        public void dbQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            this.openConnection();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            this.closeConnection();
        }
    }
}
