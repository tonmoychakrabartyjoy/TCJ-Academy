using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form10 : Form
    {
        private Form home;
        public Form10(Form sender)
        {
            InitializeComponent();
            this.home = sender;
        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            home.Show();

            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            dgvs.AutoGenerateColumns = false;

            try
            {
                var query = @"SELECT U.UserId, U.UserName, U.Phone, U.Address FROM Users U, UserTypeRole UR, UserType UT WHERE U.UserId = UR.UserId AND UR.UserTypeId = UT.UserTypeId AND UT.UserType = 'Student'";

                var result = Database.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgvs.DataSource = result.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbl_student_Click(object sender, EventArgs e)
        {
            Form10_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int StudentId = int.Parse(txtSearch.Text);

            try
            {
                String querySearch = "SELECT U.UserId, U.UserName, U.Phone, U.Address FROM Users U WHERE U.UserId = " + StudentId;

                var result = Database.GetQueryData(querySearch);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    dgvs.DataSource = result.Data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int selectedStudentId;
        private void dgvs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedStudentId = int.Parse(dgvs.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String queryDelete = "DELETE FROM Users WHERE UserId = " + selectedStudentId;
                var result = Database.ExecuteNonResultQuery(queryDelete);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    MessageBox.Show("Student deleted successfully.");
                    Form10_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
