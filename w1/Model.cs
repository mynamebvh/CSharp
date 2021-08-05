﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace w1
{
    class Model
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-GFOAS18\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True");
        }

        public DataTable GetTable(string sql) 
        {
            SqlConnection conn = GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn); 
            DataTable table = new DataTable();
            adapter.Fill(table); 
            return table;
        }

        public void ExecuteNonQuery(string sql) 
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
