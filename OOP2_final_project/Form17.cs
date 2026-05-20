using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(@"Data Source=TONMOY\SQLEXPRESS;Initial Catalog=TCJ_Academy;Integrated Security=True;TrustServerCertificate=True;");


        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            Form6 home = new Form6();
            home.Show();

            this.Hide();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            dgv_emp_table.AutoGenerateColumns = false;

            try
            {
                var query = @"
            SELECT U.UserId, U.UserName, U.Phone, U.Address
            FROM Users U, UserTypeRole UR, UserType UT
            WHERE U.UserId = UR.UserId
            AND UR.UserTypeId = UT.UserTypeId
            AND UT.UserType = 'Employee'";

                var result = Database.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgv_emp_table.DataSource = result.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbl_emp_list_Click(object sender, EventArgs e)
        {
            Form17_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int empId = int.Parse(txtSearch.Text);

            try
            {
                String querySearch = "SELECT U.UserId, U.UserName, U.Phone, U.Address FROM Users U WHERE U.UserId = " + empId;

                var result = Database.GetQueryData(querySearch);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    dgv_emp_table.DataSource = result.Data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public static int selectedEmpId;
        private void dgv_emp_table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedEmpId = int.Parse(dgv_emp_table.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String queryDelete = "DELETE FROM Users WHERE UserId = " + selectedEmpId;
                var result = Database.ExecuteNonResultQuery(queryDelete);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    MessageBox.Show("Employee deleted successfully.");
                    Form17_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
