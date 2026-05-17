using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.CompilerServices;

namespace OOP2_final_project
{
    public class Database
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=TONMOY\SQLEXPRESS;Initial Catalog=TCJ_Academy;Integrated Security=True; TrustServerCertificate=True;");


        // Tonmoy 
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

        public static DataTable GetData(string query)
        {
            con.Open();
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.Fill(dt);

                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                con.Close(); 
            }
            return dt;
        }

        // tonmoy
    }
}
