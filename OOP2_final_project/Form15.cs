using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form15 : Form
    {
        Form home;
        public Form15(Form sender)
        {
            InitializeComponent();
            home = sender;
        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            home.Show();

            this.Hide();
        }

        private void lbl_course_list_Click(object sender, EventArgs e)
        {
            Form15_Load(sender, e);
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            try
            {
                var query = "SELECT CourseCode, CourseSubject, CourseDay, CourseFee FROM Course";

                var result = Database.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgvResult.DataSource = result.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int selectedCourseCode;
        private void dgvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCourseCode = int.Parse(dgvResult.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int CourseCode = int.Parse(txtSearch.Text);

            try
            {
                String querySearch = "SELECT CourseCode, CourseSubject, CourseDay, CourseFee FROM Course U WHERE U.CourseCode = " + CourseCode;

                var result = Database.GetQueryData(querySearch);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    dgvResult.DataSource = result.Data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String queryDelete = "DELETE FROM Course WHERE CourseCode = " + selectedCourseCode;
                var result = Database.ExecuteNonResultQuery(queryDelete);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    MessageBox.Show("Course deleted successfully.");
                    Form15_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
