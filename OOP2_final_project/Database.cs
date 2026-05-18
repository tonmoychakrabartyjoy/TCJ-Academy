using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text;
using static OOP2_final_project.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP2_final_project
{
    public class Database
    {

        public class Result
        {
            public bool HasError { get; set; }
            public string Message { get; set; }
            public DataTable Data { get; set; }
        }


        public static SqlConnection con = new SqlConnection(@"Data Source=TONMOY\SQLEXPRESS;Initial Catalog=TCJ_Academy;Integrated Security=True; TrustServerCertificate=True;");


        // Tonmoy 

        public static Result ExecuteScalarQuery(string query)
        {
            var result = new Result();

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                result.Data = new DataTable();
                result.Data.Columns.Add("Value");

                var val = cmd.ExecuteScalar();
                result.Data.Rows.Add(val);

                con.Close();
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Message = ex.Message;
            }

            return result;
        }



        public static Result GetQueryData(string query)
        {
            var result = new Result();

            try
            {
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                result.Data = ds.Tables[0];
                con.Close();
            }

            catch (Exception exception)
            {
                result.HasError = true;
                result.Message = exception.Message;
                return result;
            }

            return result;
        }

        public static Result ExecuteNonResultQuery(string query)
        {
            var result = new Result();
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception exception)
            {
                result.HasError = true;
                result.Message = exception.Message;
                return result;
            }

            return result;
        }

        // Tonmoy
    }
}
