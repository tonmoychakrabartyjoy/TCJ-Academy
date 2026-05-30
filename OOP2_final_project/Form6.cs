using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_final_project
{
    public partial class Form6 : Form
    {
        string userid;
        public Form6()
        {
            InitializeComponent();
            lblName.Text = Case.UserName;

        }

        private void btn_add_course_fee_Click(object sender, EventArgs e)
        {
            Form18 add_course_fee = new Form18();
            add_course_fee.Show();

            this.Hide();
        }

        private void btn_student_list_Click(object sender, EventArgs e)
        {
            Form10 student_list = new Form10(this);
            student_list.Show();

            this.Hide();
        }

        private void btn_teacher_list_Click(object sender, EventArgs e)
        {
            Form11 teacher_list = new Form11(this);
            teacher_list.Show();

            this.Hide();
        }

        private void btn_show_result_Click(object sender, EventArgs e)
        {
            Form14 show_result = new Form14(this);
            show_result.Show();

            this.Hide();
        }

        private void btn_course_list_Click(object sender, EventArgs e)
        {
            Form15 course_list = new Form15(this);
            course_list.Show();

            this.Hide();
        }

        private void btn_add_emp_Click(object sender, EventArgs e)
        {
            Form16 add_emp = new Form16();
            add_emp.Show();

            this.Hide();
        }

        private void btn_emp_list_Click(object sender, EventArgs e)
        {
            Form17 emp_list = new Form17();
            emp_list.Show();

            this.Hide();
        }



        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login login_page = new login();
            login_page.Show();

            this.Close();
        }

        private void btn_add_exam_Click(object sender, EventArgs e)
        {
            Form4 create_exam = new Form4(this);
            create_exam.Show();

            this.Hide();
        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            Form8 add_student = new Form8(this);
            add_student.Show();

            this.Hide();
        }

        private void btn_add_teacher_Click(object sender, EventArgs e)
        {
            Form9 add_teacher = new Form9(this);
            add_teacher.Show();

            this.Hide();
        }

        private void btn_upload_result_Click(object sender, EventArgs e)
        {
            Form5 upload_result = new Form5(this);
            upload_result.Show();

            this.Hide();
        }

        private void btn_update_student_Click(object sender, EventArgs e)
        {
            Form12 update_students = new Form12(this);
            update_students.Show();

            this.Hide();
        }

        private void btn_add_course_Click(object sender, EventArgs e)
        {
            Form7 add_course = new Form7(this);
            add_course.Show();

            this.Hide();
        }
    }
}
