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
            dgvResult.Refresh();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            try
            {
                var query = "SELECT CourseCode, CourseSubject, CourseDay, CourseFee FROM Course";
                dgvResult.DataSource = Database.GetData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
