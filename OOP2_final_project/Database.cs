using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.CompilerServices;

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

        public static object GetValue(string query)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            object result = cmd.ExecuteScalar();

            con.Close();
            return result;
        }

        public static void showData(string query, DataGridView dataGridView)
        {
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            DataSet Set = new DataSet();
            adp.Fill(Set);

            DataTable dt = Set.Tables[0];
            dataGridView.DataSource = dt;
            dataGridView.Refresh();
            con.Close();
        }
    }
}
