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

            List<string> sections = new List<string>();

            if (cbA.Checked) sections.Add("A");
            if (cbB.Checked) sections.Add("B");
            if (cbC.Checked) sections.Add("C");
            if (cbD.Checked) sections.Add("D");

            if (subject == "" || course_day == "" || sections.Count == 0)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            try
            {
                string queryCourse = "INSERT INTO Course (courseSubject, courseDay) " + "VALUES ('" + subject + "', '" + course_day + "'); " + "SELECT SCOPE_IDENTITY();";

                var res1 = Database.ExecuteScalarQuery(queryCourse);

                if (res1.HasError)
                {
                    MessageBox.Show(res1.Message);
                    return;
                }

                int course_code = Convert.ToInt32(res1.Data.Rows[0][0]);

                
                foreach (string sec in sections)
                {
                    string querySec =
                        "SELECT section_id FROM Section WHERE SectionName = '" + sec + "'";

                    var resSec = Database.ExecuteScalarQuery(querySec);

                    if (resSec.HasError)
                    {
                        MessageBox.Show(resSec.Message);
                        return;
                    }

                    int section_id = Convert.ToInt32(resSec.Data.Rows[0][0]);

                    string queryMap = "INSERT INTO Section_Course (section_id, course_code) VALUES (" + section_id + ", " + course_code + ")";

                    var resMap = Database.ExecuteNonResultQuery(queryMap);

                    if (resMap.HasError)
                    {
                        MessageBox.Show(resMap.Message);
                        return;
                    }
                }

                MessageBox.Show("Course added successfully.");

                txt_course_subject.Clear();
                txt_course_day.Clear();
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

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
