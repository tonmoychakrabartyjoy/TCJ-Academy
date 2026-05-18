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
    }
}
