using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP2_final_project
{
    public class Database
    {
        public static SqlConnection con = new SqlConnection(@"Data Source = Tonmoy\SQLEXPRESS; Initial Catalog = TCJ_Academy; Integrated Security = True; TrustServerCertificate=True;");

        public static void AddQuery(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
