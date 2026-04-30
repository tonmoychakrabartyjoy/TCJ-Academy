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
            txt_course_fee.Text = "NULL";
        }

        private void txt_course_fee_TextChanged(object sender, EventArgs e)
        {
            
        }
        

        private void btn_add_course_Click(object sender, EventArgs e)
        {
            string course_code = txt_course_code.Text;
            string subject = txt_course_subject.Text;
            string course_day = txt_course_day.Text;
            string aca_year = txt_aca_year.Text;
            string section;

            MessageBox.Show("Course added successfull");
        }

        private void lb_co_Name_Click(object sender, EventArgs e)
        {
            Form3 home = new Form3();
            home.Show();

            this.Hide();
        }
    }
}
