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
        }

        private void button7_Click(object sender, EventArgs e)
        {

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
    }
}
