using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form3 : Form
    {
        string userid;
        public Form3()
        {
            InitializeComponent();
        }


        private void btn_add_exam_Click(object sender, EventArgs e)
        {
            Form4 create_exam = new Form4();
            create_exam.Show();

            this.Hide();
        }

        private void btn_upload_result_Click(object sender, EventArgs e)
        {
            Form5 upload_result = new Form5();
            upload_result.Show();

            this.Hide();
        }




        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_teacher_Click(object sender, EventArgs e)
        {
            Form9 add_teacher = new Form9();
            add_teacher.Show();

            this.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_course_Click(object sender, EventArgs e)
        {
            Form7 add_course = new Form7();
            add_course.Show();

            this.Hide();
        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            Form8 add_student = new Form8();
            add_student.Show();

            this.Hide();
        }
    }
}
