using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            txt_course_code.Text = "Auto Generate";
            txt_course_fee.Text = "NULL";
        }

        private void txt_course_fee_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void btn_add_course_Click(object sender, EventArgs e)
        {
            string subject = txt_course_subject.Text;
            string course_day = txt_course_day.Text;
            string aca_year = txt_aca_year.Text;
            

            List<string> sections = new List<string>();

            if (cbA.Checked) sections.Add("A");
            if (cbB.Checked) sections.Add("B");
            if (cbC.Checked) sections.Add("C");
            if (cbD.Checked) sections.Add("D");

            string section = string.Join(",", sections);

            if (subject == "" || course_day == "" || aca_year == "" || section == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            try
            {
               
                string queryCourse = "INSERT INTO Course (CourseSubject, CourseDay) VALUES ('" + subject + "', '" + course_day + @"'); SELECT SCOPE_IDENTITY();";

                var res1 = Database.ExecuteScalarQuery(queryCourse);

                if (res1.HasError)
                {
                    MessageBox.Show(res1.Message);
                    return;
                }

                int course_code = Convert.ToInt32(res1.Data.Rows[0][0]);

                
                string queryAca = "INSERT INTO AcademicYear (AcademicYear, SectionName, CourseCode) VALUES ('" + aca_year + "', '" + section + "', '" + course_code + "')";

                var res2 = Database.ExecuteNonResultQuery(queryAca);

                if (res2.HasError)
                {
                    MessageBox.Show(res2.Message);
                    return;
                }

                MessageBox.Show("Course added successfully.");

                
                txt_course_subject.Clear();
                txt_course_day.Clear();
                txt_aca_year.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            Form3 home = new Form3();
            home.Show();

            this.Hide();
        }
    }
}
